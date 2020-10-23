using BlazorWA.Shared.Entidades;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorWA.Client.Shared.MainLayout;

namespace BlazorWA.Client.Pages
{
    public class CounterBase:ComponentBase
    {
        [Inject] protected ServiciosSingleton Singleton { get; set; }
        [Inject] protected ServiciosTransient Transient { get; set; }
        [Inject] protected IJSRuntime JS { get; set; }

        protected int currentCount = 0;
        static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
            currentCountStatic++;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");
        }

        //Funcion que puede ser llamada desde JS
        [JSInvokable]
        public static Task<int> ObtenerCurrentCount() {
            return Task.FromResult(currentCountStatic);
        }

        protected async Task IncrementCountJS() {
            //Pelicula pelicula = new Pelicula();
            //el segundo parametro es una instancia de la clase donde se encuentra el metodo que vamos a llamar, pelicula tambien serviria como segundo parametro
            //con this hace referencia a la clase actual
            await JS.InvokeVoidAsync("pruebaPuntoNetInstancia", DotNetObjectReference.Create(this));
        }
    }
}
