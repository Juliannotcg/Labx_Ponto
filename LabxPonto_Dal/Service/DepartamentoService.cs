using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Service
{
    public class DepartamentoService
    {
        public List<Departamento> GetDepartamento()
        {
            using (AppDataContext Context = new AppDataContext())
            {
                var resposta = (from p in Context.Departamentos
                                select p).ToList();

                return (resposta);
            }
        }
    }
}
