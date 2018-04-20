using System.Collections.Generic;

namespace LabxPonto_Dao.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string NameDepartment { get; set; } 
        public string Description { get; set; }
        public virtual IEnumerable<Function> Function { get; private set; }
    }
}
