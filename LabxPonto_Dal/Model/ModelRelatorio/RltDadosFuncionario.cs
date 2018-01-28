using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Model.ModelRelatorio
{
    public class RltDadosFuncionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string LocalTrabalha { get; set; }
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public string Departamento { get; set; }
        public string Funcao { get; set; }
    }
}
