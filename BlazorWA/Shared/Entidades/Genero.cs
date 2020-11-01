using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorWA.Shared.Entidades
{
    public class Genero
    {
        //Solo por llamarse Id ya se reconoce por llave primaria
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }
        public List<GeneroPelicula> GenerosPelicula { get; set; }
    }
}
