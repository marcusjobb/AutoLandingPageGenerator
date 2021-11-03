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
    using System.Windows.Forms;

    internal class WebPage
    {
        public List<WebSection> Sections { get; set; }
        public WebPage()
        {
            Sections = new();
            Sections.AddRange(
                new WebSection[]
                {
                    new WebSection{SectionType=SectionType.Main,Name="Landing page", Label="Body", FontSize="12px", BackColor="#000",ForeColor="White", Padding="0px", Margin="0px", Height="100%"},
                    new WebSection{SectionType=SectionType.Footer,Name="Footer", Label="Footer", Text="(C) 2021 by me!", FontSize="12px", BackColor="#000",ForeColor="White", Height="20px"},
                    new WebSection{SectionType=SectionType.Text, Name="Section1",Label="Section1", Text="Some info", FontSize="12px", BackColor="#F00",ForeColor="White", Height="100%"},
                    new WebSection{SectionType=SectionType.TextAndButton, Name="Section2",Label="Section2",Text="Some info", FontSize="12px", BackColor="#0F0",ForeColor="White", Height="100%"},
                    new WebSection{SectionType=SectionType.Text, Name="Section3",Label="Section3",Text="Some info", FontSize="12px", BackColor="#00F",ForeColor="White", Height="100%"},
                }); ;
        }

        internal void Generate(string filePath)
        {
            var html = new StringBuilder();
            var css = new StringBuilder();
            var nav = new StringBuilder();
            html.AppendLine("<html lang=\"sv\">");
            css.AppendLine(".whooper{min-height: 90%;}");
            css.AppendLine(".content {flex-grow: 1;}");
            WebSection footer = null;
            foreach (var item in Sections)
            {
                switch (item.SectionType)
                {
                    case SectionType.Main:
                        html.AppendLine("<head>");
                        html.AppendLine("<title>" + item.Name + "</title>");
                        html.AppendLine("<meta charset=\"utf-8\"/>");
                        html.AppendLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"style.css\">");
                        html.AppendLine("</head>");
                        html.AppendLine("<body>");
                        html.AppendLine("<div class=\"whooper\">");
                        html.AppendLine("<header><h1>" + item.Name + "</h1>");
                        html.AppendLine("<nav>{0}<nav></header>");
                        css.AppendLine("html,body");
                        css.AppendLine("{");
                        break;
                    case SectionType.Footer:
                        css.AppendLine("footer");
                        css.AppendLine("{");
                        footer = item;
                        break;
                    case SectionType.NotDefined:
                        html.AppendLine("<p>");
                        html.AppendLine(item.Text.Replace("\r\n", "<br>"));
                        html.AppendLine("</p>");
                        break;
                    case SectionType.ScrollingBanner:
                        html.AppendLine("<a name=Link" + item.Label + ">");
                        nav.AppendLine("<a href=#" + item.Label + ">" + item.Name + "</a>");
                        css.AppendLine("#" + item.Label);
                        css.AppendLine("{");
                        break;
                    case SectionType.CallToAction:
                        html.AppendLine("<a name=Link" + item.Label + ">");
                        nav.AppendLine("<a href=#" + item.Label + ">" + item.Name + "</a>");
                        css.AppendLine("#" + item.Label);
                        css.AppendLine("{");
                        break;
                    case SectionType.Text:
                        css.AppendLine("#" + item.Label);
                        nav.AppendLine("<a href=#" + item.Label + ">" + item.Name + "</a>");
                        css.AppendLine("{");
                        html.AppendLine("<a name=Link" + item.Label + ">");
                        html.AppendLine("<div id=" + item.Label + ">");
                        html.AppendLine("<h1>" + item.Name + "</h1>");
                        html.AppendLine(item.Text.Replace("\r\n", "<br>"));
                        html.AppendLine("</div>");
                        break;
                    case SectionType.TextWithImageRight:
                        html.AppendLine("<a name=Link" + item.Label + ">");
                        nav.AppendLine("<a href=#" + item.Label + ">" + item.Name + "</a>");
                        html.AppendLine("<div id=" + item.Label + ">");
                        html.AppendLine("<h1>" + item.Name + "</h1>");
                        if (item.ArticlePicture != "") html.AppendLine("<img src=\"" + item.ArticlePicture + "\">");
                        html.AppendLine(item.Text.Replace("\r\n", "<br>"));
                        html.AppendLine("</div>");
                        css.AppendLine("#" + item.Label + " img{float:right; height:75%}");
                        css.AppendLine("#" + item.Label);
                        css.AppendLine("{");
                        break;
                    case SectionType.TextWithImageLeft:
                        html.AppendLine("<a name=Link" + item.Label + ">");
                        nav.AppendLine("<a href=#" + item.Label + ">" + item.Name + "</a>");
                        html.AppendLine("<div id=" + item.Label + ">");
                        html.AppendLine("<h1>" + item.Name + "</h1>");
                        if (item.ArticlePicture != "") html.AppendLine("<img src=\"" + item.ArticlePicture + "\">");
                        html.AppendLine(item.Text.Replace("\r\n", "<br>"));
                        html.AppendLine("</div>");
                        css.AppendLine("#" + item.Label + " img{float:left; height:75%}");
                        css.AppendLine("#" + item.Label);
                        css.AppendLine("{");
                        break;
                    case SectionType.TextAndButton:
                        html.AppendLine("<a name=Link" + item.Label + ">");
                        nav.AppendLine("<a href=#" + item.Label + ">" + item.Name + "</a>");
                        html.AppendLine("<div id=" + item.Label + ">");
                        html.AppendLine("<h1>" + item.Name + "</h1>");
                        html.AppendLine(item.Text.Replace("\r\n", "<br>"));
                        html.AppendLine("</div>");
                        css.AppendLine("#" + item.Label);
                        css.AppendLine("{");
                        break;
                    case SectionType.ContactForm:
                        html.AppendLine("<a name=Link" + item.Label + ">");
                        nav.AppendLine("<a href=#" + item.Label + ">" + item.Name + "</a>");
                        html.AppendLine("<div id=" + item.Label + ">");
                        html.AppendLine("<h1>" + item.Name + "</h1>");
                        html.AppendLine(item.Text.Replace("\r\n", "<br>"));
                        html.AppendLine("</div>");
                        css.AppendLine("#" + item.Label);
                        css.AppendLine("{");
                        break;
                    default:
                        html.AppendLine("<a name=Link" + item.Label + ">");
                        nav.AppendLine("<a href=#" + item.Label + ">" + item.Name + "</a>");
                        html.AppendLine("<div id=" + item.Label + ">");
                        html.AppendLine("<h1>" + item.Name + "</h1>");
                        html.AppendLine(item.Text.Replace("\r\n", "<br>"));
                        html.AppendLine("</div>");
                        css.AppendLine("#" + item.Label);
                        css.AppendLine("{");
                        break;
                }

                if (item.SectionType != SectionType.NotDefined)
                {
                    css.AppendLine(AddIfNotEmpty("Padding", item.Padding));
                    css.AppendLine(AddIfNotEmpty("Margin", item.Margin));
                    css.AppendLine(AddIfNotEmpty("background-color", item.BackColor));
                    css.AppendLine(AddIfNotEmpty("font-size", item.FontSize));
                    css.AppendLine(AddIfNotEmpty("color", item.ForeColor));
                    css.AppendLine(AddIfNotEmpty("width", item.Width));
                    css.AppendLine(AddIfNotEmpty("height", item.Height));
                    css.AppendLine(AddIfNotEmpty("font-family", item.Font));
                    css.AppendLine("}");
                }
            }
            html.AppendLine("</div>");
            html.AppendLine("<footer>");
            html.AppendLine(footer.Text);
            html.AppendLine("</footer>");
            html.AppendLine("</body>");
            html.AppendLine("</html>");
            var htmlFile = SaveHTMLFile(filePath, html, nav);
            SaveCSSFile(filePath, css);

            OpenWebpage(htmlFile);

        }

        private string AddIfNotEmpty(string tag, string value)
        {
            return string.IsNullOrEmpty(value) ? "" : tag + ":" + value + ";";
        }

        private static void SaveCSSFile(string filePath, StringBuilder css)
        {
            var cssFile = Path.Combine(filePath, "style.css");
            File.WriteAllText(cssFile, css.ToString());
        }

        private static string SaveHTMLFile(string filePath, StringBuilder html, StringBuilder nav)
        {
            var htmlFile = Path.Combine(filePath, "index.html");
            var htmlNav = string.Format(html.ToString(), nav.ToString());
            File.WriteAllText(htmlFile, htmlNav);
            return htmlFile;
        }

        private static void OpenWebpage(string htmlFile)
        {
            // Snatched from https://stackoverflow.com/a/4580317
            Process myProcess = new();
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
