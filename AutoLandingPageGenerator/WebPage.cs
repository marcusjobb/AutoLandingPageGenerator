// -----------------------------------------------------------------------------------------------
//  WebSection.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace AutoLandingPageGenerator
{
    using System;
    using System.Collections.Generic;
using System.Diagnostics;
    using System.IO;
    using System.Text;

    internal class WebPage
    {
        public List<WebSection> Sections { get; set; }
        public WebPage()
        {
            Sections = new();
            Sections.AddRange(
                new WebSection[]
                {
                    new WebSection{SectionType=SectionType.Main,Name="Landing page"},
                    new WebSection{SectionType=SectionType.Footer,Name="Footer"},
                    new WebSection{SectionType=SectionType.NotDefined, Name="Section1"},
                    new WebSection{SectionType=SectionType.NotDefined, Name="Section2"},
                    new WebSection{SectionType=SectionType.NotDefined, Name="Section3"},
                });
        }

        internal void Generate(string filePath)
        {
            var html = new StringBuilder();
            var css = new StringBuilder();
            html.AppendLine("<html lang=\"sv\">");
            foreach (var item in Sections)
            {
                switch (item.SectionType)
                {
                    case SectionType.Main:
                        html.AppendLine("<head>");
                        html.AppendLine("<title>" + item.Name + "</title>");
                        html.AppendLine("<meta charset=\"utf-8\"/>");
                        html.AppendLine("</head>");
                        html.AppendLine("<body>");
                        break;
                    case SectionType.Footer:
                        html.AppendLine("<footer>");
                        html.AppendLine(item.Text);
                        html.AppendLine("</footer>");
                        break;
                    case SectionType.NotDefined:
                        html.AppendLine("<p>");
                        html.AppendLine(item.Text);
                        html.AppendLine("</p>");
                        break;
                    case SectionType.ScrollingBanner:
                        break;
                    case SectionType.CallToAction:
                        break;
                    case SectionType.Text:
                        break;
                    case SectionType.TextWithImageRight:
                        break;
                    case SectionType.TextWithImageLeft:
                        break;
                    case SectionType.TextAndButton:
                        break;
                    case SectionType.ContactForm:
                        break;
                    default:
                        break;
                }
            }
            html.AppendLine("</body>");
            html.AppendLine("</html>");

            var htmlFile = SaveHTMLFile(filePath, html);
            SaveCSSFile(filePath, css);

            OpenWebpage(htmlFile);

        }

        private static void SaveCSSFile(string filePath, StringBuilder css)
        {
            var cssFile = Path.Combine(filePath, "style.css");
            File.WriteAllText(cssFile, css.ToString());
        }

        private static string SaveHTMLFile(string filePath, StringBuilder html)
        {
            var htmlFile = Path.Combine(filePath, "index.html");
            File.WriteAllText(htmlFile, html.ToString());
            return htmlFile;
        }

        private static void OpenWebpage(string htmlFile)
        {
            // Snatched from https://stackoverflow.com/a/4580317
            Process myProcess = new Process();
            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = htmlFile;
                myProcess.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
