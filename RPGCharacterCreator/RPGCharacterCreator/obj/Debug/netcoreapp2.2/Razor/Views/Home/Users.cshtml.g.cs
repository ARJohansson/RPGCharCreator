#pragma checksum "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f8735402621ab7178b350f7c06f7323f9f58a01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Users.cshtml", typeof(AspNetCore.Views_Home_Users))]
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
#line 1 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\_ViewImports.cshtml"
using RPGCharacterCreator;

#line default
#line hidden
#line 2 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\_ViewImports.cshtml"
using RPGCharacterCreator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f8735402621ab7178b350f7c06f7323f9f58a01", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a998b5dadced4b0cb34ebc3eae36abc34bf931", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\Users.cshtml"
  
    ViewData["Title"] = "Users";
    Layout = "_Navigation";

#line default
#line hidden
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(93, 55, true);
            WriteLiteral("\r\n<p>Here\'s what we found in the database: </p><br />\r\n");
            EndContext();
#line 10 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\Users.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(172, 11, true);
            WriteLiteral("    <div>\r\n");
            EndContext();
#line 13 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\Users.cshtml"
         foreach (RPGCharacterCreator.Models.User u in Model)
        {
            

#line default
#line hidden
            BeginContext(270, 10, false);
#line 15 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\Users.cshtml"
       Write(u.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(280, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
            BeginContext(302, 6, false);
#line 16 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\Users.cshtml"
       Write(u.Name);

#line default
#line hidden
            EndContext();
            BeginContext(308, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
            BeginContext(330, 7, false);
#line 17 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\Users.cshtml"
       Write(u.Email);

#line default
#line hidden
            EndContext();
            BeginContext(337, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 18 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\Users.cshtml"
        }

#line default
#line hidden
            BeginContext(357, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 20 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\Users.cshtml"
}

#line default
#line hidden
            BeginContext(372, 94, true);
            WriteLiteral("<br />\r\n<p>If you\'re not seeing your friend here, try again: <a href=\"Index\">Go Back</a></p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
