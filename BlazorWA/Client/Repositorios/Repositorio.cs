﻿using BlazorWA.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWA.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>(){
            new Pelicula(){ Titulo="Spiderman", Lanzamiento = new DateTime(2019,7,2), Poster="https://m.media-amazon.com/images/M/MV5BOTA5NDYxNTg0OV5BMl5BanBnXkFtZTgwODE5NzU1MTE@._V1_UX182_CR0,0,182,268_AL_.jpg" },
            new Pelicula(){ Titulo="Moana", Lanzamiento=new DateTime(2016,11,23), Poster="https://m.media-amazon.com/images/M/MV5BMjI4MzU5NTExNF5BMl5BanBnXkFtZTgwNzY1MTEwMDI@._V1_UX182_CR0,0,182,268_AL_.jpg"},
            new Pelicula(){ Titulo = "Inception", Lanzamiento= new DateTime(2010,7,26), Poster="https://m.media-amazon.com/images/M/MV5BZGFjOTRiYjgtYjEzMS00ZjQ2LTkzY2YtOGQ0NDI2NTVjOGFmXkEyXkFqcGdeQXVyNDQ5MDYzMTk@._V1_UX182_CR0,0,182,268_AL_.jpg" }
        };
        }
    }
}
