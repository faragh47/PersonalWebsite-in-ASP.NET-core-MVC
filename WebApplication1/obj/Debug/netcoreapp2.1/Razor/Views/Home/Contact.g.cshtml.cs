#pragma checksum "E:\MRF Site\MRF Site V1\WebApplication1\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a65726d24834fd37e8dfd08a6b88e06f3f221baa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65726d24834fd37e8dfd08a6b88e06f3f221baa", @"/Views/Home/Contact.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "E:\MRF Site\MRF Site V1\WebApplication1\Views\Home\Contact.cshtml"
  

    Layout = "_Layout";

#line default
#line hidden
            BeginContext(38, 1780, true);
            WriteLiteral(@"
<section class=""site-section badge-dark"" style=""padding-top: 2%;"" id=""section-contact"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-7 mb-5 mb-md-0"">
                <form action="""" class=""site-form"">
                    <h3 class=""mb-5"">Get In Touch</h3>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control px-3 py-4"" placeholder=""Your Name"">
                    </div>
                    <div class=""form-group"">
                        <input type=""email"" class=""form-control px-3 py-4"" placeholder=""Your Email"">
                    </div>
                    <div class=""form-group"">
                        <input type=""email"" class=""form-control px-3 py-4"" placeholder=""Your Phone"">
                    </div>
                    <div class=""form-group mb-5"">
                        <textarea class=""form-control px-3 py-4"" cols=""30"" rows=""10"" placeholder=""Write a Message""></textarea>
               ");
            WriteLiteral(@"     </div>
                    <div class=""form-group"">
                        <input type=""submit"" class=""btn btn-primary  px-4 py-3"" value=""Send Message"">
                    </div>
                </form>
            </div>
            <div class=""col-md-5 pl-md-5"">
                <h3 class=""mb-5"">My Contact Details</h3>
                <ul class=""site-contact-details"">
                    <li>
                        <span class=""text-uppercase"">Email</span> farghadani4747@gmail.com
                    </li>
                    <li>
                        <span class=""text-uppercase"">Phone</span> 09124798930
                    </li>


                </ul>
            </div>
        </div>
    </div>
</section>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
