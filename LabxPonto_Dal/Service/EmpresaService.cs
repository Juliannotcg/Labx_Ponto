using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable GetEmpresaGrid()
        {
            using (AppDataContext Context = new AppDataContext())
            {
                var resposta = (from p in Context.Empresas
                                select p).ToList();

                DataTable tabela = new DataTable();
                tabela.Columns.Add("NomeEmpresa", typeof(string));
                tabela.Columns.Add("CNPJ", typeof(string));
                tabela.Columns.Add("NomeResponsavel", typeof(string));

                foreach (var item in resposta)
                {
                    DataRow linha = tabela.NewRow();
                    linha["NomeEmpresa"] = item.NomeFantasia;
                    linha["CNPJ"] = item.CNPJ;
                    linha["NomeResponsavel"] = item.NomeResponsavel;
                    tabela.Rows.Add(linha);
                }

                return (tabela);
            }
        }
    }
}
