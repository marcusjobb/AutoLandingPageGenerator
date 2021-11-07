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
            var lorem = "<br><br>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.";

            var head = new WebSection { SectionType = SectionType.Main, Name = "Landing page", Label = "top", FontSize = "12px", BackgroundColor = "#000", TextColor = "Beige", Padding = "0px", Margin = "0px", Height = "100%" };
            var sec = new WebSection { SectionType = SectionType.TextWithImageRight, Padding = "100px", Name = "Section", Label = "Section", Text = lorem, FontSize = "1.1em", BackgroundColor = "#00F", TextColor = "White", Height = "100%" };

            Sections.AddRange(
                    new WebSection[]
                    {
                    new WebSection(head){Name="Landing page", Label="Top"},
                    new WebSection{Name="Footer", Label="Footer", Text="(C) 2021 by me! - {nav}", FontSize="1.3em", BackgroundColor="#000", TextColor="White", Height="20px", SectionType=SectionType.Footer},
                    new WebSection{Name="ExtraCSS", Text="div{opacity: 0.95;}\r\ndiv:hover {opacity: 1;}",SectionType=SectionType.ExtraCSS},
                    new WebSection{Name="JavaScript", Text="",SectionType=SectionType.JavaScript},
                    new WebSection{Name="Min coola Landing page", Label="Intro", Height="300px", TextColor="White", BackgroundColor="Navy", SectionType=SectionType.HugeTitle},
                    new WebSection(sec){Name="Info", Label="", Text="Information..."+lorem, BackgroundColor="#8000FF",TextColor="White",SectionType=SectionType.Text},
                    new WebSection(sec){Name="Saw", Label="", Text="Do you want to play a game?" + lorem, BackgroundColor="#800040",TextColor="White", SectionType=SectionType.TextWithImageLeft,  ArticlePicture=@"C:\Users\marcu\OneDrive - Software Skills International AB\Bilder\1151e0f05813e3c039dbeda5167115e7.jpg"},
                    new WebSection(sec){Name="Biden", Label="", Text="<b>Biden</b> gillar spelprogrammering i Unity, det sa han på invigningstalet!"+lorem, BackgroundColor="#004000",TextColor="White", ArticlePicture=@"C:\Users\marcu\OneDrive - Software Skills International AB\Bilder\Biden Unity.jpg"},
                    });
        }

        internal void Generate(string filePath, string exportPicPath = "")
        {
            var html = new StringBuilder();
            var css = new StringBuilder();
            var nav = new StringBuilder();
            var javascript = new StringBuilder();

            WebSection footer = null;
            foreach (var item in Sections)
            {
                switch (item.SectionType)
                {
                    case SectionType.Main:
                        html.Append("<a name=top></a>");
                        html.Append(ReadHtmlSnippet(item));
                        css.Append(ReadCssSnippet(item));
                        break;
                    case SectionType.ExtraCSS:
                        css.Append(item.Text);
                        break;
                    case SectionType.JavaScript:
                        javascript.Append(item.Text);
                        break;
                    case SectionType.NotDefined:
                    case SectionType.Text:
                    case SectionType.TextWithImageRight:
                    case SectionType.TextWithImageLeft:
                        html.Append(ReadHtmlSnippet(item));
                        css.Append(ReadCssSectionSnippet(item));
                        nav.Append("<a href=#").Append(item.Label).Append('>').Append(item.Name).Append("</a>&nbsp;|&nbsp;");
                        break;
                    case SectionType.HugeTitle:
                        html.Append(ReadHtmlSnippet(item));
                        css.Append(ReadCssSectionSnippet(item));
                        break;
                    case SectionType.Footer:
                        footer = item;
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

            CleanUpFolder(filePath);

            html.AppendLine("</div>");
            if (footer != null)
            {
                html.Append(ReadHtmlSnippet(footer).Replace("{nav}", nav.ToString()));
                css.Append(ReadCssSnippet(footer));
            }

            html.AppendLine("</body>");
            html.AppendLine("</html>");
            if (javascript.ToString().Trim().Length > 0)
            {
                //<script src = "script.js" type = "text/javascript"/></script>
                SaveJSFile(filePath, javascript);
                html = html.Replace("{JSLink}", "<script src=\"script.js\" type=\"text/javascript\"/></script>");
            }
            else
            {
                html = html.Replace("{JSLink}", "");
            }

            var htmlFile = SaveHTMLFile(filePath, html, nav);
            SaveCSSFile(filePath, css);
            OpenWebpage(htmlFile);
        }

        private static string ReadHtmlSnippet(WebSection item, string picPath = "")
        {
            var filename = "Snippets\\" + item.SectionType.ToString().Replace("SectionType.", "") + ".snippet.html.txt";
            var file = File.ReadAllText(filename);
            return PatchCss(file, item, picPath);
        }

        private static string PatchCss(string code, WebSection item, string picPath = "")
        {
            string pic;
            if (picPath != "")
            {
                pic = item.ArticlePicture = Path.Combine(picPath, Path.GetFileName(item.ArticlePicture));
            }
            else
                pic = item.ArticlePicture;

            return code
                .Replace("{PageName}", item.Name)
                .Replace("{Text}", item.Text)
                .Replace("{SectionName}", item.Name)
                .Replace("{SectionLabel}", item.Label)
                .Replace("{Padding}", item.Padding)
                .Replace("{Margin}", item.Margin)
                .Replace("{BackgroundColor}", item.BackgroundColor)
                .Replace("{FontSize}", item.FontSize)
                .Replace("{ForeColor}", item.TextColor)
                .Replace("{Width}", item.Width)
                .Replace("{Height}", item.Height)
                .Replace("{ArticlePicture}", item.ArticlePicture)
                ;
        }

        private static string ReadCssSnippet(WebSection item, string picPath = "")
        {
            var filename = "Snippets\\" + item.SectionType.ToString().Replace("SectionType.", "") + ".snippet.css.txt";
            var css = File.ReadAllText("Snippets\\Generic.snippet.css.txt");

            var file = File.ReadAllText(filename)
                .Replace("{GenericCSS}", css)
                ;
            return PatchCss(file, item, picPath);
        }

        private static string ReadCssSectionSnippet(WebSection item, string picPath = "")
        {
            var filename = "Snippets\\" + item.SectionType.ToString().Replace("SectionType.", "") + ".snippet.css.txt";
            var css1 = File.ReadAllText("Snippets\\" + item.SectionType.ToString().Replace("SectionType.", "") + ".snippet.css.txt");
            var css2 = File.ReadAllText("Snippets\\genericSection.snippet.css.txt");
            var file = File.ReadAllText(filename).Replace("{GenericCSS}", css2);
            return PatchCss(css2 + file, item, picPath);
        }

        private static void SaveCSSFile(string filePath, StringBuilder css)
        {
            var cssFile = Path.Combine(filePath, "style.css");
            if (File.Exists(cssFile))
            {
                File.Delete(cssFile);
            }

            File.WriteAllText(cssFile, css.ToString());
        }

        private static void SaveJSFile(string filePath, StringBuilder js)
        {
            var jsFile = Path.Combine(filePath, "script.js");
            if (File.Exists(jsFile))
            {
                File.Delete(jsFile);
            }

            if (js.ToString().Trim().Length > 0) File.WriteAllText(jsFile, js.ToString());
        }

        private static void CleanUpFolder(string filePath)
        {
            foreach (var item in Directory.EnumerateFiles(filePath,"*.*",SearchOption.AllDirectories))
            {
                try
                {
                    File.Delete(item);
                }
                catch (Exception)
                {
                    Debug.WriteLine("Could not delete " + item);
                }
            }
        }

        private static string SaveHTMLFile(string filePath, StringBuilder html, StringBuilder nav)
        {
            var htmlFile = Path.Combine(filePath, "index.html");
            var htmlNav = html.ToString().Replace("{nav}", nav.ToString());
            if (File.Exists(htmlFile))
            {
                File.Delete(htmlFile);
            }

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
