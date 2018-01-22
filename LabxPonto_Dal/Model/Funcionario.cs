using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LabxPonto_Dao.Model
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public byte[] Digital{ get; set; }
        public byte[] ImagemDigital { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string LocalTrabalho { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public Funcao Funcao { get; set; }
        public Empresa Empresa { get; set; }
        public Imagem Imagem { get; set; }
        //public ICollection<HorarioExpediente> Horario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataRecisao{ get; set; }
        public string MotivoRecisao { get; set; }
        public string NumeroFolha { get; set; }

        public void Validar()
        {
           
        }
    }
}
