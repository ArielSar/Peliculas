using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Ayuda
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {

            await js.InvokeVoidAsync("console.log", "Prueba eliminar pelicualas");
            return await js.InvokeAsync<bool>("confirm", mensaje);
        
        }

    }
}
