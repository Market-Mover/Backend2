#pragma checksum "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61611e091f25adf9c9b50aa3027890a3ef72c00c"
// <auto-generated/>
#pragma warning disable 1591
namespace EsotericShopFace.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5 justify-content-center");
            __builder.OpenElement(2, "div");
            __builder.OpenComponent<EsotericShopFace.Shared.ProductList>(3);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
