#pragma checksum "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79fb060f2876703efe1e245393e1de962b2861f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kings_Team), @"mvc.1.0.view", @"/Views/Kings/Team.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79fb060f2876703efe1e245393e1de962b2861f9", @"/Views/Kings/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df366ca8dedaaefe8a91bc89a70f59d5ef08f757", @"/Views/_ViewImports.cshtml")]
    public class Views_Kings_Team : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NbaProje.Models.Teams>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
  
    ViewData["Title"] = "Team";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<ul class=""nav nav-tabs"">
    <li><a href=""/Kings/KingsInfo"">Team Information</a></li>
    <li><a href=""/Kings/Kings"">Players</a></li>
    <li class=""active""><a href=""/Kings/Team"">Team's Stats</a></li>
</ul>

    <table class=""table table-bordered"">
        <thead>
            <tr>

                <th>
                    ");
#nullable restore
#line 19 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
               Write(Html.DisplayNameFor(model => model.TeamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
               Write(Html.DisplayNameFor(model => model.TeamCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
               Write(Html.DisplayNameFor(model => model.TeamArena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
               Write(Html.DisplayNameFor(model => model.ChCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
               Write(Html.DisplayNameFor(model => model.Win));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
               Write(Html.DisplayNameFor(model => model.Lose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
               Write(Html.DisplayNameFor(model => model.WinLosePercentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
               Write(Html.DisplayNameFor(model => model.PointsPerGame));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
               Write(Html.DisplayNameFor(model => model.OpponentPointsPerGame));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
               Write(Html.DisplayNameFor(model => model.Conference));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                 if (item.TeamsID == 26)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TeamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TeamCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TeamArena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ChCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Win));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Lose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                   Write(Html.DisplayFor(modelItem => item.WinLosePercentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PointsPerGame));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OpponentPointsPerGame));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 88 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Conference));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 92 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Monster\Desktop\Nbagüncel14.4\Nbagüncel14.4\Nbagüncel13.4\Nbagüncel\NbaProje\NbaProje\Views\Kings\Team.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NbaProje.Models.Teams>> Html { get; private set; }
    }
}
#pragma warning restore 1591
