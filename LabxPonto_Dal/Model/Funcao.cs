namespace LabxPonto_Dao.Model
{
    public class Funcao
    {
        public int Id { get; set; }
        public string NomeFuncao { get; set; }
        public string Descricao { get; set; }
        public Departamento Departamento { get; set; }
    }
}
