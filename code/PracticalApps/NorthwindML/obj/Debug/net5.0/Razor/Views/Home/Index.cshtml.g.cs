#pragma checksum "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "068f9da724be84a1dfe91928a3cfc167ffb9f628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\_ViewImports.cshtml"
using NorthwindML;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\_ViewImports.cshtml"
using NorthwindML.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
using Packt.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"068f9da724be84a1dfe91928a3cfc167ffb9f628", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1573a220c400434c816d2ceb120721593871a165", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateDatasets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TrainModels", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Products - Northwind ML";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"display-3\">");
#nullable restore
#line 6 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
                 Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p class=\"lead\">\r\n<div>See product recommendations in your shopping cart.</div>\r\n<ol>\r\n    <li>First,\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "068f9da724be84a1dfe91928a3cfc167ffb9f6285648", async() => {
                WriteLiteral("\r\n            generate some datasets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(".\r\n    </li>\r\n    <li>Second,\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "068f9da724be84a1dfe91928a3cfc167ffb9f6287082", async() => {
                WriteLiteral("\r\n            train the models");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(".\r\n    </li>\r\n    <li>Third, add some products to your\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "068f9da724be84a1dfe91928a3cfc167ffb9f6288535", async() => {
                WriteLiteral("cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(".\r\n    </li>\r\n</ol>\r\n<div>\r\n");
#nullable restore
#line 23 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
         if (Model.GermanyDatasetExists || Model.UKDatasetExists)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("Datasets for training:");
#nullable restore
#line 25 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
                                               
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
         if (Model.GermanyDatasetExists)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"/Data/germany-dataset.txt\" class=\"btn btn-outline-primary\">Germany</a>\r\n");
#nullable restore
#line 30 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
         if (Model.UKDatasetExists)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"/Data/uk-dataset.txt\" class=\"btn btn-outline-primary\">UK</a>\r\n");
#nullable restore
#line 34 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
         if (Model.USADatasetExists)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("Dataset for testing:");
            WriteLiteral("\r\n        <a href=\"/Data/usa-dataset.txt\" class=\"btn btn-outline-primary\">USA</a>\r\n");
#nullable restore
#line 39 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 41 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
     if (Model.Milliseconds > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n    <div class=\"alert alert-success\">\r\n        It took ");
#nullable restore
#line 45 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
           Write(Model.Milliseconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" milliseconds to train the models.\r\n    </div>\r\n");
#nullable restore
#line 47 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h2>Products</h2>\r\n");
#nullable restore
#line 50 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
 foreach (Category category in Model.Categories)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 52 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
   Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small>");
#nullable restore
#line 52 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
                                 Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h3>\r\n    <table>\r\n        <tbody>\r\n");
#nullable restore
#line 55 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
             foreach (Product product in category.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "068f9da724be84a1dfe91928a3cfc167ffb9f62814536", async() => {
                WriteLiteral("Add to Cart");
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
#line 59 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
                                                                     WriteLiteral(product.ProductID);

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
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
                   Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 66 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 69 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindML\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
