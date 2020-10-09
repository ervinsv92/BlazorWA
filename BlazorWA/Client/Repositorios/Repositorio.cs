using BlazorWA.Shared.Entidades;
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
            new Pelicula(){ Titulo="<b>Spiderman</b>", Lanzamiento = new DateTime(2019,7,2) },
            new Pelicula(){ Titulo="<i>Moana</i>", Lanzamiento=new DateTime(2016,11,23)},
            new Pelicula(){ Titulo = "Inception", Lanzamiento= new DateTime(2010,7,26) }
        };
        }
    }
}
