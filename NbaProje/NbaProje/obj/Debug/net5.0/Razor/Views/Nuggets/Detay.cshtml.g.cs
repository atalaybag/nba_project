#pragma checksum "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4efbcef0e3db65d14a3a298a2a82fd302fcf626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nuggets_Detay), @"mvc.1.0.view", @"/Views/Nuggets/Detay.cshtml")]
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
#line 1 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\_ViewImports.cshtml"
using NbaProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\_ViewImports.cshtml"
using NbaProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4efbcef0e3db65d14a3a298a2a82fd302fcf626", @"/Views/Nuggets/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df366ca8dedaaefe8a91bc89a70f59d5ef08f757", @"/Views/_ViewImports.cshtml")]
    public class Views_Nuggets_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NbaProje.Models.Players>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
  
    ViewData["Title"] = "Detay";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Players Details</h1>\r\n\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n  \r\n");
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.PlayerJerseyNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.PlayerJerseyNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.Games));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.Games));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.GamesStarted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.GamesStarted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.MP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.MP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.FG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.FG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.FGA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.FGA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.FGP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.FGP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.TP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.TP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.TPA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.TPA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.TPP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.TPP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.TwP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.TwP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.TwPA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.TwPA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.TwPP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.TwPP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.eFG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.eFG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 118 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.FT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 121 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.FT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 124 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.FTA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 127 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.FTA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 130 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.FTP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 133 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.FTP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 136 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.ORB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 139 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.ORB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 142 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.DRB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 145 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.DRB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 148 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.TRB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 151 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.TRB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 154 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.AST));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 157 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.AST));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 160 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.STL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 163 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.STL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 166 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.BLK));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 169 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.BLK));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 172 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.TOV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 175 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.TOV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 178 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.PF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 181 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.PF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 184 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.PTS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 187 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Nuggets\Detay.cshtml"
       Write(Html.DisplayFor(model => model.PTS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n    </dl>\r\n</div>\r\n<div>\r\n   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4efbcef0e3db65d14a3a298a2a82fd302fcf62624182", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NbaProje.Models.Players> Html { get; private set; }
    }
}
#pragma warning restore 1591
