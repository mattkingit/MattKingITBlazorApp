#pragma checksum "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3992bb94d8d2426d0e4ff1db9813b01b71caf589"
// <auto-generated/>
#pragma warning disable 1591
namespace MKBlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using MKBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using MKBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-wyqkgeiezt");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-wyqkgeiezt");
            __builder.OpenComponent<MKBlazorApp.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-wyqkgeiezt");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content px-4");
            __builder.AddAttribute(13, "b-wyqkgeiezt");
#nullable restore
#line 10 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\Shared\MainLayout.razor"
__builder.AddContent(14, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
