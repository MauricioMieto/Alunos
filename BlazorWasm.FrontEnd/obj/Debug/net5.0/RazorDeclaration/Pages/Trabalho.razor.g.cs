// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWasm.FrontEnd.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/trabalho")]
    public partial class Trabalho : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 142 "C:\Users\00025852\Desktop\Back\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Trabalho.razor"
                           
	public class Fruta 
	{
		public string Nome {get; set;}
		public double Preco {get; set;}
	}
	List<Fruta> ListaFrutas = new List<Fruta>();
	protected override void OnInitialized()
	{
					Fruta La = new Fruta()
					{Nome = "Laranja", Preco = 1.66};		
					Fruta Ba = new Fruta()
					{Nome = "Banana", Preco = 5.00};
					Fruta Ma = new Fruta()
					{Nome = "Maçã", Preco = 7.89};
					Fruta Mo = new Fruta()
					{Nome = "Morango", Preco = 14.20};
					Fruta Pe = new Fruta()
					{Nome = "Pera", Preco = 8.89};
					ListaFrutas.Add(La);
					ListaFrutas.Add(Ba);
					ListaFrutas.Add(Ma);
					ListaFrutas.Add(Mo);
					ListaFrutas.Add(Pe);
	}
	

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591