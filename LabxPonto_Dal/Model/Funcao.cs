namespace LabxPonto_Dao.Model
{
    public class Function
    {
        public int Id { get; set; }
        public string NameFunction { get; set; }
        public string Description { get; set; }
        public Department Department { get; set; }
    }
}
