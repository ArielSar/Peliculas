#pragma checksum "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88ee7aec552108e02bf770efdf6c5b32cbb86067"
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
    public partial class PeliculaIndividual : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin-right: 2% ; margin-bottom: 10px;text-align: center;");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 2 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
              urlPelicula

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 3 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
                   Pelicula.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "alt", "Poster");
            __builder.AddAttribute(9, "style", "width: 225px; height:300px");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "style", "max-width: 225px;height:44px;font-size:15px;font-weight:bold");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", 
#nullable restore
#line 5 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
                                                                                      urlPelicula

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.AddContent(17, 
#nullable restore
#line 6 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
     Pelicula.TituloCortado

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddMarkupContent(23, "<a class=\"btn btn-info\">Editar</a>\r\n            ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", " btn-danger");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
                                () => ElimimoPeliParam.InvokeAsync(Pelicula)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                Borrar\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
 

    [Parameter] public Pelicula Pelicula { get; set; }
    [Parameter] public bool MostrarEliminarPelicula { get; set; } = false;
    [Parameter] public EventCallback<Pelicula> ElimimoPeliParam { get; set; }
    private string urlPelicula = string.Empty;
    protected override void OnInitialized()
    {
        urlPelicula = $"Pelicula/";
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
