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
    using System.Xml.Linq;

    internal class WebPage
    {
        public List<WebSection> Sections { get; set; }
        public WebPage()
        {
            Sections = new();
            Sections.AddRange(
                new WebSection[]
                {
                    new WebSection{SectionType=SectionType.Main,Name="Landing page", Label="Body", FontSize="12px", BackgroundColor="#000",ForeColor="White", Padding="0px", Margin="0px", Height="100%"},
                    new WebSection{SectionType=SectionType.Footer,Name="Footer", Label="Footer", Text="(C) 2021 by me!", FontSize="12px", BackgroundColor="#000",ForeColor="White", Height="20px"},
                    new WebSection{SectionType=SectionType.Text, Name="Section1",Label="Section1", Text="Some info", FontSize="12px", BackgroundColor="#F00",ForeColor="White", Height="100%"},
                    new WebSection{SectionType=SectionType.TextWithImageLeft, Name="Section2",Label="Section2",Text="Do you want to play a game?", FontSize="12px", BackgroundColor="#0F0",ForeColor="White", Height="100%",ArticlePicture=@"C:\Users\marcu\OneDrive - Software Skills International AB\Bilder\1151e0f05813e3c039dbeda5167115e7.jpg"},
                    new WebSection{SectionType=SectionType.TextWithImageRight, Name="Section3",Label="Section3",Text="<b>Biden</b> gillar spelprogrammering i unity, det sa han på invigningstalet!", FontSize="12px", BackgroundColor="#00F",ForeColor="White", Height="100%", ArticlePicture=@"C:\Users\marcu\OneDrive - Software Skills International AB\Bilder\Biden Unity.jpg"},
                });
        }

        internal void Generate(string filePath)
        {
            var html = new StringBuilder();
            var css = new StringBuilder();
            var nav = new StringBuilder();
            WebSection footer = null;
            foreach (var item in Sections)
            {
                switch (item.SectionType)
                {
                    case SectionType.Main:
                        html.Append(ReadHtmlSnippet(item));
                        css.Append(ReadCssSnippet(item));
                        break;
                    case SectionType.Footer:
                        footer = item;
                        break;
                    case SectionType.NotDefined:
                        html.Append(ReadHtmlSnippet(item));
                        css.Append(ReadCssSnippet(item));
                        break;
                    //case SectionType.ScrollingBanner:
                    //    html.Append("<a name=Link").Append(item.Label).AppendLine("></a>");
                    //    nav.Append("<a href=#Link").Append(item.Label).Append('>').Append(item.Name).Append("</a>");
                    //    css.Append('#').AppendLine(item.Label)
                    //        .AppendLine("{");
                    //    break;
                    //case SectionType.CallToAction:
                    //    html.Append("<a name=Link").Append(item.Label).AppendLine("></a>");
                    //    nav.Append("<a href=#Link").Append(item.Label).Append('>').Append(item.Name).Append("</a>");
                    //    css.Append('#').AppendLine(item.Label).;
                    //    break;
                    case SectionType.Text:
                        html.Append(ReadHtmlSnippet(item));
                        css.Append(ReadCssSectionSnippet(item));
                        break;
                    case SectionType.TextWithImageRight:
                        html.Append(ReadHtmlSnippet(item));
                        css.Append(ReadCssSectionSnippet(item));
                        break;
                    case SectionType.TextWithImageLeft:
                        html.Append(ReadHtmlSnippet(item));
                        css.Append(ReadCssSectionSnippet(item));
                        break;
                        //case SectionType.TextAndButton:
                        //    nav.Append("<a href=#Link").Append(item.Label).Append('>').Append(item.Name).Append("</a>");
                        //    html.Append("<a name=Link").Append(item.Label).AppendLine("></a>");
                        //    html.Append("<div id=").Append(item.Label).AppendLine(">");
                        //    html.Append("<h1>").Append(item.Name).AppendLine("</h1>");
                        //    html.AppendLine(item.Text.Replace("\r\n", "<br>"));
                        //    html.AppendLine("</div>");
                        //    css.Append('#').AppendLine(item.Label);
                        //    css.AppendLine("{");
                        //    break;
                        //case SectionType.ContactForm:
                        //    nav.Append("<a href=#Link").Append(item.Label).Append('>').Append(item.Name).Append("</a>");
                        //    html.Append("<a name=Link").Append(item.Label).AppendLine("></a>");
                        //    html.Append("<div id=").Append(item.Label).AppendLine(">");
                        //    html.Append("<h1>").Append(item.Name).AppendLine("</h1>");
                        //    html.AppendLine(item.Text.Replace("\r\n", "<br>"));
                        //    html.AppendLine("</div>");
                        //    css.Append('#').AppendLine(item.Label);
                        //    css.AppendLine("{");
                        //    break;
                        //default:
                        //    html.Append("<a name=Link").Append(item.Label).AppendLine("></a>");
                        //    nav.Append("<a href=#Link").Append(item.Label).Append('>').Append(item.Name).Append("</a>");
                        //    html.Append("<div id=").Append(item.Label).AppendLine(">");
                        //    html.Append("<h1>").Append(item.Name).AppendLine("</h1>");
                        //    html.AppendLine(item.Text.Replace("\r\n", "<br>"));
                        //    html.AppendLine("</div>");
                        //    css.Append('#').AppendLine(item.Label);
                        //    css.AppendLine("{");
                        //    break;
                }

                //if (item.SectionType != SectionType.NotDefined)
                //{
                //    css.AppendLine(AddIfNotEmpty("Padding", item.Padding));
                //    css.AppendLine(AddIfNotEmpty("Margin", item.Margin));
                //    css.AppendLine(AddIfNotEmpty("background-color", item.BackgroundColor));
                //    css.AppendLine(AddIfNotEmpty("font-size", item.FontSize));
                //    css.AppendLine(AddIfNotEmpty("color", item.ForeColor));
                //    css.AppendLine(AddIfNotEmpty("width", item.Width));
                //    css.AppendLine(AddIfNotEmpty("height", item.Height));
                //    css.AppendLine(AddIfNotEmpty("font-family", item.Font));
                //    css.AppendLine("}");
                //css.Append('#').Append(item.Label).AppendLine("Container");
                //css.AppendLine(AddIfNotEmpty("background-color", item.BackgroundColor));
                //css.AppendLine(AddIfNotEmpty("height", item.Height));
                //css.AppendLine("}");
                //}
            }

            html.AppendLine("</div>");
            html.Append(ReadHtmlSnippet(footer));
            css.Append(ReadCssSnippet(footer));
            html.AppendLine("</body>");
            html.AppendLine("</html>");
            var htmlFile = SaveHTMLFile(filePath, html, nav);
            SaveCSSFile(filePath, css);

            OpenWebpage(htmlFile);
        }

        private static string ReadHtmlSnippet(WebSection item)
        {
            var filename = "Snippets\\" + item.SectionType.ToString().Replace("SectionType.", "") + ".snippet.html.txt";
            string file = File.ReadAllText(filename);
            return PatchCss(file, item);
        }

        private static string PatchCss(string code, WebSection item)
        {
            return code
                .Replace("{PageName}", item.Name)
                .Replace("{Text}", item.Text)
                .Replace("{SectionName}", item.Name)
                .Replace("{Padding}", item.Padding)
                .Replace("{Margin}", item.Margin)
                .Replace("{BackgroundColor}", item.BackgroundColor)
                .Replace("{FontSize}", item.FontSize)
                .Replace("{ForeColor}", item.ForeColor)
                .Replace("{Width}", item.Width)
                .Replace("{Height}", item.Height)
                .Replace("{ArticlePicture}", item.ArticlePicture)
                ;
            ;
        }

        private static string ReadCssSnippet(WebSection item)
        {
            var filename = "Snippets\\" + item.SectionType.ToString().Replace("SectionType.", "") + ".snippet.css.txt";
            var css = File.ReadAllText("Snippets\\Generic.snippet.css.txt");

            string file = File.ReadAllText(filename)
                .Replace("{GenericCSS}", css)
                ;
            return PatchCss(file, item);
        }

        private static string ReadCssSectionSnippet(WebSection item)
        {
            var filename = "Snippets\\" + item.SectionType.ToString().Replace("SectionType.", "") + ".snippet.css.txt";
            var css = File.ReadAllText("Snippets\\genericSection.snippet.css.txt");
            string file = File.ReadAllText(filename)
                .Replace("{PageName}", item.Name)
                .Replace("{GenericCSS}", css)
                ;
            return PatchCss(file, item);
        }

        private static void SaveCSSFile(string filePath, StringBuilder css)
        {
            var cssFile = Path.Combine(filePath, "style.css");
            File.WriteAllText(cssFile, css.ToString());
        }

        private static string SaveHTMLFile(string filePath, StringBuilder html, StringBuilder nav)
        {
            var htmlFile = Path.Combine(filePath, "index.html");
            var htmlNav = html.ToString().Replace("{nav}", nav.ToString());
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
