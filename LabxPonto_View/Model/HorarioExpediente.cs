using System;

namespace LabxPonto_View.Model
{
    public class HorarioExpediente
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime InicioTurno { get; set; }
        public DateTime FimTurno { get; set; }
        public DateTime InicioAlmoco{ get; set; }
        public DateTime FimAlmoco { get; set; }
        public DateTime InicioAbono { get; set; }
        public DateTime FimAbono { get; set; }
        public string JustificativaAbono { get; set; }
        public DateTime Data{ get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
