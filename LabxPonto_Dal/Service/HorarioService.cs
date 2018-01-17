using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Service
{
    
    public class HorarioService
    {
        private AppDataContext Context;

        public HorarioService(AppDataContext con)
        {
            Context = con;
        }
        public HorarioExpediente GetHorarioXml(DateTime dataIni, DateTime dataFim)
        {
            HorarioExpediente horarioExpediente = new HorarioExpediente();

            var resposta = (from a in Context.HorariosExpediente
                                where a.Data >= dataIni && a.Data <= dataFim
                                select a).ToList();

            foreach (var a in resposta)
            {
                horarioExpediente.Id = a.Id;
                horarioExpediente.Data = a.Data;
                horarioExpediente.Entrada = a.Entrada;
                horarioExpediente.Saida = a.Saida;
                horarioExpediente.Funcionario.Nome = a.Funcionario.Nome;
                horarioExpediente.Funcionario.CPF = a.Funcionario.CPF;
            }

            return (horarioExpediente);
        }



    }
}
