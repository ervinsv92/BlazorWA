using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWA.Client
{
    public class ServiciosSingleton
    {
        public int Valor { get; set; }
        //Existe una unica instancia en toda la aplicación
    }

    public class ServiciosTransient
    {
        public int Valor { get; set; }
        //Se crea una nueva instancia en cada componente injectado, cada vez que se solicita se crea una nueva instancia
    }
}
