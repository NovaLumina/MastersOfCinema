#pragma checksum "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a856a6c9496c0cdd15ff4c4e8e75985b278c5aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MastersOfCinema.Pages.Directors.Pages_Directors_Details), @"mvc.1.0.razor-page", @"/Pages/Directors/Details.cshtml")]
namespace MastersOfCinema.Pages.Directors
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
#line 1 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\_ViewImports.cshtml"
using MastersOfCinema;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a856a6c9496c0cdd15ff4c4e8e75985b278c5aa", @"/Pages/Directors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10501c82388a791fdbef9c4c203e7a23a82334a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Directors_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("DirectorDetailsDirectorImage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dirDetailsMovieThumbnail brightness"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dirDetailsMovieTitle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./../Movies/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
  
    ViewData["Title"] = Model.Director.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n    <section class=\"dirDetailsMoviesDirectedByName\">\r\n\r\n");
#nullable restore
#line 14 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
         if (Model.Message != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-info\">");
#nullable restore
#line 16 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
                                     Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 17 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <header>\r\n            Films directed by\r\n        </header>\r\n        <header id=\"dirDetailsMoviesDirOnlyName\">\r\n            ");
#nullable restore
#line 22 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
       Write(Model.Director.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </header>\r\n    </section>\r\n\r\n\r\n\r\n        <dl class=\"dirInfo\">\r\n            <dd>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a856a6c9496c0cdd15ff4c4e8e75985b278c5aa6286", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 609, "~/uploads/", 609, 10, true);
#nullable restore
#line 30 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
AddHtmlAttributeValue("", 619, Model.Director.PhotoURL, 619, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 33 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Director.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 36 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
           Write(Html.DisplayFor(model => model.Director.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 39 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Director.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 42 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
           Write(Html.DisplayFor(model => model.Director.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Biography\r\n            </dt>\r\n            <div>\r\n                ");
#nullable restore
#line 48 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
           Write(Html.DisplayFor(model => model.Director.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </dl>\r\n\r\n\r\n        <div id=\"dirMoviesContainer\">\r\n\r\n");
#nullable restore
#line 55 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
             foreach (var item in Model.Director.Movies)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <article class=\"dirMovies\">\r\n                    <figure>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a856a6c9496c0cdd15ff4c4e8e75985b278c5aa10205", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a856a6c9496c0cdd15ff4c4e8e75985b278c5aa10422", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1630, "~/uploads/posters/", 1630, 18, true);
#nullable restore
#line 59 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
AddHtmlAttributeValue("", 1648, item.MoviePosterName, 1648, 21, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
                                                                                         WriteLiteral(item.MovieId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </figure>\r\n\r\n                    <header>\r\n                        <span class=\"dirDetailsMovieTitle\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a856a6c9496c0cdd15ff4c4e8e75985b278c5aa14282", async() => {
#nullable restore
#line 64 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
                                                                                                                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 64 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
                                                                                                                                                              Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
                                                                                             WriteLiteral(item.MovieId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </span>\r\n                    </header>\r\n                </article>\r\n");
#nullable restore
#line 68 "E:\Learning\Programming\ASP.Net Core Projects\MastersOfCinema\MastersOfCinema\Pages\Directors\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MastersOfCinema.Pages.Directors.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MastersOfCinema.Pages.Directors.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MastersOfCinema.Pages.Directors.DetailsModel>)PageContext?.ViewData;
        public MastersOfCinema.Pages.Directors.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
