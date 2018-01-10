using LabxPonto_Commons.Model;
using LabxPonto_Dao.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Commons.WebService
{
    public class CEPCorreios
    {
    
 
        public Endereco BuscaCep(string cep)
        {
            Endereco endereco = new Endereco();
            string Baseurl = "http://viacep.com.br/ws/" + cep + "/json/";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Baseurl);
            MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            HttpResponseMessage response = client.GetAsync(Baseurl).Result;

            string stringData = response.Content.ReadAsStringAsync().Result;

            var data = JsonConvert.DeserializeObject<ApiEndereco>(stringData);

            endereco.Logradouro = data.Logradouro;
            endereco.Cidade = data.Localidade;
            endereco.Bairro = data.Bairro;
            endereco.Estado = data.Uf;
            endereco.Complemento = data.Complemento;
            
            return endereco;
        }

    }
}
