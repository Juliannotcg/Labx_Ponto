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

        public Departamento GetDepartamento(int id)
        {
            AppDataContext Context = new AppDataContext();
            return Context.Departamentos.Where(x => x.Id == id).FirstOrDefault();
        }

        public bool Insert(Departamento departamento)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Departamentos.Add(departamento);
                Context.SaveChanges();
                return true;
            }
        }

        public bool Delete(Departamento departamento)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Entry(departamento).State = System.Data.Entity.EntityState.Deleted;
                Context.Departamentos.Remove(departamento);
                Context.SaveChanges();
                return true;
            }
        }

        public bool Update(Departamento departamento)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Entry(departamento).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
        }
    }
}
