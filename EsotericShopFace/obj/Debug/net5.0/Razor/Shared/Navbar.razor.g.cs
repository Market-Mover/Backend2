#pragma checksum "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f5059fd10a84e1113e49c6e24785d41c0c79235"
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
    public partial class Navbar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light bg-info shadow");
            __builder.AddAttribute(2, "b-jzjhbdhnzb");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container py-3");
            __builder.AddAttribute(5, "b-jzjhbdhnzb");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
            __builder.AddAttribute(7, "class", "navbar-brand");
            __builder.AddAttribute(8, "href", "");
            __builder.AddAttribute(9, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n\r\n            Esotericshop.org\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, @"<button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbar"" aria-controls=""navbar"" aria-expanded=""false"" aria-label=""Toggle navigation"" b-jzjhbdhnzb><span class=""navbar-toggler-icon"" b-jzjhbdhnzb></span></button>
        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "collapse navbar-collapse justify-content-between");
            __builder.AddAttribute(16, "id", "navbar");
            __builder.AddAttribute(17, "b-jzjhbdhnzb");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "navbar-nav");
            __builder.AddAttribute(20, "b-jzjhbdhnzb");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "");
            __builder.AddAttribute(24, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(26, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "class", "nav-link");
            __builder.AddAttribute(30, "href", "products");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, "Products");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "class", "nav-item dropdown");
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "<a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\" b-jzjhbdhnzb>\r\n                        Categories\r\n                    </a>\r\n                    ");
                __builder2.OpenElement(38, "ul");
                __builder2.AddAttribute(39, "class", "dropdown-menu");
                __builder2.AddAttribute(40, "aria-labelledby", "navbarDropdown");
                __builder2.AddAttribute(41, "b-jzjhbdhnzb");
#nullable restore
#line 19 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
                         if (categories == null)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(42, "<li b-jzjhbdhnzb>Loading...</li>");
#nullable restore
#line 22 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
                             foreach (var category in categories)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(43, "li");
                __builder2.AddAttribute(44, "b-jzjhbdhnzb");
                __builder2.OpenElement(45, "a");
                __builder2.AddAttribute(46, "class", "dropdown-item");
                __builder2.AddAttribute(47, "id");
                __builder2.AddAttribute(48, "href", "categories/" + (
#nullable restore
#line 27 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
                                                                                     category.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "b-jzjhbdhnzb");
                __builder2.AddContent(50, 
#nullable restore
#line 27 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
                                                                                                   category.CategoryName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 28 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
                             

                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(52);
            __builder.AddAttribute(53, "class", "nav-link");
            __builder.AddAttribute(54, "href", "admin");
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(56, "Admin");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.AddMarkupContent(58, "<div class=\"shop-cart\" b-jzjhbdhnzb><i class=\"fas fa-shopping-cart me-2\" b-jzjhbdhnzb></i></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
       
    

    private Category[] categories;

    private async Task GetCategoryAsync()
    {
        categories = await Http.GetFromJsonAsync<Category[]>("https://localhost:44311/api/Categories");
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
         foreach (var item in categories)
        {
            Console.WriteLine(item.CategoryName.ToString());
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\jespe\Desktop\Mission\esotericshop\EsotericShopFace\Shared\Navbar.razor"
         
        StateHasChanged();
    }

    protected override async void OnInitialized()
    {
        await GetCategoryAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591