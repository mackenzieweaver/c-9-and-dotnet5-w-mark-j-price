// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\mackn\Documents\C#\c#9-and-dotnet5-w-mark-j-price\code\PracticalApps\NorthwindBlazorServer\Pages\Customers.razor"
       
    private IEnumerable<Customer> customers;

    protected override async Task OnInitializedAsync()
    {
        customers = await service.GetCustomersAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INorthwindService service { get; set; }
    }
}
#pragma warning restore 1591
