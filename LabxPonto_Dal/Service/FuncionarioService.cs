using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LabxPonto_Dao.Service
{
    public class FuncionarioService
    {
        private AppDataContext Context;

        public FuncionarioService(AppDataContext con)
        {
            Context = con;
        }

        public Funcionario GetFuncionario(string CPF)
        {
            Funcionario funcionario = new Funcionario();

            var resposta = from a in Context.Funcionarios
                            where a.CPF == CPF
                            select a;

            var query = Context.Funcionarios.ToList();

            var querys = Context.Funcoes.ToList();

            foreach (var a in query)
            {
                funcionario.Nome = a.Nome;
                funcionario.SobreNome = a.SobreNome;
                funcionario.CPF = a.CPF;
                funcionario.RG = a.RG;
                funcionario.NomePai = a.NomePai;
                funcionario.NomeMae = a.NomeMae;
                funcionario.Telefone = a.Telefone;
                funcionario.Telefone = a.LocalTrabalho;
                funcionario.Funcao.NomeFuncao = a.Funcao.NomeFuncao;
                funcionario.Endereco.Cidade = a.Endereco.Cidade;
                funcionario.Endereco.Bairro = a.Endereco.Bairro;
                funcionario.Endereco.Estado = a.Endereco.Estado;
                funcionario.Endereco.Numero = a.Endereco.Numero;
                funcionario.Endereco.Rua = a.Endereco.Rua;
                funcionario.Endereco.Complemento = a.Endereco.Complemento;
            }
            return (funcionario);
        }

        public Funcionario GetFuncionario(int id)
        {
            return Context.Funcionarios.Include("Empresa").
                    Include("Endereco")
                    .Include("Funcao")
                    .Include("Funcao.Departamento")
                    .Include("Imagem")
                    
                    .Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Funcionario> GetFuncionario()
        {
            var resposta = Context.Funcionarios.Include("Empresa")
                .Include("Endereco")
                .Include("Contrato")
                .Include("Funcao")
                .Include("Imagem")
                .ToList();

            return (resposta);
        }

        public DataTable GetFuncionarioGrid()
        {

            var results = Context.Funcionarios
                .Include("Empresa")
                .Include("Funcao")
                .Include("Departamento")
                .Select(p => new
                {
                    p.Id,
                    p.Nome,
                    Empresa = p.Empresa.NomeFantasia,
                    Funcao = p.Funcao.NomeFuncao,
                    Departamento = p.Funcao.Departamento.NomeDepartamento
                })
                .AsEnumerable()
                .ToList();

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Id", typeof(int));
            tabela.Columns.Add("Nome", typeof(string));
            tabela.Columns.Add("Empresa", typeof(string));
            tabela.Columns.Add("Funcao", typeof(string));
            tabela.Columns.Add("Departamento", typeof(string));

            foreach (var item in results)
            {
                DataRow linha = tabela.NewRow();
                linha["Id"] = item.Id;
                linha["Nome"] = item.Nome;
                linha["Empresa"] = item.Empresa;
                linha["Funcao"] = item.Funcao;
                linha["Departamento"] = item.Departamento;
                tabela.Rows.Add(linha);
            }
                
            return (tabela);
        }

        public bool Insert(Funcionario funcionario)
        {
            Context.Funcionarios.Add(funcionario);
            Context.SaveChanges();
            return true;
        }

        public bool Delete(Funcionario funcionario)
        {
            Context.Entry(funcionario).State = System.Data.Entity.EntityState.Deleted;
            Context.Funcionarios.Remove(funcionario);
            Context.SaveChanges();
            return true;
        }

        public bool Update(Funcionario funcionario)
        {
            Context.Entry(funcionario).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
            return true;
        }
    }
}
