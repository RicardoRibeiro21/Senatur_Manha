using System;
using System.Collections.Generic;

namespace Senai.Senatur.Manha.Domains
{
    public partial class Usuarios
    {
        public int UsuarioId { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int TipoUsuarioId { get; set; }

        public TipoUsuarios TipoUsuario { get; set; }
    }
}
