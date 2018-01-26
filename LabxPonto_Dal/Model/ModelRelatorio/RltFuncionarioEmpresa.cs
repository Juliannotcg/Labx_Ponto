using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Model.ModelRelatorio
{
    public class RltFuncionarioEmpresa
    {
        public int IdEmpresa { get; set; }
        public string NomeFuncionario { get; set; }
        public string CPF { get; set; }
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public string NomeReponsavel { get; set; }
    }
}
