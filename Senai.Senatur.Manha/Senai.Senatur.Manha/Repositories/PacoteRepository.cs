using Senai.Senatur.Manha.Domains;
using Senai.Senatur.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.Manha.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        private readonly string StringConexao = "Data Source=.\\SQLEXPRESS;Initial Catalog=Senai_Senatur_Manha;User ID = sa; Password = 132;";

        public void Alterar(Pacotes pacote)
        {
            using (SenaturContext stx = new SenaturContext())
            {
                stx.Pacotes.Update(pacote);
                stx.SaveChanges();
            }
        }

        public Pacotes BuscarPorId(int id)
        {
           using(SqlConnection con = new SqlConnection(StringConexao))
            {
                Pacotes pacote = new Pacotes();
                string Select = "SELECT * FROM USUARIOS WHERE ID = @ID";
                using(SqlCommand cmd = new SqlCommand(Select, con))
                {
                    cmd.Parameters.AddWithValue("@ID", pacote.PacoteId);
                    con.Open();
                    cmd.ExecuteReader();
                }
                return pacote;
            }
        }

        public void Cadastrar(Pacotes pacote)
        {
            using (SenaturContext stx = new SenaturContext())
            {
                stx.Pacotes.Add(pacote);
                stx.SaveChanges();
            }
        }

        public List<Pacotes> listaPacotes()
        {
            using (SenaturContext stx = new SenaturContext())
            {
                return stx.Pacotes.ToList();                
            }
        }
    }
}
