using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWA.Client.Helpers
{
    public class MostrarMensajes : IMostrarMensajes
    {
        public async Task MostrarMensajeError(string mensaje)
        {
            Console.WriteLine(mensaje);
            await Task.FromResult(0);
        }
    }
}
