using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Service
{
    public class UsuarioServico
    {
        private AppDataContext Context;

        public UsuarioServico(AppDataContext con)
        {
            Context = con;
        }

        //public List<Usuario> GetFuncoes(int depId)
        //{
        //    var id = (from p in Context.Departamentos
        //              where p.Id == depId
        //              select p.Id).ToList();

        //    var resposta = (from c in Context.Funcoes
        //                    join b in Context.Departamentos on c.Departamento.Id equals b.Id
        //                    where c.Departamento.Id == depId
        //                    select c).ToList();

        //    return (resposta);
        //}

        public List<Usuario> GetUsuarios()
        {
            var resposta = (from p in Context.Usuarios
                            select p).ToList();

            return (resposta);
        }

        public Usuario GetUsuario(int id)
        {
            return Context.Usuarios.Where(x => x.Id == id).FirstOrDefault();
        }

        public Usuario GetUsuario(string nome, string senha)
        {
            return Context.Usuarios.Where(x => x.Login == nome && x.Senha == senha).FirstOrDefault();
        }

        public bool GetUsuarioLogin(string usuario)
        {
            var result = Context.Usuarios.Where(x => x.Login == usuario).FirstOrDefault();

            if (result != null)
                return true;
            else
                return false;

        }

        public bool GetSenha(string senha)
        {
            var result = Context.Usuarios.Where(x => x.Senha == senha).FirstOrDefault();

            if (result != null)
                return true;
            else
                return false;
        }

        public DataTable GetUsuarioGrid()
        {
            var results = Context.Usuarios
                .Select(p => new
                {
                    p.Id,
                    p.Login,
                    p.Perfil,
                })
                .AsEnumerable()
                .ToList();

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Id", typeof(int));
            tabela.Columns.Add("Usuario", typeof(string));
            tabela.Columns.Add("Perfil", typeof(string));

            foreach (var item in results)
            {
                DataRow linha = tabela.NewRow();
                linha["Id"] = item.Id;
                linha["Usuario"] = item.Login;
                linha["Perfil"] = item.Perfil;
                tabela.Rows.Add(linha);
            }

            return (tabela);
        }

        public bool Insert(Usuario usuario)
        {
            Context.Usuarios.Add(usuario);
            Context.SaveChanges();
            return true;
        }

        public bool Delete(Usuario usuario)
        {
            Context.Entry(usuario).State = System.Data.Entity.EntityState.Deleted;
            Context.Usuarios.Remove(usuario);
            Context.SaveChanges();
            return true;
        }

        public bool Update(Usuario usuario)
        {
            Context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
            return true;
        }

        public bool VerificarDependencias(int id)
        {
            var list = Context.Funcoes.Where(x => x.Departamento.Id == id).ToList();
            if (list.Count > 0)
                return false;
            else
                return true;
        }
    }
}
