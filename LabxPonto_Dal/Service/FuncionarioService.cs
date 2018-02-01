using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Model.ModelRelatorio;
using System;
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

        public List<Funcionario> GetFuncionarios()
        {
            return Context.Funcionarios.Include("Empresa").Include("Funcao").Include("Funcao.Departamento").ToList();
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

        public Funcionario GetFuncionarioCPF(string CPF)
        {
            Funcionario funcionario = new Funcionario();
            funcionario = Context.Funcionarios.Include("Empresa").Include("Funcao").Include("Funcao.Departamento").Include("Imagem").Where(x => x.CPF == CPF).FirstOrDefault();
            return (funcionario);
        }

        public bool GetFuncionarioCPFExiste(string CPF)
        {
            Funcionario funcionario = new Funcionario();
            funcionario = Context.Funcionarios.Where(x => x.CPF == CPF).FirstOrDefault();

            if (funcionario != null)
                return true;
            else
                return false;
        }

        public Funcionario GetFuncionarioDigital(byte[] digital)
        {
            Funcionario funcionario = new Funcionario();
            funcionario = Context.Funcionarios.Include("Empresa").Include("Funcao").Include("Funcao.Departamento").Include("Imagem").Where(x => x.Digital == digital).FirstOrDefault();
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
                .ToList().OrderBy(p => p.Nome);

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

        public DataTable GetFuncionarioGridCPF(string CPF)
        {
            var results = Context.Funcionarios
                .Include("Empresa")
                .Include("Funcao")
                .Include("Departamento")
                .Where(x => x.CPF == CPF)
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

        public List<RltFuncionario> GetRelatorio(string CPF, DateTime DataIni, DateTime DataFim)
        {
            var results = Context.HorariosExpediente
                .Include("Funcionario")
                .Where(p => p.Funcionario.CPF == CPF &&
                p.Data >= DataIni &&
                p.Data <= DataFim)
                .Select(p => new RltFuncionario()
                {

                    IdFuncionario = p.Funcionario.Id,
                    Funcionario = p.Funcionario.Nome,
                    CPF = p.Funcionario.CPF,
                    Data = p.Data,
                    Entrada = p.Entrada,
                    Saida = p.Saida
                })
                .AsEnumerable()
                .ToList();

            return (results);
        }

        public List<RltFuncionarioEmpresa> GetRelatorioFuncEmpresa(string CNPJ)
        {
            var results = Context.Funcionarios
                .Include("Empresa")
                .Where(p => p.Empresa.CNPJ == CNPJ)
                .Select(p => new RltFuncionarioEmpresa()
                {
                    IdEmpresa = p.Empresa.Id,
                    CNPJ = p.Empresa.CNPJ,
                    NomeEmpresa = p.Empresa.NomeFantasia,
                    NomeReponsavel = p.Empresa.NomeResponsavel,
                    NomeFuncionario = p.Nome,
                    CPF = p.CPF
                })
                .AsEnumerable()
                .ToList();

            return (results);
        }

        public List<RltDadosFuncionario> GetRelatorioFuncionarioSlecionado(int id)
        {
            var results = Context.Funcionarios
                .Include("Empresa")
                .Include("Departamento")
                .Include("Funcao")
                .Where(p => p.Id == id)
                .Select(p => new RltDadosFuncionario()
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    SobreNome = p.SobreNome,
                    CPF = p.CPF,
                    RG = p.RG,
                    LocalTrabalha = p.LocalTrabalho,
                    NomePai = p.NomePai,
                    NomeMae = p.NomeMae,
                    Telefone = p.Telefone,
                    EstadoCivil = p.EstadoCivil,
                    NomeEmpresa = p.Empresa.NomeFantasia,
                    CNPJ = p.Empresa.CNPJ,
                    Departamento = p.Funcao.Departamento.NomeDepartamento,
                    Funcao = p.Funcao.NomeFuncao,
                })
                .AsEnumerable()
                .ToList();

            return (results);
        }
    }
}
