#pragma checksum "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_stepForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4a0e6604caf8583629edac6dc320ddb35c7781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GitGud__stepForm), @"mvc.1.0.view", @"/Views/GitGud/_stepForm.cshtml")]
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
#line 1 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\_ViewImports.cshtml"
using gitgudclone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\_ViewImports.cshtml"
using gitgudclone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4a0e6604caf8583629edac6dc320ddb35c7781", @"/Views/GitGud/_stepForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39147a92bf84a37d7c1b4723462c1da589e9a707", @"/Views/_ViewImports.cshtml")]
    public class Views_GitGud__stepForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gitgudclone.Models.StepsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"textColor\" class = \"form-group\">\r\n    ");
#nullable restore
#line 4 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_stepForm.cshtml"
Write(Html.LabelFor(s => s.step));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 5 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_stepForm.cshtml"
Write(Html.TextBoxFor(s => s.step, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 6 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_stepForm.cshtml"
Write(Html.ValidationMessageFor(s => s.step));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div id=\"textColor\" class = \"form-group\">\r\n    ");
#nullable restore
#line 10 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_stepForm.cshtml"
Write(Html.LabelFor(s => s.img));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_stepForm.cshtml"
Write(Html.TextBoxFor(s => s.img, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_stepForm.cshtml"
Write(Html.ValidationMessageFor(s => s.img));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 16 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_stepForm.cshtml"
Write(Html.HiddenFor(s => s.postID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gitgudclone.Models.StepsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
