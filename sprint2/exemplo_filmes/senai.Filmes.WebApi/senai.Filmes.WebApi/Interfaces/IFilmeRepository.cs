using senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Interfaces
{
    interface IFilmeRepository
    {
        List<FilmeDomain> Listar();
        FilmeDomain BuscarPorId(int id);
        void Cadastrar(FilmeDomain filme);
    }
}
