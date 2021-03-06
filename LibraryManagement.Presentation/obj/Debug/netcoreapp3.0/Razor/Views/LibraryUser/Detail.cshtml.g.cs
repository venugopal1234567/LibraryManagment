#pragma checksum "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c96b4dace9f134c3e7154223e75b24f52aebf6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LibraryUser_Detail), @"mvc.1.0.view", @"/Views/LibraryUser/Detail.cshtml")]
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
#line 1 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\_ViewImports.cshtml"
using LibraryManagement.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\_ViewImports.cshtml"
using LibraryManagement.Presentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\_ViewImports.cshtml"
using LibraryManagement.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c96b4dace9f134c3e7154223e75b24f52aebf6f", @"/Views/LibraryUser/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42af0a980f0ad1217cab63277287e52f7658786a", @"/Views/_ViewImports.cshtml")]
    public class Views_LibraryUser_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryUserDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReturnRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
  
    var bookList =  @Model.Books.ToList();
    var borrowList = @Model.Borrows.ToList();
    var fineList = @Model.FineList.ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12 grid-margin grid-margin-md-0\">\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 11 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
              if( User.IsInRole("Admin")){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <nav>\r\n                <ol class=\"breadcrumb\">\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c96b4dace9f134c3e7154223e75b24f52aebf6f5666", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c96b4dace9f134c3e7154223e75b24f52aebf6f7080", async() => {
                WriteLiteral("Users List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item active\" area-current=\"page\">User Detail</li>\r\n                </ol>\r\n            </nav>\r\n");
#nullable restore
#line 19 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <br /> <br />
             <div class=""wrap d-flex justify-content-start justify-content-sm-center flex-wrap"">
                <div class=""wrap align-items-center ml-5"">
                    <table class=""table"">
                         <thead class=""thead-light"">
                              <tr>
                               <th scope=""col"">Book Image</th>
                               <th scope=""col"">Book Title</th>
                               <th scope=""col"">Borrow Date</th>
                               <th scope=""col"">Return Date</th>
                               <th scope=""col"">Fine</th>
                               <th scope=""col""> </th>
                             </tr>
                        <thead>
");
#nullable restore
#line 34 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                      if(@Model.Books != null){
                         

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                          for(int i=0; i < Model.Books.Count() ; i++){ 

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <tbody>\r\n                                <tr>\r\n                                     <td> <img alt=\"image\"");
            BeginWriteAttribute("src", " src=\"", 1760, "\"", 1800, 1);
#nullable restore
#line 38 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
WriteAttributeValue("", 1766, Url.Content(bookList[i].ImageUrl), 1766, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"250\" height=\"250\" /></td>\r\n                                     <td>");
#nullable restore
#line 39 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                                    Write(bookList[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                     <td>");
#nullable restore
#line 40 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                                    Write(borrowList[i].BorrowedDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                     <td>");
#nullable restore
#line 41 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                                    Write(borrowList[i].SubmittedDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                                      if(@fineList[i] > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <td><p class=\"text-danger\">");
#nullable restore
#line 43 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                                                           Write(fineList[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 44 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                                     }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                      <td><p class=\"text-success\">");
#nullable restore
#line 45 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                                                             Write(fineList[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 46 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <td> \r\n                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c96b4dace9f134c3e7154223e75b24f52aebf6f13046", async() => {
                WriteLiteral("\r\n                                             Return \r\n                                         ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                                                                                                 WriteLiteral(bookList[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                                                                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                             </tbody>\r\n");
#nullable restore
#line 54 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"

                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\dotnet\LibraryManagement\LibraryManagement.Presentation\Views\LibraryUser\Detail.cshtml"
                          
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                     </table> \r\n                </div>\r\n                 \r\n             </div>\r\n            \r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryUserDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
