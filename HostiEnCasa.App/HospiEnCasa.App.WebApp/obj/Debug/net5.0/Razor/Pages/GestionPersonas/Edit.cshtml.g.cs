#pragma checksum "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfa6e39b7caa095c906cab6019bb2a769f02fefd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.WebApp.Pages.GestionPersonas.Pages_GestionPersonas_Edit), @"mvc.1.0.razor-page", @"/Pages/GestionPersonas/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa6e39b7caa095c906cab6019bb2a769f02fefd", @"/Pages/GestionPersonas/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"680adc7602337653f8d5451d6e35246a3379051e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GestionPersonas_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\Edit.cshtml"
  
    ViewData["Title"] = "Edición de personas";
    var persona = Model.persona;
    var mensaje = ViewData["mensaje"];
    ViewData["mensaje"] = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container bg-white border border-secondary rounded-25"">
    <div class=""row"">
        <div class=""col-md-2 col-12"">
            
        </div>
        <div class=""col-md-8 col-12"">
            <br>
            <br>
            <h1>Actualización de personas</h1>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfa6e39b7caa095c906cab6019bb2a769f02fefd5547", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 564, "\"", 583, 1);
#nullable restore
#line 20 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\Edit.cshtml"
WriteAttributeValue("", 572, persona.Id, 572, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""Id"" name=""Id"">
                <div class=""form-group"">
                    <label for=""nombre"">Nombres</label>
                    <input type=""text"" class=""form-control"" id=""nombre"" name=""nombre"" placeholder=""Digite sus nombres"" minlength=""3"" maxlength=""50""");
                BeginWriteAttribute("value", " value=\"", 851, "\"", 874, 1);
#nullable restore
#line 23 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\Edit.cshtml"
WriteAttributeValue("", 859, persona.Nombre, 859, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" >
                </div>
                <div class=""form-group"">
                    <label for=""apellido"">Apellidos</label>
                    <input type=""text"" class=""form-control"" id=""apellido"" name=""apellido"" placeholder=""Digite sus apellidos"" minlength=""3"" maxlength=""50""");
                BeginWriteAttribute("value", " value=\"", 1159, "\"", 1185, 1);
#nullable restore
#line 27 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\Edit.cshtml"
WriteAttributeValue("", 1167, persona.Apellidos, 1167, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""form-group"">
                    <label for=""telefono"">Número de telefono</label>
                    <input type=""number"" class=""form-control"" id=""telefono"" name=""telefono"" placeholder=""Digite su número teléfonico"" min=""3000000000"" max=""3999999999"" step=""1""");
                BeginWriteAttribute("value", " value=\"", 1501, "\"", 1532, 1);
#nullable restore
#line 31 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\Edit.cshtml"
WriteAttributeValue("", 1509, persona.NumeroTelefono, 1509, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"genero\">Genero</label>\r\n                    <select class=\"form-control\" id=\"genero\" name=\"genero\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfa6e39b7caa095c906cab6019bb2a769f02fefd8725", async() => {
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
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfa6e39b7caa095c906cab6019bb2a769f02fefd10066", async() => {
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
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfa6e39b7caa095c906cab6019bb2a769f02fefd11316", async() => {
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
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Actualizar</button>\r\n                <button type=\"reset\" class=\"btn btn-default\">Limpiar</button>\r\n");
#nullable restore
#line 43 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\Edit.cshtml"
                 if( mensaje != "" ){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"alert alert-danger\" role=\"alert\">\r\n                        ");
#nullable restore
#line 45 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\Edit.cshtml"
                   Write(mensaje);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 47 "C:\Users\zambr\Downloads\ProyectosTemp\VeterinariaMod\HostiEnCasa.App\HospiEnCasa.App.WebApp\Pages\GestionPersonas\Edit.cshtml"
                }                

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
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
            WriteLiteral("\r\n            <br>\r\n            <br>\r\n        </div>\r\n        <div class=\"col-md-2 col-12\">\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.App.WebApp.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.WebApp.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.WebApp.EditModel>)PageContext?.ViewData;
        public HospiEnCasa.App.WebApp.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
