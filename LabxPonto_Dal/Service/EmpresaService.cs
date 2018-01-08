﻿using LabxPonto_Dao.Data.Context;
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

        public Empresa GetEmpresa(int id)
        {
            AppDataContext Context = new AppDataContext();

            return Context.Empresas.Include("Endereco")
                    .Where(x => x.Id == id).FirstOrDefault();
        }

        public DataTable GetEmpresaGrid()
        {
            using (AppDataContext Context = new AppDataContext())
            {
                var resposta = (from p in Context.Empresas
                                select p).ToList();

                DataTable tabela = new DataTable();
                tabela.Columns.Add("Id", typeof(int));
                tabela.Columns.Add("NomeEmpresa", typeof(string));
                tabela.Columns.Add("CNPJ", typeof(string));
                tabela.Columns.Add("NomeResponsavel", typeof(string));

                foreach (var item in resposta)
                {
                    DataRow linha = tabela.NewRow();
                    linha["Id"] = item.Id;
                    linha["NomeEmpresa"] = item.NomeFantasia;
                    linha["CNPJ"] = item.CNPJ;
                    linha["NomeResponsavel"] = item.NomeResponsavel;
                    tabela.Rows.Add(linha);
                }

                return (tabela);
            }
        }
        public bool Update(Empresa empresa)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Entry(empresa).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
        }

        public bool Delete(Empresa empresa)
        {
            using (AppDataContext Context = new AppDataContext())
            {
                Context.Entry(empresa).State = System.Data.Entity.EntityState.Deleted;
                Context.Empresas.Remove(empresa);
                Context.SaveChanges();
                return true;
            }
        }
    }
}
