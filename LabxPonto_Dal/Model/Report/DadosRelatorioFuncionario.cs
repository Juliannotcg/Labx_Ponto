using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_Dao.Model.Report
{
    public class DadosRelatorioFuncionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public string LocalTrabalho { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Funcao { get; set; }
        public string Empresa { get; set; }
        public string NumeroFolha { get; set; }
        public string Descricao { get; set; }
        public DateTime InicioTurno { get; set; }
        public DateTime FimTurno { get; set; }
        public DateTime InicioAlmoco { get; set; }
        public DateTime FimAlmoco { get; set; }
        public DateTime Data { get; set; }
    }
}
