// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWasm.FrontEnd.Pages.Categoria
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Repositorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasmServer.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.Compartilhado.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categoria")]
    public partial class IndexCategoria : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Categoria\IndexCategoria.razor"
       

    List<Categoria> Categorias = new List<Categoria>();



    //Metodo Executado quando a Pagina é carregada
    protected override async Task OnInitializedAsync()
    {
            Categorias = await repositorio.Get();
    }



    private async Task DeletarItem(int Id)
    {
        await repositorio.Delete(Id);
       
        //Solicitando Nova Lista de Categorias para
        //Atualizar a Tela
         Categorias = await repositorio.Get();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository<Categoria> repositorio { get; set; }
    }
}
#pragma warning restore 1591
