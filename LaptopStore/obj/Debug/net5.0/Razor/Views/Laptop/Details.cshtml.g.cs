#pragma checksum "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a24e0801f35b47c7a24efea10678f93de67ff5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Laptop_Details), @"mvc.1.0.view", @"/Views/Laptop/Details.cshtml")]
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
#line 1 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\_ViewImports.cshtml"
using LaptopStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\_ViewImports.cshtml"
using LaptopStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a24e0801f35b47c7a24efea10678f93de67ff5f", @"/Views/Laptop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc67ccf2d9697191f9d71db72c728f27f699edaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Laptop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LaptopStore.Models.Laptop>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""row-fluid"">
                <div style=""width:95%"" id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"" data-interval=""1500"">
                    <ol class=""carousel-indicators"">
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                    </ol>
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
                            <img src=""https://images.unsplash.com/photo-1593642702821-c8da6771f0c6?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8bGFwdG9wc3xlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&w=1000&q=80"" class=""d-block w-100"" alt=""..."">
                        </div>
                     ");
            WriteLiteral(@"   <div class=""carousel-item"">
                            <img src=""https://i.dell.com/is/image/DellContent//content/dam/global-asset-library/Products/Notebooks/Inspiron/15_5510_non-touch/in5510nt_cnb_00055lf110_gy.psd?fmt=pjpg&pscan=auto&scl=1&wid=4426&hei=2820&qlt=100,0&resMode=sharp2&size=4426,2820"" class=""d-block w-100"" alt=""..."">
                        </div>
                        <div class=""carousel-item"">
                            <img src=""https://i.pcmag.com/imagery/roundups/02naaOkVLe7DIiejFUyDPJp-33..1605019187.jpg"" class=""d-block w-100"" alt=""..."">
                        </div>
                    </div>
                    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleIndicato");
            WriteLiteral(@"rs"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
            </div>
        <div class=""col-md-6"">
            <h3>");
#nullable restore
#line 40 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
           Write(Model.ItemTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <br />\r\n            <div class=\"row\">\r\n                <div class=\"col-md-8\">\r\n                    <h5>");
#nullable restore
#line 44 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 style=\"color:green;\">In stock</h5>\r\n");
#nullable restore
#line 46 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
                      
                        Random r = new Random();
                        int num = r.Next(5);
                        DayOfWeek wk = DateTime.Today.AddDays(num).DayOfWeek;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5>Get it by ");
#nullable restore
#line 51 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
                             Write(wk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a24e0801f35b47c7a24efea10678f93de67ff5f8006", async() => {
                WriteLiteral("Buy Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>


            
        </div>
        </div>
    <br />
    <h2>Product Description</h2>
    <table class=""table table-striped"">
        <tbody>
            <tr>
                <th>Model Name</th>
                <td>");
#nullable restore
#line 68 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.ModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Ram</th>\r\n                <td>");
#nullable restore
#line 72 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.RamSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Processor Brand</th>\r\n                <td>");
#nullable restore
#line 76 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.ProcessorBrand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Processor Speed</th>\r\n                <td>");
#nullable restore
#line 80 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.ProcessorSpeed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Processor Type</th>\r\n                <td>");
#nullable restore
#line 84 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.ProcessorType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Storage Type</th>\r\n                <td>");
#nullable restore
#line 88 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.HardDiskType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Storage Size</th>\r\n                <td>");
#nullable restore
#line 92 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.HardDiskSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Display</th>\r\n                <td>");
#nullable restore
#line 96 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.Display);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Color</th>\r\n                <td>");
#nullable restore
#line 100 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Height</th>\r\n                <td>");
#nullable restore
#line 104 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Width</th>\r\n                <td>");
#nullable restore
#line 108 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.Width);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Storage Size</th>\r\n                <td>");
#nullable restore
#line 112 "C:\Users\11033258\source\repos\LaptopStore\LaptopStore\Views\Laptop\Details.cshtml"
               Write(Model.HardDiskSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LaptopStore.Models.Laptop> Html { get; private set; }
    }
}
#pragma warning restore 1591
