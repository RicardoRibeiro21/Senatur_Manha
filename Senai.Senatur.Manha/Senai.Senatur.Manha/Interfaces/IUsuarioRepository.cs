using Senai.Senatur.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.Manha.Interfaces
{
    interface IUsuarioRepository
    {
        void Cadastrar(Usuarios usuario);

        Usuarios BuscarPorEmailSenha(string email, string senha);
        List<Usuarios> listaUsuarios();
    }
}
