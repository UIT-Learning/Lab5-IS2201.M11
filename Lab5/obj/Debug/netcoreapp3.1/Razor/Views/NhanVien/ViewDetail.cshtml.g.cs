#pragma checksum "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\Lab5\Views\NhanVien\ViewDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66e175e970d4e8bf3f030303781df82536baf51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_ViewDetail), @"mvc.1.0.view", @"/Views/NhanVien/ViewDetail.cshtml")]
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
#line 1 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\Lab5\Views\_ViewImports.cshtml"
using Lab5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\Lab5\Views\_ViewImports.cshtml"
using Lab5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66e175e970d4e8bf3f030303781df82536baf51", @"/Views/NhanVien/ViewDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1f0bb63f90e7aede5c5ccf89193d5bb7a933a1", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_ViewDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NV_BTModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/NhanVien/UpdateNV_BT"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f66e175e970d4e8bf3f030303781df82536baf513977", async() => {
                WriteLiteral("\n\n    <label>Mã thiết bị:</label><input type=\"text\" name=\"MaThietBi\"");
                BeginWriteAttribute("value", " value=\"", 138, "\"", 162, 1);
#nullable restore
#line 5 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\Lab5\Views\NhanVien\ViewDetail.cshtml"
WriteAttributeValue("", 146, Model.MaThietBi, 146, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\n    <label>Mã căn hộ:</label><input type=\"text\" name=\"MaCanHo\"");
                BeginWriteAttribute("value", " value=\"", 235, "\"", 257, 1);
#nullable restore
#line 6 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\Lab5\Views\NhanVien\ViewDetail.cshtml"
WriteAttributeValue("", 243, Model.MaCanHo, 243, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\n    <label>Lần sửa:</label><input type=\"number\" name=\"LanThu\"");
                BeginWriteAttribute("value", " value=\"", 329, "\"", 350, 1);
#nullable restore
#line 7 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\Lab5\Views\NhanVien\ViewDetail.cshtml"
WriteAttributeValue("", 337, Model.LanThu, 337, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\n    <label>Ngày sửa:</label><input type=\"datetime\" name=\"NgayBaoTri\"");
                BeginWriteAttribute("value", " value=\"", 429, "\"", 454, 1);
#nullable restore
#line 8 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\Lab5\Views\NhanVien\ViewDetail.cshtml"
WriteAttributeValue("", 437, Model.NgayBaoTri, 437, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\n    <input type=\"submit\" value=\"Update\" name=\"submit\" id=\"Update\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NV_BTModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
