#pragma checksum "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Popular.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f10f3d6bdd121d15ec6651dfb181911f37f286af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Popular), @"mvc.1.0.view", @"/Views/Product/Popular.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10f3d6bdd121d15ec6651dfb181911f37f286af", @"/Views/Product/Popular.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3304b5b448a927a5fae1fe42432233a95df5a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Popular : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abc.Northwind.MvcUI.Models.ProductPopularViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Popular.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .card {\r\n        width: 1735px;\r\n        height: 700px;\r\n    }\r\n\r\n\r\n    .card-img-top {\r\n        width: 100%;\r\n        height: 100%;\r\n    }\r\n\r\n    .row {\r\n        margin-top: 50px;\r\n    }\r\n</style> <div class=\"row\">\r\n");
#nullable restore
#line 22 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Popular.cshtml"
     foreach (var item in Model.Products)
    {




#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-7\" style=\"margin-top:10px;\">\r\n            <h2 class=\"featurette-heading\">");
#nullable restore
#line 28 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Popular.cshtml"
                                      Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"text-muted\">");
#nullable restore
#line 28 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Popular.cshtml"
                                                                                 Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n            <p class=\"lead\">");
#nullable restore
#line 29 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Popular.cshtml"
                       Write(item.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
        </div>
        <div class=""col-md-5"" style=""margin-top:10px;"">
            <img src=""https://as2.ftcdn.net/jpg/00/67/59/93/500_F_67599374_q2UqPO9kpImjN3vemdiSRtv0KHMnrG4Y.jpg"" />
        </div>
");
            WriteLiteral("        <hr class=\"featurette-divider\">\r\n");
#nullable restore
#line 36 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Popular.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abc.Northwind.MvcUI.Models.ProductPopularViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591