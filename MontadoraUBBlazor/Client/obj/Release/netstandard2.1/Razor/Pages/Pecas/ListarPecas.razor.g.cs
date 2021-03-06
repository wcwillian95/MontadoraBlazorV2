#pragma checksum "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3ddd9177bc694ad285bce2244befaf556acecb2"
// <auto-generated/>
#pragma warning disable 1591
namespace MontadoraUBBlazor.Client.Pages.Pecas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using MontadoraUBBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\_Imports.razor"
using MontadoraUBBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
using MontadoraUBBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pecas/listapecas")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/pecas/")]
    public partial class ListarPecas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lista de Peças</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n    <a href=\"/pecas/cadastropecas\" class=\"btn btn-primary\">Cadastrar Peças</a>\r\n</div>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 12 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
     if (pecas == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "Carregando...");
#nullable restore
#line 14 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
                                  
    }
    else if (pecas.Count == 0)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "Nenhuma Peça foi cadastrada no banco de dados");
#nullable restore
#line 18 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
                                                                  
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, @"<thead>
                <tr>
                    <th> Id </th>
                    <th> Nome da Peça </th>
                    <th> Valor Unit. por Peça </th>
                    <th> ID Fornecedor da Peça </th>
                    <th> Nome do Fornecedor da Peça </th>
                    <th> Codigo da Peça </th>
                    <th> Valor Total da compra </th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 35 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
                 foreach (var peca in pecas)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                    ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 38 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
                             peca.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 39 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
                             peca.NomePeca

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 40 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
                             peca.ValorUnitPeca

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 41 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
                             peca.IDFornecedorPeca

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 42 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
                             peca.NomeFornecedorPeca

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 43 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
                             peca.CodigoPeca

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 45 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 48 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\paulo\OneDrive\Área de Trabalho\MontadoraUBBlazor\Client\Pages\Pecas\ListarPecas.razor"
       
    List<Peca> pecas;

    protected override async Task OnInitializedAsync()
    {
        await LoadPecas();
    }

    async Task LoadPecas()
    {
        pecas = await http.GetFromJsonAsync<List<Peca>>("api/peca");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
