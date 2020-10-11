using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWA.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje) {
            await js.InvokeVoidAsync("console.log", "Console log llamado desde c#");
            return await js.InvokeAsync<bool>("confirm", mensaje);
        }
    }
}
