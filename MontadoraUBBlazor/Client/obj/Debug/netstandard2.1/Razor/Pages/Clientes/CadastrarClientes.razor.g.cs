#pragma checksum "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b4621e6f7fe443390423ea999d7085504b0f1f4"
// <auto-generated/>
#pragma warning disable 1591
namespace MontadoraUBBlazor.Client.Pages.Clientes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\_Imports.razor"
using MontadoraUBBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\_Imports.razor"
using MontadoraUBBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\_Imports.razor"
using MontadoraUBBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clientes/cadastroclientes")]
    public partial class CadastrarClientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cadastrar Clientes</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                  cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                           CadastrarCliente

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<label>Nome</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                 cliente.NomeCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.NomeCliente = __value, cliente.NomeCliente))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.NomeCliente));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateValidationMessage_0(__builder2, 15, 16, 
#nullable restore
#line 10 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                (() => cliente.NomeCliente)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.AddMarkupContent(22, "<label>CPF</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                 cliente.CPFCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.CPFCliente = __value, cliente.CPFCliente))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.CPFCliente));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateValidationMessage_1(__builder2, 28, 29, 
#nullable restore
#line 16 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                (() => cliente.CPFCliente)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n\r\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.AddMarkupContent(35, "<label>Data de Nascimento</label>\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateInputDate_2(__builder2, 36, 37, 
#nullable restore
#line 21 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                 cliente.NascimentoCliente

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.NascimentoCliente = __value, cliente.NascimentoCliente)), 39, () => cliente.NascimentoCliente);
                __builder2.AddMarkupContent(40, "\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateValidationMessage_3(__builder2, 41, 42, 
#nullable restore
#line 22 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                (() => cliente.NascimentoCliente)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.AddMarkupContent(48, "<label>Telefone</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                 cliente.TelefoneCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.TelefoneCliente = __value, cliente.TelefoneCliente))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.TelefoneCliente));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateValidationMessage_4(__builder2, 54, 55, 
#nullable restore
#line 28 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                (() => cliente.TelefoneCliente)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.AddMarkupContent(61, "<label>E-mail</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                 cliente.EmailCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.EmailCliente = __value, cliente.EmailCliente))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.EmailCliente));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateValidationMessage_5(__builder2, 67, 68, 
#nullable restore
#line 34 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                (() => cliente.EmailCliente)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n    ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group");
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.AddMarkupContent(74, "<label>CEP</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(75);
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                 cliente.CEPCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.CEPCliente = __value, cliente.CEPCliente))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.CEPCliente));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateValidationMessage_6(__builder2, 80, 81, 
#nullable restore
#line 40 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                (() => cliente.CEPCliente)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(82, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n\r\n    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "form-group");
                __builder2.AddMarkupContent(86, "\r\n        ");
                __builder2.AddMarkupContent(87, "<label>Rua e numero, apartamento e andar se for o caso</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(88);
                __builder2.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                 cliente.RuaCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.RuaCliente = __value, cliente.RuaCliente))));
                __builder2.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.RuaCliente));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateValidationMessage_7(__builder2, 93, 94, 
#nullable restore
#line 46 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                (() => cliente.RuaCliente)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(95, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\r\n    ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "\r\n        ");
                __builder2.AddMarkupContent(100, "<label>Bairro</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(101);
                __builder2.AddAttribute(102, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                 cliente.BairroCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.BairroCliente = __value, cliente.BairroCliente))));
                __builder2.AddAttribute(104, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.BairroCliente));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateValidationMessage_8(__builder2, 106, 107, 
#nullable restore
#line 52 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                (() => cliente.BairroCliente)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(108, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n\r\n    ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "form-group");
                __builder2.AddMarkupContent(112, "\r\n        ");
                __builder2.AddMarkupContent(113, "<label>Cidade</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(114);
                __builder2.AddAttribute(115, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                 cliente.CidadeCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(116, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.CidadeCliente = __value, cliente.CidadeCliente))));
                __builder2.AddAttribute(117, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.CidadeCliente));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(118, "\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateValidationMessage_9(__builder2, 119, 120, 
#nullable restore
#line 58 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                (() => cliente.CidadeCliente)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(121, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n\r\n    ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "form-group");
                __builder2.AddMarkupContent(125, "\r\n        ");
                __builder2.AddMarkupContent(126, "<label>Estado</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(127);
                __builder2.AddAttribute(128, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                 cliente.EstadoCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(129, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.EstadoCliente = __value, cliente.EstadoCliente))));
                __builder2.AddAttribute(130, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.EstadoCliente));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(131, "\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateValidationMessage_10(__builder2, 132, 133, 
#nullable restore
#line 64 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                (() => cliente.EstadoCliente)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(134, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n\r\n    ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "form-group");
                __builder2.AddMarkupContent(138, "\r\n        ");
                __builder2.AddMarkupContent(139, "<label>Data de Cadastro</label>\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateInputDate_11(__builder2, 140, 141, 
#nullable restore
#line 69 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                 cliente.DataCadastroCliente

#line default
#line hidden
#nullable disable
                , 142, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.DataCadastroCliente = __value, cliente.DataCadastroCliente)), 143, () => cliente.DataCadastroCliente);
                __builder2.AddMarkupContent(144, "\r\n        ");
                __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes.TypeInference.CreateValidationMessage_12(__builder2, 145, 146, 
#nullable restore
#line 70 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                (() => cliente.DataCadastroCliente)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(147, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n\r\n    ");
                __builder2.OpenElement(149, "button");
                __builder2.AddAttribute(150, "type", "submit");
                __builder2.AddAttribute(151, "class", "btn btn-primary");
                __builder2.AddAttribute(152, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
                                                              async () => await CadastrarCliente()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(153, "Cadastrar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\wcwil\Desktop\Blazor\Blazor-Montadora-master\MontadoraBlazor-master\MontadoraUBBlazor\Client\Pages\Clientes\CadastrarClientes.razor"
       
    Cliente cliente = new Cliente();
    async Task CadastrarCliente()
    {
        await http.PostAsJsonAsync("api/cliente", cliente);
        navigation.NavigateTo("clientes");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.MontadoraUBBlazor.Client.Pages.Clientes.CadastrarClientes
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_12<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
