using senai.Filmes.WebApi.Domains;
using senai.Filmes.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {

        private string stringConexao = "Data Source=DEV4\\SQLEXPRESS; initial catalog=Filmes_tarde; user Id=sa; pwd=sa@132";

        public List<FilmeDomain> Listar()
        {
            List<FilmeDomain> filmes = new List<FilmeDomain>();

            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT IdFilme, Titulo, IdGenero FROM Filmes";

                connection.Open();

                SqlDataReader rdr;

                using(SqlCommand command = new SqlCommand(querySelectAll, connection ))
                {
                    rdr = command.ExecuteReader();
                    
                    while(rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain
                        {
                            IdFilme = Convert.ToInt32(rdr[0]),
                            Titulo = rdr["Titulo"].ToString(),
                            IdGenero = Convert.ToInt32(rdr[2])
                        };

                        filmes.Add(filme);
                    }
                }
            }

            return filmes;
        }

        public FilmeDomain BuscarPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectId = $"SELECT IdFilme, Titulo, IdGenero FROM Filmes WHERE IdFilme = {id}";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectId, con))
                {
                    rdr = cmd.ExecuteReader();

                    if(rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain()
                        {
                            IdFilme = Convert.ToInt32(rdr["IdFilme"]),
                            Titulo = rdr["Titulo"].ToString(),
                            IdGenero = Convert.ToInt32(rdr["IdGenero"])
                        };

                        return filme;
                    }

                    return null;
                }
            }
        }

        public void Cadastrar(FilmeDomain filme)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = $"INSERT INTO Filmes (Titulo, IdGenero) VALUES ('{filme.Titulo}',{filme.IdGenero})";

                SqlCommand cmd = new SqlCommand(queryInsert, con);

                con.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}
