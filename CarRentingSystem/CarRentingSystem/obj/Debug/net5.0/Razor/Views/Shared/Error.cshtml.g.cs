#pragma checksum "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fd1c2e3ee710d6c41f935d4b19e71552b454c0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
using CarRentingSystem.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\_ViewImports.cshtml"
using CarRentingSystem.Services.Cars.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd1c2e3ee710d6c41f935d4b19e71552b454c0f", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9769abba29b5623595396aac0855b9f5590e098f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\SoftUni\C# Web\ASP.NET Core\ASP.NET-Core-Project-Car-Renting-System\CarRentingSystem\CarRentingSystem\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Ooooops! Error...</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request. Please contact the web site support.</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
