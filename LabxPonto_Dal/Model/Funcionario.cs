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
        public string Digital{ get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public Contrato Contrato { get; set; }
        public Funcao Funcao { get; set; }
        public Departamento Departamento { get; set; }
        public Empresa Empresa { get; set; }
        public Imagem Imagem { get; set; }
        public ICollection<HorarioExpediente> Horario { get; private set; }
        public void Validar()
        {
           
        }
    }
}
