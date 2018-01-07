using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Service
{
    public class EmpresaService
    {
        public bool Insert(Empresa empresa)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Empresas.Add(empresa);
                Context.SaveChanges();
                return true;
            }
        }
    }
}
