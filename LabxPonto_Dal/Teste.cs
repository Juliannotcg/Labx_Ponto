using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao
{
    public class Teste
    {
        public Funcionario GetFuncionario(string Nome)
        {
            Funcionario funcionario = new Funcionario();

            using (AppDataContext Context = new AppDataContext())
            {
                var resposta = from a in Context.Funcionarios
                               where a.Nome.Contains(Nome)
                               select a;

                foreach (var a in resposta)
                {
                    funcionario.Nome = a.Nome;
                    funcionario.SobreNome = a.SobreNome;
                    funcionario.CPF = a.CPF;
                    funcionario.RG = a.RG;
                    funcionario.NomePai = a.NomePai;
                    funcionario.NomeMae = a.NomeMae;
                    funcionario.Telefone = a.Telefone;
                    funcionario.Funcao.NomeFuncao = a.Funcao.NomeFuncao;
                    funcionario.Departamento.NomeDepartamento = a.Departamento.NomeDepartamento;
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
    }
}
