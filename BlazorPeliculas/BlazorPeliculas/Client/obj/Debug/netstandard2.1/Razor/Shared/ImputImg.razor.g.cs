#pragma checksum "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da804d8b24c3a885dd67d645354c500ac3b2daab"
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
#nullable restore
#line 1 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class ImputImg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "label");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
            label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "file");
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
                                                          ImageFileSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "accept", ".jpg,.jpeg,.png");
            __builder.AddElementReferenceCapture(11, (__value) => {
#nullable restore
#line 10 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
                                 inputElement = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 15 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
     if (imagenBase64 != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "        ");
            __builder.OpenElement(18, "div");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "style", "margin:10px;");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "src", "data:image/jpeg;base64," + " " + (
#nullable restore
#line 19 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
                                                   imagenBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "style", "width:400px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 22 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
     if (imagenTemporal != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.OpenElement(30, "div");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "style", "margin:10px;");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "img");
            __builder.AddAttribute(36, "src", 
#nullable restore
#line 27 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
                           imagenTemporal

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "style", "width:400px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 30 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Ariel\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ImputImg.razor"
       

    [Parameter] public string label { get; set; }
    [Parameter] public string imagenTemporal { get; set; }
    [Parameter] public EventCallback<string> imagenSeleccionada { get; set; }
    private string imagenBase64;
    ElementReference inputElement;

    async Task ImageFileSelected()
    {

        foreach(var file in await fileReaderService.CreateReference(inputElement).EnumerateFilesAsync())
        {
            using(MemoryStream memoryStream=await file.CreateMemoryStreamAsync(4*1024) )
            {
                var byteImagen = new byte[memoryStream.Length];
                memoryStream.Read(byteImagen, 0, (int)memoryStream.Length);
                imagenBase64 = Convert.ToBase64String(byteImagen);
                await imagenSeleccionada.InvokeAsync(imagenBase64);
                imagenTemporal = null;
                StateHasChanged();

            }

        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
    }
}
#pragma warning restore 1591
