#pragma checksum "C:\Users\larisa.b.antonica\Desktop\Academy\week5\Cinema\Cinema\Views\Shared\_InfoMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc8145e72e84d963e2e0735aee05bd1e7e5301bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__InfoMovie), @"mvc.1.0.view", @"/Views/Shared/_InfoMovie.cshtml")]
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
#line 1 "C:\Users\larisa.b.antonica\Desktop\Academy\week5\Cinema\Cinema\Views\_ViewImports.cshtml"
using Cinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\larisa.b.antonica\Desktop\Academy\week5\Cinema\Cinema\Views\_ViewImports.cshtml"
using Cinema.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\larisa.b.antonica\Desktop\Academy\week5\Cinema\Cinema\Views\_ViewImports.cshtml"
using Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc8145e72e84d963e2e0735aee05bd1e7e5301bf", @"/Views/Shared/_InfoMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e862f0bf76e9eb1e75eefd2ab2c2fb5cd2bac58d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__InfoMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h3>Movie #");
#nullable restore
#line 2 "C:\Users\larisa.b.antonica\Desktop\Academy\week5\Cinema\Cinema\Views\Shared\_InfoMovie.cshtml"
          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            Name\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 8 "C:\Users\larisa.b.antonica\Desktop\Academy\week5\Cinema\Cinema\Views\Shared\_InfoMovie.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            Length\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 14 "C:\Users\larisa.b.antonica\Desktop\Academy\week5\Cinema\Cinema\Views\Shared\_InfoMovie.cshtml"
       Write(Model.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            type\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 20 "C:\Users\larisa.b.antonica\Desktop\Academy\week5\Cinema\Cinema\Views\Shared\_InfoMovie.cshtml"
       Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n           Release Date\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 26 "C:\Users\larisa.b.antonica\Desktop\Academy\week5\Cinema\Cinema\Views\Shared\_InfoMovie.cshtml"
       Write(Model.ReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591