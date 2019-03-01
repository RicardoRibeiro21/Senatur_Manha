using Senai.Senatur.Manha.Domains;
using Senai.Senatur.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.Manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository

    {
            private readonly string StringConexao = "Data Source=.\\SQLEXPRESS;Initial Catalog=Senai_Senatur_Manha;User ID = sa; Password = 132;";
        public Usuarios BuscarPorEmailSenha(string email, string senha)
        {        
                using (SqlConnection con = new SqlConnection(StringConexao))
                {
                    string Select = "SELECT U.UsuarioId, U.Email, U.Senha, U.TipoUsuarioId, T.TipoId, T.Tipo_Usuario FROM USUARIOS U JOIN TIPO_USUARIOS T ON U.TipoUsuarioId = T.TipoId  WHERE U.Email = @EMAIL AND U.Senha = @Senha";
                    using (SqlCommand cmd = new SqlCommand (Select, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Senha", senha);
                        con.Open();
                        SqlDataReader sqr = cmd.ExecuteReader();
                        if (sqr.HasRows)
                        {
                                Usuarios usuario = new Usuarios();
                            while (sqr.Read())
                            {
                            usuario.UsuarioId = Convert.ToInt32(sqr["UsuarioId"]);
                                usuario.Email = sqr["Email"].ToString();
                                usuario.Senha = sqr["Senha"].ToString();
                                usuario.TipoUsuario = new TipoUsuarios()
                                {
                                    TipoId = Convert.ToInt32(sqr["TipoId"]),
                                    TipoUsuario = sqr["Tipo_Usuario"].ToString()
                            };
                            }
                    return usuario;
                        }
                    }
                return null;
                }
        }

        public void Cadastrar(Usuarios usuario)
        {
            using (SenaturContext stx = new SenaturContext())
            {
                stx.Usuarios.Add(usuario);
                stx.SaveChanges();
            }
        }

        public List<Usuarios> listaUsuarios()
        {
            using (SenaturContext stx = new SenaturContext())
            {
                return stx.Usuarios.ToList();               
            }
        }
    }
}
