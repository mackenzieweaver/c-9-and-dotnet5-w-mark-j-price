#pragma checksum "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindMvc\Views\Home\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29b20d13775aa6b42106034397b18b98bb2e1919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetail), @"mvc.1.0.view", @"/Views/Home/ProductDetail.cshtml")]
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
#line 1 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindMvc\Views\_ViewImports.cshtml"
using NorthwindMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindMvc\Views\_ViewImports.cshtml"
using NorthwindMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29b20d13775aa6b42106034397b18b98bb2e1919", @"/Views/Home/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10324db967624bce2cebb2dbfaf1321bdbfb158", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Packt.Shared.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindMvc\Views\Home\ProductDetail.cshtml"
  
    ViewData["Title"] = "Product Detail - " + Model.ProductName;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Product Detail</h2>\r\n<hr />\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>Product ID</dt>\r\n        <dd>");
#nullable restore
#line 10 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindMvc\Views\Home\ProductDetail.cshtml"
       Write(Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Product Name</dt>\r\n        <dd>");
#nullable restore
#line 12 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindMvc\Views\Home\ProductDetail.cshtml"
       Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Category ID</dt>\r\n        <dd>");
#nullable restore
#line 14 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindMvc\Views\Home\ProductDetail.cshtml"
       Write(Model.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Unit Price</dt>\r\n        <dd>");
#nullable restore
#line 16 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindMvc\Views\Home\ProductDetail.cshtml"
       Write(Model.UnitPrice.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Units In Stock</dt>\r\n        <dd>");
#nullable restore
#line 18 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindMvc\Views\Home\ProductDetail.cshtml"
       Write(Model.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Packt.Shared.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
