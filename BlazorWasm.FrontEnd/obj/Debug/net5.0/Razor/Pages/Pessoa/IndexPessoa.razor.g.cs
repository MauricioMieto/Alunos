#pragma checksum "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Pessoa\IndexPessoa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0435384df78f3169716913884f5a44c59a3a817d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasm.FrontEnd.Pages.Pessoa
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pessoa")]
    public partial class IndexPessoa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Alunos</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\"><a class=\"btn btn-info\" href=\"/pessoa/cadastro\">Cadastrar Aluno</a></div>");
#nullable restore
#line 10 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Pessoa\IndexPessoa.razor"
 if (pessoas is not null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.AddMarkupContent(4, "<thead><tr><th></th>\r\n                <th>Nome</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 20 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Pessoa\IndexPessoa.razor"
             foreach (var item in pessoas)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "class", "btn btn-success");
            __builder.AddAttribute(10, "href", "/pessoa/editar/" + (
#nullable restore
#line 24 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Pessoa\IndexPessoa.razor"
                                                                         item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-danger");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Pessoa\IndexPessoa.razor"
                                                                   () => DeletarItem(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Deletar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 27 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Pessoa\IndexPessoa.razor"
                         item.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Pessoa\IndexPessoa.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    <hr>");
#nullable restore
#line 33 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Pessoa\IndexPessoa.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<h5>Carregando...</h5>\r\n    <img src=\"https://media.giphy.com/media/l0He4fJxPCbfqv7Xi/giphy.gif\">");
#nullable restore
#line 38 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Pessoa\IndexPessoa.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Pessoa\IndexPessoa.razor"
       

    List<Pessoa> pessoas = new List<Pessoa>();

    protected override async Task OnInitializedAsync()
    {
        pessoas = await repositoryPessoa.Get();
    }



    private async Task DeletarItem(int Id)
    {
        await repositoryPessoa.Delete(Id);
        pessoas = await repositoryPessoa.Get();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository<Pessoa> repositoryPessoa { get; set; }
    }
}
#pragma warning restore 1591
