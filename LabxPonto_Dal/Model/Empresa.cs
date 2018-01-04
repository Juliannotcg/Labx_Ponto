using System.Collections.Generic;

namespace LabxPonto_Dao.Model
{
    public class Empresa
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
        public Imagem Imagem { get; set; }
    }
}
