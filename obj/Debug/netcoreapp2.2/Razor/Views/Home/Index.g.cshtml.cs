#pragma checksum "C:\Users\Sam\Desktop\C#\ChefsDishes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d285b6c3f73b32318a3d5ce77382d600a2bdb32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Sam\Desktop\C#\ChefsDishes\Views\_ViewImports.cshtml"
using ChefsDishes;

#line default
#line hidden
#line 1 "C:\Users\Sam\Desktop\C#\ChefsDishes\Views\Home\Index.cshtml"
using ChefsDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d285b6c3f73b32318a3d5ce77382d600a2bdb32", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4173e1c09328e4989c76d1431c897dfcd73c0666", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 371, true);
            WriteLiteral(@"
<h1>Chefs | <a href=""/dishes"">Dishes</a> <a href=""/new"" class=""btn btn-light"">Add Chef</a></h1>
<h2> Check out our roster of Chefs! </h2>
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Age</th>
            <th scope=""col""># of Dishes</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 15 "C:\Users\Sam\Desktop\C#\ChefsDishes\Views\Home\Index.cshtml"
         foreach (Chef c in @Model)
        {

#line default
#line hidden
            BeginContext(466, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(505, 11, false);
#line 18 "C:\Users\Sam\Desktop\C#\ChefsDishes\Views\Home\Index.cshtml"
               Write(c.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(516, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(518, 10, false);
#line 18 "C:\Users\Sam\Desktop\C#\ChefsDishes\Views\Home\Index.cshtml"
                            Write(c.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(528, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(556, 5, false);
#line 19 "C:\Users\Sam\Desktop\C#\ChefsDishes\Views\Home\Index.cshtml"
               Write(c.Age);

#line default
#line hidden
            EndContext();
            BeginContext(561, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(589, 21, false);
#line 20 "C:\Users\Sam\Desktop\C#\ChefsDishes\Views\Home\Index.cshtml"
               Write(c.CreatedDishes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(610, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 22 "C:\Users\Sam\Desktop\C#\ChefsDishes\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(647, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591
