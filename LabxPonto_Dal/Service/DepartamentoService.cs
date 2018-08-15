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
        private AppDataContext Context;

        public DepartamentoService(AppDataContext con)
        {
            Context = con;
        }

        public List<Departamento> GetDepartamento()
        {
            var resposta = (from p in Context.Departamentos
                            select p).ToList();

            return (resposta);
        }

        public Departamento GetDepartamento(int id)
        {
            return Context.Departamentos.Where(x => x.Id == id).FirstOrDefault();
        }

        public bool Insert(Departamento departamento)
        {
            Context.Departamentos.Add(departamento);
            Context.SaveChanges();
            return true;
        }

        public bool Delete(Departamento departamento)
        {
            Context.Entry(departamento).State = System.Data.Entity.EntityState.Deleted;
            Context.Departamentos.Remove(departamento);
            Context.SaveChanges();
            return true;
        }

        public bool Update(Departamento departamento)
        {
            Context.Entry(departamento).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
            return true;
        }

        public bool VerificarDependencias(int id)
        {
            var list = Context.Funcoes.Where(x => x.Departamento.Id == id).ToList();
            if (list.Count > 0)
                return false;
            else
                return true;
        }
    }
}
