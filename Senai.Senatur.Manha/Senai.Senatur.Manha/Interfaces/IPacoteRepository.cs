using Senai.Senatur.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.Manha.Interfaces
{
    interface IPacoteRepository
    {
        List<Pacotes> listaPacotes();
        void Cadastrar(Pacotes pacote);
        void Alterar(Pacotes pacote);
        Pacotes BuscarPorId(int id);
    }
}
