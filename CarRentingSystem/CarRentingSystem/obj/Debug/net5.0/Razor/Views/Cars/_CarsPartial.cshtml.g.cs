#pragma checksum "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a64de0e296b586d17ff4c2b05d362a1c356f9f20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars__CarsPartial), @"mvc.1.0.view", @"/Views/Cars/_CarsPartial.cshtml")]
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
#nullable restore
#line 1 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\_ViewImports.cshtml"
using CarRentingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\_ViewImports.cshtml"
using CarRentingSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\_ViewImports.cshtml"
using CarRentingSystem.Models.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\_ViewImports.cshtml"
using CarRentingSystem.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\_ViewImports.cshtml"
using CarRentingSystem.Models.Dealers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\_ViewImports.cshtml"
using CarRentingSystem.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\_ViewImports.cshtml"
using CarRentingSystem.Services.Cars.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
using CarRentingSystem.Areas.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64de0e296b586d17ff4c2b05d362a1c356f9f20", @"/Views/Cars/_CarsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d200bb615505897874a0a43a4f5614cf621f33d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars__CarsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarServiceModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 6 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
     foreach (var car in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"card md-3\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 249, "\"", 268, 1);
#nullable restore
#line 10 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
WriteAttributeValue("", 255, car.ImageUrl, 255, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 269, "\"", 328, 7);
#nullable restore
#line 10 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
WriteAttributeValue("", 275, car.Brand, 275, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
WriteAttributeValue(" ", 285, car.Model, 286, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 296, "-", 297, 2, true);
#nullable restore
#line 10 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
WriteAttributeValue(" ", 298, car.Year, 299, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 308, "(", 309, 2, true);
#nullable restore
#line 10 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
WriteAttributeValue("", 310, car.CategoryName, 310, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 327, ")", 327, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"card-body text-center\">\r\n                    <h5 class=\"card-title text-center\">");
#nullable restore
#line 12 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
                                                  Write(car.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
                                                            Write(car.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
                                                                       Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 12 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
                                                                                   Write(car.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a64de0e296b586d17ff4c2b05d362a1c356f9f2010829", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
                                                                    WriteLiteral(car.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
                     if (ViewBag.AllowCarEdit == true || User.IsInRole(AdminConstants.AdministratorRoleName))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a64de0e296b586d17ff4c2b05d362a1c356f9f2013756", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
                                                                     WriteLiteral(car.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a64de0e296b586d17ff4c2b05d362a1c356f9f2016302", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
                                                                       WriteLiteral(car.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Cars\_CarsPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarServiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
