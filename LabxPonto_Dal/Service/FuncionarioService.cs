﻿using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LabxPonto_Dao.Service
{
    public class FuncionarioService
    {
        public Funcionario GetFuncionario(string CPF)
        {
            Funcionario funcionario = new Funcionario();

            using (AppDataContext Context = new AppDataContext())
            {
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
                    funcionario.Funcao.NomeFuncao = a.Funcao.NomeFuncao;
                    funcionario.Endereco.Cidade = a.Endereco.Cidade;
                    funcionario.Endereco.Bairro = a.Endereco.Bairro;
                    funcionario.Endereco.Estado = a.Endereco.Estado;
                    funcionario.Endereco.Numero = a.Endereco.Numero;
                    funcionario.Endereco.Rua = a.Endereco.Rua;
                    funcionario.Endereco.Complemento = a.Endereco.Complemento;
                }
            }
            return (funcionario);
        }

        public List<Funcionario> GetFuncionario()
        {
            using (AppDataContext Context = new AppDataContext())
            {
                var resposta = Context.Funcionarios.Include("Empresa")
                    .Include("Endereco")
                    .Include("Contrato")
                    .Include("Funcao")
                    .Include("Imagem")
                    .ToList();

                return (resposta);
            }
        }

        public DataTable GetFuncionarioGrid()
        {
            using (AppDataContext Context = new AppDataContext())
            {

                

                //var teste= Context.Database.SqlQuery<DataTable>(@"select FunId AS Id,FunNome AS Nome, EmpNomeFantasia AS Empresa, DepNomeDepartamento AS Departamento , FncNome AS Funcao
                //    from FunFuncionario
                //    left join EmpEmpresa ON Fun_EmpId = EmpId
                //    left join FncFuncao ON Fun_FncId = FncId
                //    left join DepDepartamento ON Fnc_DepId = DepId
                //    ").ToList();

                //var tabela = Context.Funcionarios.SqlQuery(@"select FunId AS Id,FunNome AS Nome, EmpNomeFantasia AS Empresa, DepNomeDepartamento AS Departamento , FncNome AS Funcao
                //    from FunFuncionario
                //    left join EmpEmpresa ON Fun_EmpId = EmpId
                //    left join FncFuncao ON Fun_FncId = FncId
                //    left join DepDepartamento ON Fnc_DepId = DepId
                //    ").ToList();

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

        }

        public bool Insert(Funcionario funcionario)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Funcionarios.Add(funcionario);
                Context.SaveChanges();
                return true;
            }
        }

        public bool Delete(Funcionario funcionario)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Entry(funcionario).State = System.Data.Entity.EntityState.Deleted;
                Context.Funcionarios.Remove(funcionario);
                Context.SaveChanges();
                return true;
            }
        }

        public bool Update(Funcionario funcionario)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Entry(funcionario).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
        }
    }
}
