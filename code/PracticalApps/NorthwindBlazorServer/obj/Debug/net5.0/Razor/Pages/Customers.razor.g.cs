#pragma checksum "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d5c2ff8c3c36c413b741d9141e158cc74203525"
// <auto-generated/>
#pragma warning disable 1591
namespace NorthwindBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using NorthwindBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using NorthwindBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using NorthwindBlazorServer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\_Imports.razor"
using Packt.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customers")]
    public partial class Customers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Customers</h1>");
#nullable restore
#line 6 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
 if (customers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>ID</th>\r\n                <th>Company Name</th>\r\n                <th>Address</th>\r\n                <th>Phone</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 23 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
             foreach (var customer in customers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 26 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
                         customer.CustomerID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 27 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
                         customer.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 28 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
                         customer.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "<br>\r\n                        ");
            __builder.AddContent(16, 
#nullable restore
#line 29 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
                         customer.City

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "<br>\r\n                        ");
            __builder.AddContent(18, 
#nullable restore
#line 30 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
                         customer.PostalCode

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "<br>\r\n                        ");
            __builder.AddContent(20, 
#nullable restore
#line 31 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
                         customer.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 32 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
                         customer.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "class", "btn btn-info");
            __builder.AddAttribute(28, "href", "editcustomer/" + (
#nullable restore
#line 34 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
                                                                    customer.CustomerID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "btn btn-danger");
            __builder.AddAttribute(33, "href", "deletecustomer/" + (
#nullable restore
#line 37 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
                                                                        customer.CustomerID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
       
    private IEnumerable<Customer> customers;

    protected override async Task OnInitializedAsync()
    {
        customers = await db.Customers.ToListAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Northwind db { get; set; }
    }
}
#pragma warning restore 1591
