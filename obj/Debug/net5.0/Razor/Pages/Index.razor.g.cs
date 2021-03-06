#pragma checksum "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06604f3d2ec2fb25023168df73258428f08b6616"
// <auto-generated/>
#pragma warning disable 1591
namespace MKBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using MKBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\matthew.l.king\Source\Repos\mattkingit\MattKingITBlazorApp\_Imports.razor"
using MKBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<header><div class=\"banner\"><h1>Matthew King</h1>\r\n        <figure><img src=\"img/meCBCat.jpg\" height=\"100\" width=\"100\" alt=\"Me in my Cincinnati Bearcat ballcap\" class=\"center\">\r\n            <figcaption>Me</figcaption></figure>\r\n        <h3 id=\"quote\">\"Be Excellent to Each Other and ... Party on Dudes! - \"Bill and Ted\'s Excellent Adventures</h3></div>\r\n    <div id=\"early\"><p>\r\n            My name is Matt King and I\'ve been involved with computers and programming since the summer of 1984. Prior to my 8th grade\r\n            when I went to Cincinnati with my cousins to Computer Camp at\r\n            <a href=\"http://www.msj.edu/\">Mount St. Joseph University</a>. My first Program was in BASIC on an Atari Computer and on a 5\r\n            <sup>1/4</sup> inch floppy disk.\r\n        </p>\r\n        <figure><img src=\"http://oldcomputers.net/pics/atari800-810-820.jpg\" width=\"150\" height=\"100\" alt=\"Atari 800 Computer\">\r\n            <figcaption>Atari 800 Computer courtesy of oldcomoputers.net</figcaption></figure>\r\n        <figure><img src=\"img/floppy5.jpg\" height=\"100\" alt=\"5 <sup>1/4</sup> inch floppy\">\r\n            <figcaption>5\r\n                <sup>1/4</sup> inch floppy disk</figcaption></figure></div>\r\n    <div id=\"earlyEmployment\"><p>\r\n            Since then I\'ve worked with computers primarily in the\r\n            <a href=\"http://www.navy.mil\">US Navy</a> as an\r\n            <a href=\"https://www.navycs.com/navy-jobs/operations-specialist.html\">Operations Specialist</a> (OS) and at the\r\n            <a href=\"http://www.tampagov.net\">City of Tampa</a> as an Applications Systems Analyst and Senior Programmer Analyst. In between I\'ve worked doing\r\n            several jobs as a developer/programmer at\r\n            <a href=\"http://www.ersgroup.com/\">Economic Research Services (ERS Group)</a>,\r\n            <a href=\"https://www.akingump.com/en/index.html\">Akin Gump Strauss Hauer and Feld LLP</a> and\r\n            <a href=\"https://www.usaajobs.com/\">United States Automobile Association (USAA)</a>. I am currently working for Tenax Technologies as a contractor \r\n            for the US Army at Fort Campbell, KY as a Systems Programmer.\r\n        </p></div>\r\n    <div id=\"earlyEducation\"><p>\r\n            I majored in Computer Science, Computer Programming, Databases and Information Technology at several schools including\r\n            <a href=\"http://xavier.edu\">Xavier University</a> (Pascal),\r\n            <a href=\"http://uc.edu\">University of Cincinnati</a> (C++, Mathematica, Fortran, LISP, Prolog),\r\n            <a href=\"http://utsa.edu\">University of Texas at San Antonio</a> (C, Java),\r\n            <a href=\"http://alamo.edu/sac\">San Antonio College</a> (Visual Basic, Unix scripting),\r\n            <a href=\"http://www.tcc.fl.edu\">Tallahassee Community College</a> (Visual Basic, Java),\r\n            <a href=\"http://www.hccfl.edu\">Hillsborough Community College </a>(Web Development, Perl, PHP, mySQL) and\r\n            <a href=\"http://www.usf.edu\">University of South Florida</a> (C#, Java, Python, Technical Writing).\r\n        </p></div>\r\n    <div id=\"proDev\"><p>\r\n            I also spend a lot of my time taking various\r\n            <a href=\"https://en.wikipedia.org/wiki/Massive_open_online_course\">MOOC </a>courses via\r\n            <a href=\"http://coursera.org\">Coursera.org</a>, Udemy.com and\r\n            <a href=\"edx.org\">EdX.org</a> in particular the Data Science and Programming fields so I can keep my skills somewhat fresh. I attend\r\n            several meetups in the Tampa Bay and Orlando areas, as well as, annual Code Camps, SQL Saturdays, IT Pro Camps,\r\n            Xamarin Dev Days and Hackathons. I also try to blog about technology on my\r\n            <a href=\"http://mattkingit.com/blogs\">Matt King IT</a> website I created with WordPress.\r\n        </p></div>\r\n    <div id=\"hobbies\"><p>\r\n            Aside from computers I really enjoy professional wrestling and going to the movies. Some of my favorite wrestlers are \"Mr.\r\n            Perfect\" Curt Hennig, \"Ravishing\" Rick Rude, \"The Ultimate Warrior\", Kevin Owens and \"Macho Man\" Randy Savage.\r\n            Some of my favorite movies are \"A Bronx Tale\", \"Bill & Ted\'s Excellent Adventures\", \"Back to the Future\", \"Dogma\",\r\n            \"What\'s Eating Gilbert Grape\",\"Natural Born Killers\" and \"Space Balls\". I mostly prefer action movies but am\r\n            not to picky, I just like to have that escape every now and then.\r\n        </p></div>\r\n    <div id=\"techReview\"><p>\r\n            Oh yeah, I also did a Technical Review for Ken Doman\'s book\r\n            <u>\"Mastering ArcGIS Server Development with JavaScript\"</u>. You can get the book on\r\n            <a href=\"https://www.amazon.com/Mastering-ArcGIS-Server-Development-JavaScript/dp/1784396451\">Amazon.com</a>\r\n            or\r\n            <a href=\"https://www.packtpub.com/application-development/mastering-arcgis-server-development-javascript\">Packt Publishing</a> website.\r\n            <figure><img src=\"img/GISbook.jpg\" height=\"150\" width=\"100\" alt=\"Mastering ArcGIS Server Development with JavaScript book\">\r\n                <figcaption><u>\"Mastering ArcGIS Server Development with JavaScript\"</u> - Ken Dorman</figcaption></figure></p></div></header>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
