#pragma checksum "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "026500ae723071b30e9e5b5398a8aa72e3b79fba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"026500ae723071b30e9e5b5398a8aa72e3b79fba", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3304b5b448a927a5fae1fe42432233a95df5a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abc.Northwind.MvcUI.Models.ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Product Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: Tomato;color:yellow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Abc.Northwind.MvcUI.TagHelpers.PagingTagHelper __Abc_Northwind_MvcUI_TagHelpers_PagingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    .carousel-inner {
        width: 1735px;
        height: 700px;
        padding-left: 0px;
        margin-top: 75px;
        margin-bottom: 10px;
    }

        .carousel-inner img {
            width: 100%;
            height: 100%;
        }

    #yazi {
        margin-bottom: 200px;
        margin-right: 750px;
    }

    #baslik {
        margin-bottom: 50px;
        margin-right: 750px;
      
    }

    #second {
        margin-left: 1000px;
    }

    #third {
        margin-bottom: 30px;
    }

    #thirdtwo {
        margin-bottom: 100px;
    }
    #fourth {
        margin-left:850px;
    }
    #fourthtwo {
        margin-bottom:200px;
        margin-left:850px;
    }
    #fifth {
       
        margin-right: 900px;
    }
    #fifthtwo{
        margin-bottom:150px;
        margin-right:900px;
    }
    #sixthtwo {
        margin-bottom: 150px;
    }
    #seventh{
        margin-bottom:30px;
        margin-left: 700px;
    }
    ");
            WriteLiteral("#seventhtwo{\r\n        margin-bottom:170px;\r\n        margin-left:700px;\r\n    }\r\n</style>\r\n\r\n");
            DefineSection("CaruselSection", async() => {
                WriteLiteral(@"


    <div id=""demo"" class=""carousel slide mt-4"" data-ride=""carousel"">

        <!-- Indicators -->
        <ul class=""carousel-indicators"">
            <li data-target=""#demo"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#demo"" data-slide-to=""1""></li>
            <li data-target=""#demo"" data-slide-to=""2""></li>
            <li data-target=""#demo"" data-slide-to=""3""></li>
            <li data-target=""#demo"" data-slide-to=""4""></li>
            <li data-target=""#demo"" data-slide-to=""5""></li>
            <li data-target=""#demo"" data-slide-to=""6""></li>
        </ul>


        <!-- The slideshow -->
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <img src=""https://previews.123rf.com/images/tbralnina/tbralnina1903/tbralnina190300218/119137303-sources-of-healthy-protein-meat-fish-dairy-products-nuts-legumes-and-grains-.jpg"" alt=""Los Angeles"">
                <div class=""carousel-caption d-none d-md-block"" style=""margin-bot");
                WriteLiteral(@"tom:300px;"">
                    <h1 id=""baslik"" class=""text-info "" style=""font-size:36px"">
                        <strong>
                            Beverages
                        </strong>
                    </h1>
                    <h3 id=""yazi"" class=""text-white "">With Cheap prices <i class=""fa fa-gift"" style=""font-size:36px""></i></h3>
                </div>
            </div>
            <div class=""carousel-item"">
                <img src=""https://www.empire-empire.com/exhibition/wp-content/uploads/2016/07/EMPIRE-MEDIA-Seafood-Expo-Asia-2016-to-Explore-Key-Trends-Driving-Growth-of-the-Industry-in-Asia-1000x518.jpg"" alt=""Chicago"">
                <div class=""carousel-caption d-none d-md-block"" style=""margin-bottom:300px;"">
                    <h1 id=""second"" class=""text-danger ""><strong>Sea Foods</strong></h1>
                    <h3 id=""second"" class=""text-white "">Freash daily sea foods</h3>
                </div>
            </div>
            <div class=""carousel-item"">
      ");
                WriteLiteral(@"          <img src=""https://c8.alamy.com/comp/PPPT7C/composition-of-various-spices-and-condiments-PPPT7C.jpg"" alt=""New York"">
                <div class=""carousel-caption d-none d-md-block"" style=""margin-bottom:300px;"">
                    <h1 id=""third"" class=""text-info ""><strong>Condiments</strong></h1>
                    <h3 id=""thirdtwo"" class=""text-white "">rare kinds with low prices</h3>
                </div>
            </div>
            <div class=""carousel-item"">
                <img src=""https://media.gettyimages.com/photos/variety-of-grains-picture-id1126126003"" alt=""New York"">
                <div class=""carousel-caption d-none d-md-block"" style=""margin-bottom:300px;"">
                    <h1 id=""fourth"" class=""text-danger""><strong>Grains & Cereals </strong></h1>
                    <h3 id=""fourthtwo"" class=""text-danger "">Plenty kind of Grains </h3>
                </div>
            </div>
            <div class=""carousel-item"">
                <img src=""https://previews.123rf.com");
                WriteLiteral(@"/images/yuliaff/yuliaff1803/yuliaff180300548/98255160-assortment-of-various-dairy-products-.jpg"" alt=""New York"">
                <div class=""carousel-caption d-none d-md-block"" style=""margin-bottom:300px;"">
                    <h1 id=""fifth"" class=""text-info ""><strong>Dairy Products</strong></h1>
                    <h3 id=""fifthtwo"" class=""text-white "">Daily delivery </h3>
                </div>
            </div>
            <div class=""carousel-item"">
                <img src=""https://img.freepik.com/free-photo/juicy-steak-rare-beef-with-spices-wooden-board-garnish-asparagus_2829-1513.jpg?size=626&ext=jpg"" alt=""New York"">
                <div class=""carousel-caption d-none d-md-block"" style=""margin-bottom:300px;"">
                    <h1 id=""sixth"" class=""text-info ""><strong>Meat and Poultry </strong></h1>
                    <h3 id=""sixthtwo"" class=""text-white "">Fresh and Cheap</h3>
                </div>
            </div>
            <div class=""carousel-item"">
                <img src=""ht");
                WriteLiteral(@"tps://www.theindianwire.com/wp-content/uploads/2018/06/fresh-colorful-fruits-and-vegetables_free_stock_photos_picjumbo_HNCK7947-2210x1474.jpg"" alt=""New York"">
                <div class=""carousel-caption d-none d-md-block"" style=""margin-bottom:300px;"">
                    <h1 id=""seventh"" class=""text-primary ""><strong>Vegetables</strong></h1>
                    <h3 id=""seventhtwo"" class=""text-primary "">Daily dalivery without extra payment</h3>
                </div>
            </div>

        </div>

        <!-- Left and right controls -->
        <a class=""carousel-control-prev"" href=""#demo"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon""></span>
        </a>
        <a class=""carousel-control-next"" href=""#demo"" data-slide=""next"">
            <span class=""carousel-control-next-icon""></span>
        </a>

    </div>



");
            }
            );
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "026500ae723071b30e9e5b5398a8aa72e3b79fba13299", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "026500ae723071b30e9e5b5398a8aa72e3b79fba13612", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 167 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Key);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "026500ae723071b30e9e5b5398a8aa72e3b79fba15291", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 168 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Key);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<br />\r\n            <input type=\"submit\" value=\"Search a Product \" class=\"btn btn-xs btn-outline-success container-fluid \" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 175 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div style=""margin:10px 10px"" class=""card-deck "">
                <div class=""card"" style=""width: 18rem;"">
                    <img src=""https://www.mutfakgram.com/wp-content/uploads/2019/08/seftali-serbeti-tarifi.jpg"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body"">
                        <h5 class=""card-title"">");
#nullable restore
#line 181 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
                                          Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 182 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
                                        Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> ");
#nullable restore
#line 183 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
                                         Write(product.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "026500ae723071b30e9e5b5398a8aa72e3b79fba20232", async() => {
                WriteLiteral("Add to Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 184 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
                                                                                                                                            WriteLiteral(product.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 188 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("product-list-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "026500ae723071b30e9e5b5398a8aa72e3b79fba23225", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            __Abc_Northwind_MvcUI_TagHelpers_PagingTagHelper = CreateTagHelper<global::Abc.Northwind.MvcUI.TagHelpers.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__Abc_Northwind_MvcUI_TagHelpers_PagingTagHelper);
#nullable restore
#line 192 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
__Abc_Northwind_MvcUI_TagHelpers_PagingTagHelper.CurrentCategory = Model.CurrentCategory;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("current-category", __Abc_Northwind_MvcUI_TagHelpers_PagingTagHelper.CurrentCategory, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 193 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
__Abc_Northwind_MvcUI_TagHelpers_PagingTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __Abc_Northwind_MvcUI_TagHelpers_PagingTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 194 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
__Abc_Northwind_MvcUI_TagHelpers_PagingTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __Abc_Northwind_MvcUI_TagHelpers_PagingTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 195 "C:\Users\Sercan İŞLEREL\Source\Repos\Abc\Abc.Northwind.MvcUI\Views\Product\Index.cshtml"
__Abc_Northwind_MvcUI_TagHelpers_PagingTagHelper.PageSize = Model.PageSize;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __Abc_Northwind_MvcUI_TagHelpers_PagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abc.Northwind.MvcUI.Models.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
