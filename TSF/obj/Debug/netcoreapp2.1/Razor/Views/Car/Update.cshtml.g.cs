#pragma checksum "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22fba3b61168185e4a3c886b6ce85fe05f2ebd73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Update), @"mvc.1.0.view", @"/Views/Car/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Car/Update.cshtml", typeof(AspNetCore.Views_Car_Update))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\_ViewImports.cshtml"
using TSF;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22fba3b61168185e4a3c886b6ce85fe05f2ebd73", @"/Views/Car/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"048f51ff9bb030fde3edc835032a6363577dcc52", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Core.Entities.CarEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cancelButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Car", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
 using (Html.BeginForm("UpdateInformation", "Car"))
{
    

#line default
#line hidden
            BeginContext(95, 23, false);
#line 5 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(125, 64, false);
#line 6 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(196, 33, false);
#line 7 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(231, 69, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label>Model:</label>\r\n        ");
            EndContext();
            BeginContext(301, 107, false);
#line 10 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.EditorFor(model => model.Model, Model.Model, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(408, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(419, 83, false);
#line 11 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.ValidationMessageFor(model => model.Model, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(502, 89, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Description:</label>\r\n        ");
            EndContext();
            BeginContext(592, 119, false);
#line 15 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.EditorFor(model => model.Description, Model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(711, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(722, 89, false);
#line 16 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(811, 83, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Brand:</label>\r\n        ");
            EndContext();
            BeginContext(895, 107, false);
#line 20 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.EditorFor(model => model.Brand, Model.Brand, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1013, 83, false);
#line 21 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.ValidationMessageFor(model => model.Brand, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 81, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Año:</label>\r\n        ");
            EndContext();
            BeginContext(1178, 116, false);
#line 25 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.EditorFor(model => model.Year, Model.Year.ToString(), new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1305, 82, false);
#line 26 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.ValidationMessageFor(model => model.Year, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 84, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Precio:</label>\r\n        ");
            EndContext();
            BeginContext(1472, 118, false);
#line 30 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.EditorFor(model => model.Price, Model.Price.ToString(), new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1601, 83, false);
#line 31 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 89, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Kilometraje:</label>\r\n        ");
            EndContext();
            BeginContext(1774, 128, false);
#line 35 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.EditorFor(model => model.Kilometers, Model.Kilometers.ToString(), new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1913, 88, false);
#line 36 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
   Write(Html.ValidationMessageFor(model => model.Kilometers, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 116, true);
            WriteLiteral("\r\n    </div>\r\n    <button id=\"sendData\" type=\"submit\" value=\"Guardar\" class=\"btn btn-primary\">Guardar</button>\r\n    ");
            EndContext();
            BeginContext(2117, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f97cacec85394e93b0850485ee4f9d3c", async() => {
                BeginContext(2200, 8, true);
                WriteLiteral("Cancelar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2212, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\pepti\source\repos\ProjectTSF\TSF\Views\Car\Update.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Core.Entities.CarEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
