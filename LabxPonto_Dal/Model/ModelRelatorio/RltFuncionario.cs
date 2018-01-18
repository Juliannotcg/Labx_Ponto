using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Model.ModelRelatorio
{
    public class RltFuncionario
    {
        
            public int IdFuncionario { get; set; }
            public DateTime Entrada { get; set; }
            public DateTime Saida { get; set; }
            public DateTime Data { get; set; }
            public string Funcionario { get; set; }
            public string CPF { get; set; }
        
    }
}
