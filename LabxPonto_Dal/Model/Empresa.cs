using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LabxPonto_Dao.Model
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string  NomeResponsavel { get; set; }
        public string CargoResponsavel { get; set; }
        public string EmailResponsavel { get; set; }
        public string Inscricao { get; set; }
        public int NumeroFolha { get; set; }
        public string CEI { get; set; }
        public Address Endereco { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
        public Imagem Imagem { get; set; }
    }
}
