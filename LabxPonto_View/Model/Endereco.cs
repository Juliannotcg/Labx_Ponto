﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabxPonto_View.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public string EndEndereco { get; set; }
        public string Rua { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
