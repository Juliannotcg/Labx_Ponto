using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Model.ModelRelatorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Service
{
    public class FuncaoService
    {
        private AppDataContext Context;

        public FuncaoService(AppDataContext con)
        {
            Context = con;
        }

        public List<Function> GetFuncoes(int depId)
        {
            var id = (from p in Context.Departamentos
                                where p.Id == depId
                        select p.Id).ToList();

            var resposta = (from c in Context.Funcoes
                            join b in Context.Departamentos on c.Department.Id equals b.Id
                            where c.Department.Id == depId
                        select c).ToList();

            return (resposta);
        }

        public List<Function> GetFuncoes()
        {
            var resposta = (from p in Context.Funcoes
                            select p).ToList();

            return (resposta);
        }

        public Function GetFuncao(int id)
        {
            return Context.Funcoes.Where(x => x.Id == id).FirstOrDefault();
        }
        public DataTable GetFuncaoGrid()
        {
            var results = Context.Funcoes
                .Include("Department")
                .Select(p => new
                {
                    p.Id,
                    p.NameFunction,
                    p.Description,
                    Departamento = p.Department.NameDepartment,
                })
                .AsEnumerable()
                .ToList();

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Id", typeof(int));
            tabela.Columns.Add("Nome", typeof(string));
            tabela.Columns.Add("Descricao", typeof(string));
            tabela.Columns.Add("Department", typeof(string));

            foreach (var item in results)
            {
                DataRow linha = tabela.NewRow();
                linha["Id"] = item.Id;
                linha["Nome"] = item.NomeFuncao;
                linha["Descricao"] = item.Descricao;
                linha["Department"] = item.Departamento;
                tabela.Rows.Add(linha);
            }

            return (tabela);

        }

        public bool Insert(Function funcao)
        {
            Context.Funcoes.Add(funcao);
            Context.SaveChanges();
            return true;
        }

        public bool Delete(Function funcao)
        {
            Context.Entry(funcao).State = System.Data.Entity.EntityState.Deleted;
            Context.Funcoes.Remove(funcao);
            Context.SaveChanges();
            return true;
        }

        public bool Update(Function funcao)
        {
            Context.Entry(funcao).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
            return true;
        }

        public bool VerificarDependencias(int id)
        {
            var list = Context.Funcionarios.Where(x => x.Funcao.Id == id).ToList();
            if (list.Count > 0)
                return false;
            else
                return true;
        }

        public List<RltFuncao> GetRelatorio()
        {
            var results = Context.Funcoes
                .Include("Department")
                .Select(p => new RltFuncao()
                {
                    IdDepartamento = p.Department.Id,
                    NomeFuncao = p.NameFunction,
                    Descricao = p.Description,
                    Departamento = p.Department.NameDepartment
                })
                .AsEnumerable()
                .ToList();

            return (results);
        }
    }
}
