using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Service
{
    public class FuncaoService
    { 
        public List<Funcao> GetFuncao(Departamento departamento)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                //var resposta = Context.Funcoes.Include(d => d.departamento).OrderByDescending(d => d.);

                 var resposta = (from p in Context.Funcoes
                            where p.Departamento.Id ==  1
                            select p).ToList();

                // .Include(t => t.Cliente)
                //.OrderByDescending(t => t.EP).Take(1).Where(x => x.EP == id)

                return (resposta);
            }
        }
    }
}
