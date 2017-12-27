using LabxPonto_View.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Services
{
    public class CepCorreios
    {
        Endereco endereco = new Endereco();
        public Endereco ConsultaCep(string cep)
        {
            var ws = new CepServiceCorreios.AtendeClienteClient();
            var resposta = ws.consultaCEP(cep);

            endereco.Estado = resposta.uf.ToString();
            endereco.Cidade = resposta.cidade.ToString();
            endereco.Bairro = resposta.bairro.ToString();
            endereco.EndEndereco = resposta.end.ToString();
            endereco.Complemento = resposta.complemento.ToString();

            return (endereco);
        }
    }
}
