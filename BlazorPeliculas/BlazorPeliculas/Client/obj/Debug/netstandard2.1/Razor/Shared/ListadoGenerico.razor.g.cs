#pragma checksum "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b173e5742437e557e331ec1c799bbd9898a353c3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Ayuda;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Repositorios;

#line default
#line hidden
#nullable disable
    public partial class ListadoGenerico<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
 if (Listado == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     if (Cargando == null)
    {

        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Cargando,....");
#nullable restore
#line 8 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                                  

    }
    else
    {

        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 14 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
         Cargando

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 14 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                 

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     
}
else if (Listado.Count == 0)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     if (NoHayRegistros == null)
    {

        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "No hay registros para mostrar,....");
#nullable restore
#line 24 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                                                       

    }
    else
    {

        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 30 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
         NoHayRegistros

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 30 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                       

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     

}
else
{
  
    
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
         foreach (var elemento in Listado)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 41 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
             HayRegistros(elemento)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 41 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                                   ;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
         
    

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
       

    [Parameter] public RenderFragment Cargando { get; set; }
    [Parameter] public RenderFragment NoHayRegistros { get; set; }
    [Parameter] public RenderFragment<TItem> HayRegistros { get; set; }
    [Parameter] public List<TItem> Listado { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
