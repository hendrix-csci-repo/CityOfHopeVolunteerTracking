#pragma checksum "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f45f86e36e22a0e25e0db1ce517c7efbc799682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoHO.Pages.Volunteers.Pages_Volunteers_Delete), @"mvc.1.0.razor-page", @"/Pages/Volunteers/Delete.cshtml")]
namespace CoHO.Pages.Volunteers
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
#line 1 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/_ViewImports.cshtml"
using CoHO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/_ViewImports.cshtml"
using CoHO.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f45f86e36e22a0e25e0db1ce517c7efbc799682", @"/Pages/Volunteers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b465d8a6655fc06d310850aeff27ffb7f1e02066", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Volunteers_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Volunteer</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 17 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 20 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 23 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.First));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 26 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.First));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 29 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.Last));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 32 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.Last));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 35 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 38 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 41 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.Home));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 44 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.Home));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 47 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.Cell));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 50 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.Cell));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 53 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 56 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 59 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 62 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 65 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.InActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 68 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.InActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 71 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.CommunityService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 74 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.CommunityService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 77 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.WorkersComp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 80 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.WorkersComp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 83 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volunteer.Admin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 86 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volunteer.Admin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f45f86e36e22a0e25e0db1ce517c7efbc79968212540", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f45f86e36e22a0e25e0db1ce517c7efbc79968212803", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 91 "/Users/ivy/Desktop/web/CityOfHopeVolunteerTracking/Pages/Volunteers/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Volunteer.VolunteerID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f45f86e36e22a0e25e0db1ce517c7efbc79968214584", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoHO.Pages.Volunteers.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoHO.Pages.Volunteers.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoHO.Pages.Volunteers.DeleteModel>)PageContext?.ViewData;
        public CoHO.Pages.Volunteers.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
