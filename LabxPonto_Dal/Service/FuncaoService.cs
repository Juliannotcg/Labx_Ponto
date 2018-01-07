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
    public class FuncaoService
    { 
        public List<Funcao> GetFuncoes(int depId)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                 var id = (from p in Context.Departamentos
                                 where p.Id == depId
                            select p.Id).ToList();

                var resposta = (from c in Context.Funcoes
                                join b in Context.Departamentos on c.Departamento.Id equals b.Id
                                where c.Id == c.Departamento.Id
                         select c).ToList();

                return (resposta);
            }
        }

        public List<Funcao> GetFuncoes()
        {
            using (AppDataContext Context = new AppDataContext())
            {
                var resposta = (from p in Context.Funcoes
                                select p).ToList();

                return (resposta);
            }
        }

        public Funcao GetFuncao(int id)
        {
            AppDataContext Context = new AppDataContext();
            return Context.Funcoes.Where(x => x.Id == id).FirstOrDefault();
        }
        public DataTable GetFuncaoGrid()
        {
            using (AppDataContext Context = new AppDataContext())
            {
                var results = Context.Funcoes
                    .Include("Departamento")
                    .Select(p => new
                    {
                        p.Id,
                        p.NomeFuncao,
                        p.Descricao,
                        Departamento = p.Departamento.NomeDepartamento,
                    })
                    .AsEnumerable()
                    .ToList();

                DataTable tabela = new DataTable();
                tabela.Columns.Add("Id", typeof(int));
                tabela.Columns.Add("Nome", typeof(string));
                tabela.Columns.Add("Descricao", typeof(string));
                tabela.Columns.Add("Departamento", typeof(string));

                foreach (var item in results)
                {
                    DataRow linha = tabela.NewRow();
                    linha["Id"] = item.Id;
                    linha["Nome"] = item.NomeFuncao;
                    linha["Descricao"] = item.Descricao;
                    linha["Departamento"] = item.Departamento;
                    tabela.Rows.Add(linha);
                }

                return (tabela);
            }

        }

        public bool Insert(Funcao funcao)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Funcoes.Add(funcao);
                Context.SaveChanges();
                return true;
            }
        }

        public bool Delete(Funcao funcao)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Entry(funcao).State = System.Data.Entity.EntityState.Deleted;
                Context.Funcoes.Remove(funcao);
                Context.SaveChanges();
                return true;
            }
        }

        public bool Update(Funcao funcao)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Entry(funcao).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
        }
    }
}
