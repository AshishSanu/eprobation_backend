#pragma checksum "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57c4b085d738158ab8d008654d631d2188fb7255"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PreSentence_Details), @"mvc.1.0.view", @"/Views/PreSentence/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PreSentence/Details.cshtml", typeof(AspNetCore.Views_PreSentence_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57c4b085d738158ab8d008654d631d2188fb7255", @"/Views/PreSentence/Details.cshtml")]
    public class Views_PreSentence_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAPI.Models.PreSentence>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 134, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>PreSentence</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(214, 46, false);
#line 14 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseNumber));

#line default
#line hidden
            EndContext();
            BeginContext(260, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(324, 42, false);
#line 17 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayFor(model => model.CaseNumber));

#line default
#line hidden
            EndContext();
            BeginContext(366, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(429, 45, false);
#line 20 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CourtName));

#line default
#line hidden
            EndContext();
            BeginContext(474, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(538, 41, false);
#line 23 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayFor(model => model.CourtName));

#line default
#line hidden
            EndContext();
            BeginContext(579, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(642, 50, false);
#line 26 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NameOfOffender));

#line default
#line hidden
            EndContext();
            BeginContext(692, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(756, 46, false);
#line 29 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayFor(model => model.NameOfOffender));

#line default
#line hidden
            EndContext();
            BeginContext(802, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(865, 54, false);
#line 32 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OffenderFatherName));

#line default
#line hidden
            EndContext();
            BeginContext(919, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(983, 50, false);
#line 35 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayFor(model => model.OffenderFatherName));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1096, 43, false);
#line 38 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1203, 39, false);
#line 41 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1305, 42, false);
#line 44 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ActSec));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1411, 38, false);
#line 47 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayFor(model => model.ActSec));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1512, 51, false);
#line 50 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfReceiving));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1627, 47, false);
#line 53 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOfReceiving));

#line default
#line hidden
            EndContext();
            BeginContext(1674, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1737, 48, false);
#line 56 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LetterNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1849, 44, false);
#line 59 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayFor(model => model.LetterNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1956, 49, false);
#line 62 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PoliceStation));

#line default
#line hidden
            EndContext();
            BeginContext(2005, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2069, 45, false);
#line 65 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
       Write(Html.DisplayFor(model => model.PoliceStation));

#line default
#line hidden
            EndContext();
            BeginContext(2114, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2181, "\"", 2207, 1);
#line 70 "D:\Personal\eprobation\WebAPI\Views\PreSentence\Details.cshtml"
WriteAttributeValue("", 2196, Model.PSid, 2196, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2208, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAPI.Models.PreSentence> Html { get; private set; }
    }
}
#pragma warning restore 1591