using System.Collections.Generic;

namespace LabxPonto_Dao.Model
{
    public class Departamento
    {
        public int Id { get; set; }
        public string NomeDepartamento { get; set; }
        public string Descricao { get; set; }
        public virtual IEnumerable<Funcao> Funcao { get; private set; }
    }
}
