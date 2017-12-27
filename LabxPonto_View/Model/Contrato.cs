using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_View.Model
{
    public class Contrato
    {
        public int Id { get; set; }
        public int NumeroFolha { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataRecisao { get; set; }
        public string MotivoRecisao { get; set; }
    }
}
