#pragma checksum "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\ProjectBaiThi\Views\NhanVien\ListSelectedOfNhanVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0824bb37fcce53ad5cc6c8359c11a48f34c2131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_ListSelectedOfNhanVien), @"mvc.1.0.view", @"/Views/NhanVien/ListSelectedOfNhanVien.cshtml")]
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
#line 1 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\ProjectBaiThi\Views\_ViewImports.cshtml"
using Lab5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\ProjectBaiThi\Views\_ViewImports.cshtml"
using Lab5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0824bb37fcce53ad5cc6c8359c11a48f34c2131", @"/Views/NhanVien/ListSelectedOfNhanVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1f0bb63f90e7aede5c5ccf89193d5bb7a933a1", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_ListSelectedOfNhanVien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NV_BTModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2>Danh sách thiết bị của nhân viên được chọn sửa</h2>
<table border=""1"">
    <thead font-weight=""bold"">
        <tr>
            <th>Mã thiết bị</th>
            <th>Mã căn hộ</th>
            <th>Lần thứ</th>
            <th>Ngày bảo trì</th>
            <th>Chức năng</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\ProjectBaiThi\Views\NhanVien\ListSelectedOfNhanVien.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td name=\"MaThietBi\">");
#nullable restore
#line 17 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\ProjectBaiThi\Views\NhanVien\ListSelectedOfNhanVien.cshtml"
                                Write(item.MaThietBi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td name=\"MaCanHo\">");
#nullable restore
#line 18 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\ProjectBaiThi\Views\NhanVien\ListSelectedOfNhanVien.cshtml"
                              Write(item.MaCanHo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td name=\"LanThu\">");
#nullable restore
#line 19 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\ProjectBaiThi\Views\NhanVien\ListSelectedOfNhanVien.cshtml"
                             Write(item.LanThu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td name=\"NgayBaoTri\">");
#nullable restore
#line 20 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\ProjectBaiThi\Views\NhanVien\ListSelectedOfNhanVien.cshtml"
                                 Write(item.NgayBaoTri);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
#nullable restore
#line 22 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\ProjectBaiThi\Views\NhanVien\ListSelectedOfNhanVien.cshtml"
               Write(Html.ActionLink(
                            "Delete",
                            "Delete",
                            "NhanVien",
                            new{manhanvien = @item.MaNhanVien,
                                mathietbi = @item.MaThietBi,
                                macanho = @item.MaCanHo,
                                lanthu = @item.LanThu
                            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 31 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\ProjectBaiThi\Views\NhanVien\ListSelectedOfNhanVien.cshtml"
               Write(Html.ActionLink(
                            "View",
                            "ViewDetail",
                            "NhanVien",
                            new{manhanvien = @item.MaNhanVien,
                                mathietbi = @item.MaThietBi,
                                macanho = @item.MaCanHo,
                                lanthu = @item.LanThu
                            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 42 "C:\Users\fpt\Downloads\BTThucHanh5-master (1)\BTThucHanh5-master\ProjectBaiThi\Views\NhanVien\ListSelectedOfNhanVien.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NV_BTModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
