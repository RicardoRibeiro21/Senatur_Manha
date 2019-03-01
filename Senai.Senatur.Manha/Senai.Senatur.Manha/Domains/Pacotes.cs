using System;
using System.Collections.Generic;

namespace Senai.Senatur.Manha.Domains
{
    public partial class Pacotes
    {
        public int PacoteId { get; set; }
        public string NomePacote { get; set; }
        public string Descricao { get; set; }
        public DateTime DataIda { get; set; }
        public DateTime DataVolta { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public string NomeCidade { get; set; }
    }
}
