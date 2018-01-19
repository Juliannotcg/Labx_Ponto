using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Service
{
    
    public class HorarioService
    {
        private AppDataContext Context;
        private HorarioExpediente horario;
        private Funcionario funcionario;

        public HorarioService(AppDataContext con)
        {
            Context = con;
        }
        public bool Insert(HorarioExpediente horario)
        {
            Context.HorariosExpediente.Add(horario);
            Context.SaveChanges();
            return true;
        }


        public DataTable GetHorarioXml(DateTime dataIni, DateTime dataFim)
        {
            horario = new HorarioExpediente();

                var results = Context.HorariosExpediente
               .Where(x => x.Data >= dataIni &&  x.Data <= dataFim)
               .Include("Funcionario")
               .Select(p => new
               {
                   p.Data,
                   p.Entrada,
                   p.Saida,
                   Funcionario = p.Funcionario.Id
               })
               .AsEnumerable()
               .ToList();

                DataTable tabela = new DataTable();
                tabela.Columns.Add("Id", typeof(int));
                tabela.Columns.Add("Data", typeof(DateTime));
                tabela.Columns.Add("Entrada", typeof(DateTime));
                tabela.Columns.Add("Saida", typeof(DateTime));

                foreach (var item in results)
                {
                    DataRow linha = tabela.NewRow();
                    linha["Id"] = item.Funcionario;
                    linha["Data"] = item.Data;
                    linha["Entrada"] = item.Entrada;
                    linha["Saida"] = item.Saida;
                    tabela.Rows.Add(linha);
                }

                return (tabela);
            
        }



    }
}
