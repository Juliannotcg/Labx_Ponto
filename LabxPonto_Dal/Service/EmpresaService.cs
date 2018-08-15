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
    public class EmpresaService
    {
        private AppDataContext Context;

        public EmpresaService(AppDataContext con)
        {
            Context = con;
        }

        public bool Insert(Empresa empresa)
        {
            Context.Empresas.Add(empresa);
            Context.SaveChanges();
            return true;
        }

        public Empresa GetEmpresa(int id)
        {
            return Context.Empresas.Include("Endereco")
                    .Include("Imagem")
                    .Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Empresa> GetEmpresa()
        {
            var resposta = (from p in Context.Empresas
                            select p).ToList();

            return (resposta);
        }

        public DataTable GetEmpresaGrid()
        {
            var resposta = Context.Empresas.ToList();

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Id", typeof(int));
            tabela.Columns.Add("NomeEmpresa", typeof(string));
            tabela.Columns.Add("CNPJ", typeof(string));
            tabela.Columns.Add("NomeResponsavel", typeof(string));

            foreach (var item in resposta)
            {
                DataRow linha = tabela.NewRow();
                linha["Id"] = item.Id;
                linha["NomeEmpresa"] = item.NomeFantasia;
                linha["CNPJ"] = item.CNPJ;
                linha["NomeResponsavel"] = item.NomeResponsavel;
                tabela.Rows.Add(linha);
            }

            return (tabela);
        }
        public bool Update(Empresa empresa)
        {
            AppDataContext con = new AppDataContext();
            con.Entry(empresa).State = System.Data.Entity.EntityState.Modified;
            con.SaveChanges();
            Context = con;
            return true;
        }

        public bool Delete(Empresa empresa)
        {
            Context.Entry(empresa).State = System.Data.Entity.EntityState.Deleted;
            Context.Empresas.Remove(empresa);
            Context.SaveChanges();
            return true;
        }

        public bool VerificarDependencias(int id)
        {
            var list = Context.Funcionarios.Where(x => x.Empresa.Id == id).ToList();
            if (list.Count > 0)
                return false;
            else
                return true;
        }
    }
}
