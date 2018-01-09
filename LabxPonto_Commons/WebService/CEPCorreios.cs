using LabxPonto_Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Commons.WebService
{
    public class CEPCorreios
    {
        private Endereco endereco;

        public Endereco preencheEndereco(string cep)
        {
            endereco = new Endereco();

            var ws = new ServiceCEPCorreios.AtendeClienteClient();
            var resposta = ws.consultaCEP(cep);

            endereco.Logradouro = resposta.end;
            endereco.Bairro = resposta.bairro;
            endereco.Cidade = resposta.cidade;
            endereco.Complemento = resposta.complemento;
            endereco.Estado = resposta.uf;

            return endereco;
        }
    }
}
