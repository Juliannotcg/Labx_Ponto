using System;

namespace LabxPonto_Dao.Model
{
    public class HorarioExpediente
    {
        public int Id { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Data{ get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
