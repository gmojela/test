#pragma checksum "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\Home\Receipt.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d2d610d0ac4767f545a23604bbacf6a3acf0bb73dd07ceca17f2f38e40028505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Receipt), @"mvc.1.0.view", @"/Views/Home/Receipt.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\_ViewImports.cshtml"
using MAM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\_ViewImports.cshtml"
using MAM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d2d610d0ac4767f545a23604bbacf6a3acf0bb73dd07ceca17f2f38e40028505", @"/Views/Home/Receipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"16cae3f3e0e14cac490154e89558d65cec7e8b84c6fb732fc11484cf8ed849c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Receipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReceiptViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Receipt</h1>

    <h2>Items:</h2>
    <table class=""table"">
        <thead>
            <tr>
                <th>Quantity</th>
                <th>Name</th>
                <th>Price</th>                
                <th>Tax</th>
                <th>Import Duty</th>
                <th>Item Cost</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\Home\Receipt.cshtml"
             foreach (var item in Model.ReceiptItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\Home\Receipt.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\Home\Receipt.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\Home\Receipt.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                   \r\n                    <td>");
#nullable restore
#line 25 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\Home\Receipt.cshtml"
                   Write(item.Tax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\Home\Receipt.cshtml"
                   Write(item.ImportDuty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\Home\Receipt.cshtml"
                   Write(item.ItemCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\Home\Receipt.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <h2>Total Tax: ");
#nullable restore
#line 33 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\Home\Receipt.cshtml"
              Write(Model.TotalTax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2>Total Cost: ");
#nullable restore
#line 34 "C:\Users\gary.mojela\Documents\code\MAM\MAM_MVC2\MAM\Views\Home\Receipt.cshtml"
               Write(Model.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReceiptViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
