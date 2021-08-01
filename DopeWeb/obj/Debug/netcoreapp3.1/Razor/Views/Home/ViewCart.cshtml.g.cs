#pragma checksum "C:\Users\nagar\Desktop\My Projects\DopeWeb\DopeWeb\Views\Home\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5506aa162ab27cce0783a7041a7023313b6f921"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewCart), @"mvc.1.0.view", @"/Views/Home/ViewCart.cshtml")]
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
#line 1 "C:\Users\nagar\Desktop\My Projects\DopeWeb\DopeWeb\Views\_ViewImports.cshtml"
using DopeWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nagar\Desktop\My Projects\DopeWeb\DopeWeb\Views\_ViewImports.cshtml"
using DopeWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5506aa162ab27cce0783a7041a7023313b6f921", @"/Views/Home/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57d4721f5c5e26e40548263d93a3ca69f66808de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


    <section id=""pricing"" class=""pricing"">
        <div class=""container"">

            <div class=""section-title"">
                <h2>Order Summary</h2>
            </div>

            <div id=""main"">
                <table class=""table"" >
                    <tr>
                        <th>#</th>
                        <th>Product</th>
                        <th>Quantity</th>
                        <th>Unit Price</th>
                        <th>Price</th>
                        <th>Action</th>
                    </tr>
                    <tbody id=""tableBody"">

                    </tbody>

                </table>

            </div>

        </div>
    </section><!-- End Pricing Section -->


<script>

    $(document).ready(function ()
    {
        $.ajax(
            {
                url: ""/Home/GetCartProducts"",
                method: ""GET"",
                succcess: function (result)
                {
                    $.each(result, function (k, v)
                    {
               ");
            WriteLiteral(@"         var image = v['image'];
                        var name = v['name'];
                        var price = v['price'];
                        var quantity = v['quantity'];
                        var total = parseFloat(price) * parseFloat(quantity);
                        var id = v['id'];

                        var html =`<tr>
                              <td> <img class='imageClass' src='images/${image}'></img></td >
                              <td>${name}</td>
                              <td>${quantity}</td>
                              <td>${price}</td>
                              <td>${total}</td>

                              <td><button class='clearButton' id=${id}>Remove</button></td>
                              </tr >`;

                    })
                }
            })

    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591