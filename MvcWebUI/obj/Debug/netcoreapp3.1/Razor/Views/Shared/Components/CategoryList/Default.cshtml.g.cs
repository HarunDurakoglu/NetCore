#pragma checksum "C:\Users\Harunü\Desktop\newProject\newProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0499d15f75004b450d76dcadb4581a7c5971b86e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
#line 1 "C:\Users\Harunü\Desktop\newProject\newProject\MvcWebUI\Views\_ViewImports.cshtml"
using MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Harunü\Desktop\newProject\newProject\MvcWebUI\Views\_ViewImports.cshtml"
using MvcWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0499d15f75004b450d76dcadb4581a7c5971b86e", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90fbe64bce36a3ccac09ea850cf7cd992ce84ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h2>Categoriler</h2>\r\n\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 7 "C:\Users\Harunü\Desktop\newProject\newProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
     if (true)
    {
        
        var showAll = "list-group-item";
        if (Model.CurrentCategory == 0)
        {
            showAll += " active";
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/product/index\"");
            BeginWriteAttribute("class", " class=\"", 287, "\"", 303, 1);
#nullable restore
#line 16 "C:\Users\Harunü\Desktop\newProject\newProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 295, showAll, 295, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tümünü Göster</a>\r\n");
#nullable restore
#line 17 "C:\Users\Harunü\Desktop\newProject\newProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Harunü\Desktop\newProject\newProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var item in Model.Categories)
    {
        var css = "list-group-item";
        if (item.CategoryId == Model.CurrentCategory)
        {
            css += " active";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 539, "\"", 586, 2);
            WriteAttributeValue("", 546, "/product/index?category=", 546, 24, true);
#nullable restore
#line 25 "C:\Users\Harunü\Desktop\newProject\newProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 570, item.CategoryId, 570, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 587, "\"", 599, 1);
#nullable restore
#line 25 "C:\Users\Harunü\Desktop\newProject\newProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 595, css, 595, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\Harunü\Desktop\newProject\newProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 26 "C:\Users\Harunü\Desktop\newProject\newProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
