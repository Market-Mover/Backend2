// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories/{id}")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Pages\Categories.razor"
           

        [Parameter]
        public string Id { get; set; }

        private Category[] categories;
        private async Task GetCategoriesAsync()
        {
            categories = await Http.GetFromJsonAsync<Category[]>("https://localhost:44311/api/categories");

            StateHasChanged();

            foreach( var item in categories)
            {
                Console.WriteLine(item.ToString());
            }

        }

        protected override async void OnInitialized()
        {
            await GetCategoriesAsync();
        }

       

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
