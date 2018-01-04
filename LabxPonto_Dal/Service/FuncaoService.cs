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
        public List<Funcao> GetFuncao(string depNome)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                 var id = (from p in Context.Departamentos
                                 where p.NomeDepartamento == depNome
                            select p.Id).ToList();

                var resposta = (from c in Context.Funcoes
                                join b in Context.Departamentos on c.Departamento.Id equals b.Id
                                where c.Id == c.Departamento.Id
                         select c).ToList();

                return (resposta);
            }
        }
    }
}
