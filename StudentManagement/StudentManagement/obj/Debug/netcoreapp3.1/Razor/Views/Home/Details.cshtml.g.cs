#pragma checksum "P:\work\demo\vs2019\StudentManagement\StudentManagement\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8454436fa5c93cfbafb9b75874d2576c9c779cf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8454436fa5c93cfbafb9b75874d2576c9c779cf8", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagement.Model.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "P:\work\demo\vs2019\StudentManagement\StudentManagement\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<div>");
#nullable restore
#line 7 "P:\work\demo\vs2019\StudentManagement\StudentManagement\Views\Home\Details.cshtml"
Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>");
#nullable restore
#line 8 "P:\work\demo\vs2019\StudentManagement\StudentManagement\Views\Home\Details.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>");
#nullable restore
#line 9 "P:\work\demo\vs2019\StudentManagement\StudentManagement\Views\Home\Details.cshtml"
Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManagement.Model.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
