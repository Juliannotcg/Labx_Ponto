namespace LabxPonto_Dao.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Street { get; set; }
        public string Estate { get; set; }
        public string Pais { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Complement { get; set; }
        public int Number { get; set; }
        public int Cep { get; set; }
    }
}
