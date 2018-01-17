using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Service
{
    
    public class HorarioService
    {
       

        public HorarioService()
        {
           
        }

        public HorarioExpediente GetHorarioXml(DateTime dataIni, DateTime dataFim)
        {
            HorarioExpediente horarioExpediente = new HorarioExpediente();

            using (var context = new AppDataContext())
            {


                var results = context.HorariosExpediente
               .Where(x => x.Data >= dataIni &&  x.Data <= dataFim)
               .Include("Funcionario")
               .Select(p => new
               {
                   p.Id,
                   

               //    p.Id,
               //    p.Nome,
               //    Empresa = p.Empresa.NomeFantasia,
               //    Funcao = p.Funcao.NomeFuncao,
               //    Departamento = p.Funcao.Departamento.NomeDepartamento
               })
               .AsEnumerable()
               .ToList();


                //DataTable tabela = new DataTable();
                //tabela.Columns.Add("Id", typeof(int));
                //tabela.Columns.Add("Nome", typeof(string));
                //tabela.Columns.Add("Empresa", typeof(string));
                //tabela.Columns.Add("Funcao", typeof(string));
                //tabela.Columns.Add("Departamento", typeof(string));

                //foreach (var item in results)
                //{
                //    DataRow linha = tabela.NewRow();
                //    linha["Id"] = item.Id;
                //    linha["Nome"] = item.Nome;
                //    linha["Empresa"] = item.Empresa;
                //    linha["Funcao"] = item.Funcao;
                //    linha["Departamento"] = item.Departamento;
                //    tabela.Rows.Add(linha);
                //}












                var resposta = (from a in context.HorariosExpediente
                                where a.Data >= dataIni && a.Data <= dataFim
                                select a).ToList();

                var query = context.Funcionarios.ToList();

                foreach (var a in resposta)
                {
                    horarioExpediente.Id = a.Id;
                    horarioExpediente.Data = a.Data;
                    horarioExpediente.Entrada = a.Entrada;
                    horarioExpediente.Saida = a.Saida;
                    horarioExpediente.Funcionario.Nome = a.Funcionario.Nome;
                    horarioExpediente.Funcionario.CPF = a.Funcionario.CPF;
                }
            }
            return (horarioExpediente);
        }



    }
}
