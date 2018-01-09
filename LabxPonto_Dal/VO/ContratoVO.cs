using System;

namespace LabxPonto_Dao.VO
{
    public class ContratoVO
    {
        public int NumeroFolha { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataRecisao { get; set; }
        public string MotivoRecisao { get; set; }
    }
}
