#pragma checksum "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50817aa56f6906fe62d19df313aca0820206d33e"
// <auto-generated/>
#pragma warning disable 1591
namespace EsotericShopFace.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using EsotericShopFace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using EsotericShopFace.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using EsotericShopFace.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\_Imports.razor"
using System.Threading;

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
            __builder.AddAttribute(2, "b-42tbvv3vjg");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-42tbvv3vjg");
            __builder.OpenComponent<EsotericShopFace.Shared.Navbar>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-42tbvv3vjg");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-42tbvv3vjg><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-42tbvv3vjg>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-42tbvv3vjg");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
