#pragma checksum "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a16f17ad1be741ae35ef5c884ee883ca29998b3d"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<BlazorPeliculas.Client.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
            __Blazor.BlazorPeliculas.Client.Shared.MainLayout.TypeInference.CreateCascadingValue_0(__builder, 13, 14, 
#nullable restore
#line 13 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\MainLayout.razor"
                                appState

#line default
#line hidden
#nullable disable
            , 15, (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n            \r\n                ");
                __builder2.AddContent(17, 
#nullable restore
#line 15 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(18, "\r\n\r\n            \r\n        ");
            }
            );
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\MainLayout.razor"
      

    AppState appState = new AppState();

    public class AppState
    {
        public string Color { get; set; } = "Yellow";
        public string Size { get; set; } = "18px";
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorPeliculas.Client.Shared.MainLayout
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591