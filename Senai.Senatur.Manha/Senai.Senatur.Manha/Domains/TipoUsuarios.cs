using System;
using System.Collections.Generic;

namespace Senai.Senatur.Manha.Domains
{
    public partial class TipoUsuarios
    {
        public TipoUsuarios()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int TipoId { get; set; }
        public string TipoUsuario { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
