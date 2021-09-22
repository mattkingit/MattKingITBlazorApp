#pragma checksum "C:\Code\Github\MattKingITBlazorApp\Pages\Employment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "241a5b313cf1356f881bf8e449c3418ca531c3e3"
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
#line 1 "C:\Code\Github\MattKingITBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\Github\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\Github\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\Github\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\Github\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\Github\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\Github\MattKingITBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\Github\MattKingITBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\Github\MattKingITBlazorApp\_Imports.razor"
using MKBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\Github\MattKingITBlazorApp\_Imports.razor"
using MKBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employment")]
    public partial class Employment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"Employment\"><h2>Employment</h2>\r\n    <section id=\"Navy\"><h2>United States Navy</h2>\r\n        <img src=\"img\\usn.png\" height=\"50\" width=\"50\" alt=\"US Navy Seal\">\r\n        <h3>Operations Specialist</h3>\r\n        <img src=\"img/os.png\" height=\"50\" width=\"50\" alt=\"Operation Specialist Logo\">\r\n        <p><h4>Units</h4>\r\n            <ul><li>RTC Great Lakes, Great Lakes IL (1990)</li>\r\n                <figure><img src=\"img\\rtc.jpg\" width=\"100\" height=\"150\" alt=\"Official Bootcamp Photo\">\r\n                    <figcaption>Recruite Training Center photo</figcaption></figure>\r\n                <li>OS \"A\" School - Dam Neck, VA (1990)</li>\r\n                <figure><img src=\"img\\osa1.jpg\" height=\"100\" width=\"200\" alt=\"OS A School\">\r\n                    <figcaption>OS \"A\" School</figcaption></figure>\r\n                <li>USS Chandler DDG-996 - San Diego, CA (1990 - 1994)</li>\r\n                <figure><img src=\"img/ddg996.jpg\" width=\"200px\" height=\"100px\" alt=\"USS Chandler DDG-996\">\r\n                    <figcaption>USS Chandler DDG-996</figcaption></figure>\r\n                <h4 class=\"duties\">Assignments/Recalls</h4>\r\n                <ul><li>USS Lewis B. Puller FFG-23</li>\r\n                    <figure><img src=\"img/ffg23.jpg\" width=\"200px\" height=\"100\" alt=\"USS Lewis B Puller FFG-23\">\r\n                        <figcaption>USS Lewis B Puller FFG-23</figcaption></figure></ul>\r\n                <h4 class=\"awards\">Awards</h4>\r\n                    <ul class=\"awards\"><li><img src=\"img/08_ndsmr.png\" width=\"50px\" height=\"20px\" alt=\"National Defense Service Medal\"> National Defense Service Medal (1990 - 1\r\n                            <sup>st</sup>)\r\n                        </li>\r\n                        <li><img src=\"img/10_swasmr.png\" width=\"50px\" height=\"20px\" alt=\"South West Asian Service Medal\"> Southwest Asia Service Medal w/ Bronze Start (1991 - 1\r\n                            <sup>st</sup>)\r\n                        </li>\r\n                        <li><img src=\"img/10_swasmr.png\" width=\"50px\" height=\"20px\" alt=\"South West Asian Service Medal\"> Southwest Asia Service Medal w/ Bronze Start (1992 - 2\r\n                            <sup>nd</sup>)\r\n                        </li>\r\n                        <li><img src=\"img/14_nssdr.png\" width=\"50px\" height=\"20px\" alt=\"Navy Sea Service Deployment Ribbon\"> Sea Service Deployment Ribbon (1992 - 1\r\n                            <sup>st</sup>)\r\n                        </li>\r\n                        <li><img src=\"img/05_navye.png\" width=\"50px\" height=\"20px\" alt=\"Navy Battle E\"> Navy Battle \"E\" (1993)\r\n                        </li>\r\n                        <li><img src=\"img/06_ngcmr.png\" width=\"50px\" height=\"20px\" alt=\"Navy Good Conduct Medal\"> Navy Good Conduct Medal (1993)\r\n                        </li>\r\n                        <li><img src=\"img/09_afemr.png\" width=\"50px\" height=\"20px\" alt=\"Armed Forces Expeditionary Medal\"> Armed Forces Expeditionary Medal (1993)\r\n                        </li>\r\n                        <li><img src=\"img/14_nssdr.png\" width=\"50px\" height=\"20px\" alt=\"Navy Sea Service Deployment Ribbon\"> Sea Service Deployment Ribbon (1993 - 2\r\n                            <sup>nd</sup>)\r\n                        </li>\r\n                        <li><img src=\"img/18_klmsr.png\" width=\"50px\" height=\"20px\" alt=\"Kuwait Liberation Medal Saudi\"> Kuwait Liberation Medal - Saudi (1994)\r\n                        </li>\r\n                        <li><img src=\"img/19_klmkr.png\" width=\"50px\" height=\"20px\" alt=\"Kuwait Liberation Medal Kuwait\"> Kuwait Liberation Medal - Kuwait (1994)\r\n                        </li></ul>\r\n                <div id=\"shellback\"><img src=\"img/shellback.png\" width=\"75px\" height=\"75px\" alt=\"Order of Shellback Patch\"> Shellback Certificate (March 1992)\r\n                </div>\r\n\r\n                <br>\r\n                <li>NR NWS Yorktown - NMCRC Cincinnati, OH (1990-1997)</li>\r\n                <li>NR NWS Concord - NMCRC Cincinnati, OH (1997-1998)</li>\r\n                <h4 class=\"duties\">Assignments/Recalls</h4>\r\n                <ul><li>USS John A Moore FFG-19 (June/July 1995)</li>\r\n                    <figure><img src=\"img/ffg19.jpg\" height=\"100\" width=\"200\" alt=\"USS John A Moore FFG 19\">\r\n                        <figcaption>USS John A Moore FFG-19</figcaption></figure></ul>\r\n                <h4 class=\"awards\">Awards</h4>\r\n                <ul class=\"awards\"><li><img src=\"img/07_nrmsmr.png\" width=\"50px\" height=\"20px\" alt=\"Navy Reserve Meritorious Service Medal\"> Navy Reserve Meritorious Service Medal (1996 - 1\r\n                        <sup>st</sup>)\r\n                    </li></ul>\r\n                <br>\r\n                <li>NR USS Inchon MCS/LPH-12 - NMCRC San Antonio, TX (1998 - 2000)</li>\r\n                <figure><img src=\"img/mcs12.jpg\" width=\"200\" height=\"100\" alt=\"USS Inchon MCS 12\">\r\n                    <figcaption>USS Inchon MCS-12</figcaption></figure>\r\n                <h4 class=\"duties\">Assignments/Recalls</h4>\r\n                <ul><li>USS Inchon MCS-12 (May/June 1999)</li>\r\n                    <img src=\"img/inchon.png\" width=\"100px\" height=\"100px\" alt=\"USS Inchon Logo\">\r\n                    <li>Navy Leadership School (OS2), Alameda, CA (June 2000)</li></ul>\r\n                <h4 class=\"awards\">Awards</h4>\r\n                <ul class=\"awards\"><li><img src=\"img/07_nrmsmr.png\" width=\"50px\" height=\"20px\" alt=\"Navy Reserve Meritorious Service Medal\"> Navy Reserve Meritorious Service Medal (1999 - 2\r\n                        <sup>nd</sup>)\r\n                    </li>\r\n                    <li><img src=\"img/05_navye.png\" width=\"50px\" height=\"20px\" alt=\"Navy Battle E\"> Navy Battle \"E\" (1999 - 2\r\n                        <sup>nd</sup>)\r\n                    </li>\r\n                    <li><img src=\"img/04_nucr.png\" width=\"50px\" height=\"20px\" alt=\"Navy Unit Commendation\"> Navy Unit Commendation (1999)\r\n                    </li>\r\n                    <li><img src=\"img/03_jucr.png\" width=\"50px\" height=\"20px\" alt=\"Joint Meritorious Unit Award\"> Joint Meritorious Unit Award (1999)\r\n                    </li>\r\n                    <li><img src=\"img/11_kosovor.png\" width=\"50px\" height=\"20px\" alt=\"Kosovo Campaign Medal\"> Kosovo Campaign Medal (1999)\r\n                    </li></ul>\r\n                <br>\r\n                <li>NR CINCUSNAVEUR - NMCRC Tallahassee, FL (2000-2002)</li>\r\n                <h4 class=\"duties\">Assignments/Recalls</h4>\r\n                <ul><li>USS Samuel E Morison FFG-13 (March 2001)</li>\r\n                    <figure><img src=\"img/ffg13.jpg\" width=\"200\" height=\"100\" alt=\"USS Samuel E Morison FFG-13\">\r\n                        <figcaption>USS Samuel E Morison FFG-13</figcaption></figure>\r\n                    <li>Joint Interagency Task Force East (JIATFE), Key West, FL (July 2001)</li>\r\n                    <img src=\"img/jiatf.png\" width=\"100\" height=\"100\" alt=\"Joint Interagency Task Force Sourth\">\r\n                    <li>USS John F Kennedy CV-67 (July 2001)</li>\r\n                    <figure><img src=\"img/cv67.jpg\" height=\"100\" width=\"200\" alt=\"USS John F Kennedy CV 67\">\r\n                        <figcaption>USS John F Kennedy CV-67</figcaption></figure>\r\n                    <li>CINCUSNAVEUR, London, UK (April 2002)</li>\r\n                    <img src=\"img/cincusnaveur.jpg\" width=\"100\" height=\"100\" alt=\"Commander in Chief Naval Forces Europe\"></ul>\r\n                <h4 class=\"awards\">Awards</h4>\r\n                <ul class=\"awards\"><li><img src=\"img/07_nrmsmr.png\" width=\"50px\" height=\"20px\" alt=\"Navy Reserve Meritorious Service Medal\"> Navy Reserve Meritorious Service Metal (2002 - 3\r\n                        <sup>rd</sup>)\r\n                    </li>\r\n                    <li><img src=\"img/21_pistolr.png\" width=\"50px\" height=\"20px\" alt=\"Pistol Sharp Shooter Ribbon\"> 9mm Sharp Shooter Ribbon (2002 - 1\r\n                        <sup>st</sup>)</li></ul>\r\n                <br>\r\n                <li>NR USS Klakring FFG-42 (2002-2003)</li>\r\n                <figure><img src=\"img/ffg42.jpg\" width=\"200\" height=\"100\" alt=\"USS Klakring FFG-42\">\r\n                    <figcaption>USS Klakring FFG-42</figcaption></figure>\r\n                <h4 class=\"duties\">Assignments/Recalls</h4>\r\n                <ul><li>USS Constitution, Boston, MA (August 2002)</li>\r\n                    <figure><img src=\"img/const.jpg\" width=\"200\" height=\"100\" alt=\"USS Constitution\">\r\n                        <figcaption>USS Constitution (Old Iron Sides)</figcaption></figure>\r\n                    <li>USS Klakring FFG-42 (January 2003)</li>\r\n                    <img src=\"img/klakring.png\" width=\"100\" height=\"120\" alt=\"USS Klakring Logo\"></ul>\r\n                <li>Sealift Logistics Command/Military Sealift Command/CTF-53 - NMCRC Tampa, FL (2003 - 2012)</li>\r\n                <figure><img src=\"img/MSC.jpg\" width=\"100\" height=\"100\" alt=\"Military Sealift Command\">\r\n                    <figcaption>Military Sealift Command</figcaption></figure>\r\n                <h4 class=\"duties\">Assignments/Recalls</h4>\r\n                <ul><li>Navy Leadership School (OS1), Coronado, CA (July 2004)</li>\r\n                    <li>COMSCCENT Bahrain (August 2003, March 2005, May/June 2006, August 2008)</li>\r\n                    <img src=\"img/MSCCentBahrain.jpg\" width=\"100\" height=\"100\" alt=\"Military Sealift Command Central Bahrain\">\r\n                    <li>MSCO Kuwait, Kuwait Naval Base (October 2006)</li>\r\n                    <img src=\"img/knbTentCity.jpg\" width=\"200\" height=\"150\" alt=\"Me at Kuwait Naval Base\">\r\n                    <li>NRD Miami, FL (January - October 2007)</li>\r\n                    <img src=\"img/nrdmiami.jpg\" width=\"200\" height=\"150\" alt=\"James and I at NRD Miami\">\r\n                    <li>Command Strike Force Training Atlantic (CSFTL) - USS Theodore Roosevelt CVN-71 (May 2008)</li>\r\n                    <img src=\"img/csftla.jpg\" width=\"100\" height=\"100\" alt=\"Command Strike Force Training Atlantic Logo\">\r\n                    <li>CNEC6F//CNA, Naples, Italy (October 2008 - April 2009)</li>\r\n                    <img src=\"img/cne.jpg\" width=\"100\" height=\"100\" alt=\"Commander Naval Forces Europe\">\r\n                    <img src=\"img/c6f.jpg\" width=\"100\" height=\"100\" alt=\"Commander 6<sup>th</sup> Fleet\">\r\n                    <img src=\"img/cna.jpg\" width=\"100\" height=\"100\" alt=\"Commander Naval Forces Africa\">\r\n                    <li>Austere Challenge 09 - USS Mount Whitney LCC 20 (2009)</li>\r\n                    <figure><img src=\"img/lcc20.jpg\" width=\"200\" height=\"100\" alt=\"USS Mount Whitney - LCC 20\">\r\n                        <figcaption>USS Mount Whitney LCC-20</figcaption></figure></ul>\r\n                <h4 class=\"awards\">Awards</h4>\r\n                <ul class=\"awards\"><li><img src=\"img/21_pistolr.png\" width=\"50px\" height=\"20px\" alt=\"Pistol Sharp Shooter Ribbon\"> Sharp Shooter Pistol (9mm) Ribbon (2004 - 2\r\n                        <sup>nd</sup>, 2011 - 3\r\n                        <sup>rd</sup>)\r\n                    </li>\r\n                    <li><img src=\"img/20_rifler.png\" width=\"50px\" height=\"20px\" alt=\"Rifle Sharp Shooter Ribbon\"> Sharp Shooter Rifleman Ribbon (2006)</li>\r\n                    <li><img src=\"img/07_nrmsmr.png\" width=\"50px\" height=\"20px\" alt=\"Navy Reserve Meritorious Service Medal\"> Navy Reserve Service Medal (2005 - 4\r\n                        <sup>th</sup>, 2008 - 5\r\n                        <sup>th</sup>)\r\n                    </li>\r\n                    <li><img src=\"img/02_namr.png\" width=\"50px\" height=\"20px\" alt=\"Navy and Marine Corp Achievement Medal\"> Navy and Marine Corps Achievement Medal (2007)\r\n                    </li>\r\n                    <li><img src=\"img/12_gwoter.png\" width=\"50px\" height=\"20px\" alt=\"Global War on Terrorism Expeditionary Medal\"> Global War on Terrorism Expeditionary Medal (2008)\r\n                    </li>\r\n                    <li><img src=\"img/13_gwotsr.png\" width=\"50px\" height=\"20px\" alt=\"Global War on Terrorism Service Medal\"> Global War on Terrorism Service Medal (2008)\r\n                    </li>\r\n                    <li><img src=\"img/16_nrossr.png\" width=\"50px\" height=\"20px\" alt=\"Navy/Marine Corp Overeseas Servie Ribbon\"> Navy/Marine Corp Overseas Service Ribbon (2008)\r\n                    </li>\r\n                    <li><img src=\"img/17_afrmr.png\" width=\"50px\" height=\"20px\" alt=\"Armed Forces Reserve Medal\"> Armed Forces Reserve Medal w/ Bronze Hour Glass (2009)\r\n                    </li>\r\n                    <li><img src=\"img/08_ndsmr.png\" width=\"50px\" height=\"20px\" alt=\"National Defense Service Medal\"> National Defense Service Medal (2\r\n                        <sup>nd</sup>)\r\n                    </li>\r\n                    <li><img src=\"img/10_swasmr.png\" width=\"50px\" height=\"20px\" alt=\"South West Asia Service Medal\"> Southwest Asia Service Medal w/ Bronze Start (3\r\n                        <sup>rd</sup>)\r\n                    </li>\r\n                    <li><img src=\"img/01_ncomr.png\" width=\"50px\" height=\"20px\" alt=\"Navy/Marine Corp Commendation Medal\"> Navy/Marine Corp Commendation Medal (2012)</li></ul></ul>\r\n            <figure class=\"medals\"><img src=\"img/AllRibbonsLrg.png\" height=\"200px\" width=\"300px\" alt=\"All Ribbons on Rack\">\r\n                <br>\r\n                <img src=\"img/01_ncomm.png\" height=\"75px\" width=\"34px\" alt=\"Navy Commendatation Medal\">\r\n                <img src=\"img/02_namm.png\" height=\"75px\" width=\"34px\" alt=\"Navy Achievement Medal\">\r\n                <img src=\"img/06_ngcm.png\" height=\"75px\" width=\"34px\" alt=\"Navy Good Conduct Medal\">\r\n                <img src=\"img/07_nrmsm.png\" height=\"75px\" width=\"34px\" alt=\"Navy Reserve Meritorious Service Medal\">\r\n                <img src=\"img/08_ndsm.png\" height=\"75px\" width=\"34px\" alt=\"National Defense Service Medal\">\r\n                <img src=\"img/09_afem.png\" height=\"75px\" width=\"34px\" alt=\"Armed Forces Expeditionary Medal\">\r\n                <img src=\"img/10_swasm.png\" height=\"75px\" width=\"34px\" alt=\"Southwest Asia Service Medal\">\r\n                <img src=\"img/11_kosovo.png\" height=\"75px\" width=\"34px\" alt=\"Kosovo Campaign Medal\">\r\n                <br>\r\n                <img src=\"img/12_gwotem.png\" height=\"75px\" width=\"34px\" alt=\"Global War on Terrorism Expeditionary Medal\">\r\n                <img src=\"img/13_gwotsm.png\" height=\"75px\" width=\"34px\" alt=\"Global War on Terrorism Service Medal\">\r\n                <img src=\"img/17_afrm.png\" height=\"75px\" width=\"34px\" alt=\"Armed Forces Reserve Medal\">\r\n                <img src=\"img/18_klmsm.png\" height=\"75px\" width=\"34px\" alt=\"Kuwaiti Liberation Medal - Saudi Arabia\">\r\n                <img src=\"img/19_klmk.png\" height=\"75px\" width=\"34px\" alt=\"Kuwaiti Liberation Medal - Kuwait\">\r\n                <img src=\"img/20_riflem.png\" height=\"75px\" width=\"34px\" alt=\"M16 Expert Rifle\">\r\n                <img src=\"img/21_pistolm.png\" height=\"75px\" width=\"34px\" alt=\"9mm Expert Pistol\">\r\n                <figcaption>My Ribbons and Medals</figcaption></figure></p></section>\r\n    <section id=\"City\" class=\"city department job\"><h2>City of Tampa</h2>\r\n        <img src=\"img/cot.png\" height=\"50\" width=\"50\" alt=\"City of Tampa Logo\">\r\n        <ul><li>Human Resources/Employment Services</li>\r\n            <ul><li>Office Support Specialist II/III</li>\r\n                <li>Personnel Technician II</li></ul>\r\n            <li>Transportation</li>\r\n            <ul><li>Transportation Technician II</li></ul>\r\n            <li>Water</li>\r\n            <ul><li>Departmental Applications Systems Analyst</li></ul>\r\n            <li>Technology & Innovation</li>\r\n            <ul><li>Applications Systems Analyst - Business Analyst</li>\r\n                <li>Applications Systems Analyst - Database Administrator</li>\r\n                <li>Senior Applications Programmer Analyst - SCCM/Systems Administrator</li></ul></ul></section></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
