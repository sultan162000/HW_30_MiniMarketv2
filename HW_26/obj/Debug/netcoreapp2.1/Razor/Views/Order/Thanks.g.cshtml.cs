#pragma checksum "C:\Users\Sultan\source\repos\HW_26\HW_26\Views\Order\Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f7ba70b4c0b08d620a4d640d8a28ac5f826c30f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Thanks), @"mvc.1.0.view", @"/Views/Order/Thanks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Thanks.cshtml", typeof(AspNetCore.Views_Order_Thanks))]
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
#line 1 "C:\Users\Sultan\source\repos\HW_26\HW_26\Views\_ViewImports.cshtml"
using HW_26.Infrastructure;

#line default
#line hidden
#line 2 "C:\Users\Sultan\source\repos\HW_26\HW_26\Views\_ViewImports.cshtml"
using HW_26.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7ba70b4c0b08d620a4d640d8a28ac5f826c30f", @"/Views/Order/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0577c980f217a088f7decac4ee95b96c9b3cdfdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Sultan\source\repos\HW_26\HW_26\Views\Order\Thanks.cshtml"
  
    ViewData["Title"] = "Thanks";

#line default
#line hidden
            BeginContext(56, 81, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h2>Спасибо!</h2>\r\n    <p>Мы доставим ваш заказ в ");
            EndContext();
            BeginContext(138, 14, false);
#line 7 "C:\Users\Sultan\source\repos\HW_26\HW_26\Views\Order\Thanks.cshtml"
                          Write(Model.dateTime);

#line default
#line hidden
            EndContext();
            BeginContext(152, 10, true);
            WriteLiteral(" на Адрес ");
            EndContext();
            BeginContext(163, 13, false);
#line 7 "C:\Users\Sultan\source\repos\HW_26\HW_26\Views\Order\Thanks.cshtml"
                                                   Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(176, 23, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n<div>");
            EndContext();
            BeginContext(200, 48, false);
#line 11 "C:\Users\Sultan\source\repos\HW_26\HW_26\Views\Order\Thanks.cshtml"
Write(Html.ActionLink("На главную", "Index", "Client"));

#line default
#line hidden
            EndContext();
            BeginContext(248, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
