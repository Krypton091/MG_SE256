#pragma checksum "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd45e9fc46cd4cd267631a71661192bdd8de13af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SE256_RazorFinal_MattG.Pages.Admin.Pages_Admin_ControlPanel), @"mvc.1.0.razor-page", @"/Pages/Admin/ControlPanel.cshtml")]
namespace SE256_RazorFinal_MattG.Pages.Admin
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
#line 1 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\_ViewImports.cshtml"
using SE256_RazorFinal_MattG;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd45e9fc46cd4cd267631a71661192bdd8de13af", @"/Pages/Admin/ControlPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6db32660dbc99677587d47b6fa22a2abfedd745", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_ControlPanel : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/EditSong", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/DeleteSong", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<h1>Control Panel</h1>

<div>
    <table class=""table table-bordered table-sm table-striped"">

        <thead>
            <tr>
                <th>ID</th>
                <th>Song Title</th>
                <th>Song Artist</th>
                <th>Song Playtime</th>
                <th>Song Rating</th>
                <th>Song Release Date</th>
                <th>Song Owned</th>
                <th>Artist Email</th>
                <th>Artist Website</th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 26 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
             if (Model == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"7\" class=\"text-center\">No Model</td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                 foreach (var p in Model.sngs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 37 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                   Write(p.Song_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                   Write(p.Song_Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                   Write(p.Song_Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                   Write(p.Song_PlayTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                   Write(p.Song_Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                   Write(p.Song_Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                   Write(p.Song_Owned);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                   Write(p.Artist_Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                   Write(p.Artist_Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd45e9fc46cd4cd267631a71661192bdd8de13af7936", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                                                        WriteLiteral(p.Song_ID);

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
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd45e9fc46cd4cd267631a71661192bdd8de13af10166", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                                                          WriteLiteral(p.Song_ID);

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
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\Users\krypt\Documents\School\Q5 - Fall 2020\SE256\MG_SE256\SE256_RazorFinal_MattG\Pages\Admin\ControlPanel.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SE256_RazorFinal_MattG.Pages.Admin.ControlPanelModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SE256_RazorFinal_MattG.Pages.Admin.ControlPanelModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SE256_RazorFinal_MattG.Pages.Admin.ControlPanelModel>)PageContext?.ViewData;
        public SE256_RazorFinal_MattG.Pages.Admin.ControlPanelModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
