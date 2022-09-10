#pragma checksum "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77ed9a020d12a3fa84bb1c63273509628b1863f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.WebApp.Pages.GestionPersonas.Pages_GestionPersonas_List), @"mvc.1.0.razor-page", @"/Pages/GestionPersonas/List.cshtml")]
namespace HospiEnCasa.App.WebApp.Pages.GestionPersonas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77ed9a020d12a3fa84bb1c63273509628b1863f3", @"/Pages/GestionPersonas/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"680adc7602337653f8d5451d6e35246a3379051e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GestionPersonas_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\List.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewData["Title"] = "Listado de personas";
    ViewData["script"] = "personaList.js";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container bg-white border border-secondary rounded-25"">
    <div class=""row"">
        <div class=""col-md-2 col-sm-12"">

        </div>
        <div class=""col-md-8 col-sm-12"">
            <br>
            <br>
            <h1>Listado de personas</h1>
            <table class=""table"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Nombre</th>
                        <th>Apellido</th>
                        <th>Número teléfonico</th>
                        <th>Genero</th>
                        <th>Tipo Persona</th>
                        <th>Opciones</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 31 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\List.cshtml"
                     foreach( var persona in Model.listadoPersonas){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\List.cshtml"
                           Write(persona.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\List.cshtml"
                           Write(persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\List.cshtml"
                           Write(persona.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\List.cshtml"
                           Write(persona.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\List.cshtml"
                           Write(persona.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\List.cshtml"
                           Write(persona.Discriminator);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td>
                                <a class=""btn btn-primary table-btn"" id=""actualizar"" >
                                    <i class=""far fa-edit""></i>Editar
                                </a>
                                <a class=""btn btn-default table-btn"" id=""eliminar"" name=""eliminar"">
                                    <i class=""far fa-remove""></i>Eliminar
                                </a>
                            </td>
                        </tr>
");
#nullable restore
#line 48 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
            <br>
            <br>
        </div>
        <div class=""col-md-2 col-sm-12"">

        </div>
    </div>
</div>

<!-- Modal Eliminar -->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modalEliminar"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Eliminación de usuarios</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>¿Desea eliminar la persona?</p>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-primary"">Si</button>
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
      </div>
    </div>
  </div>
</div>

<!-- Modal Actualizar -->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=");
            WriteLiteral(@"""modalEditar"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Actualización de personas</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77ed9a020d12a3fa84bb1c63273509628b1863f310740", async() => {
                WriteLiteral(@"
                        <input type=""hidden"" id=""Id"" name=""Id"">
                        <div class=""form-group"">
                            <label for=""nombre"">Nombres</label>
                            <input type=""text"" class=""form-control"" id=""nombre"" name=""nombre"" placeholder=""Digite sus nombres"" minlength=""3"" maxlength=""50"" >
                        </div>
                        <div class=""form-group"">
                            <label for=""apellido"">Apellidos</label>
                            <input type=""text"" class=""form-control"" id=""apellido"" name=""apellido"" placeholder=""Digite sus apellidos"" minlength=""3"" maxlength=""50"">
                        </div>
                        <div class=""form-group"">
                            <label for=""telefono"">Número de telefono</label>
                            <input type=""number"" class=""form-control"" id=""telefono"" name=""telefono"" placeholder=""Digite su número teléfonico"" min=""3000000000"" max=""3999999999"" step=""1"">
                     ");
                WriteLiteral("   </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"genero\">Genero</label>\r\n                            <select class=\"form-control\" id=\"genero\" name=\"genero\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77ed9a020d12a3fa84bb1c63273509628b1863f312377", async() => {
                    WriteLiteral("Seleccione...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77ed9a020d12a3fa84bb1c63273509628b1863f313727", async() => {
                    WriteLiteral("Femenino");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77ed9a020d12a3fa84bb1c63273509628b1863f314985", async() => {
                    WriteLiteral("Masculino");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        </div>                                                                \r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <br>
                    <br>
                </div>
            </div>
        </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-primary"">Actualizar</button>
        <button type=""reset"" class=""btn btn-secondary"">Limpiar</button>
      </div>
    </div>
  </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.App.WebApp.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.WebApp.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.WebApp.ListModel>)PageContext?.ViewData;
        public HospiEnCasa.App.WebApp.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
