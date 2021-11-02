// -----------------------------------------------------------------------------------------------
//  WebSection.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace AutoLandingPageGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class WebSection
    {
        public SectionType SectionType { get; set; }
        public int ID { get; set; }
        public string Name { get; set; } = "Nameless";
        public string Title { get; set; } = "Nameless";
        public string Padding { get; set; } = "10px";
        public string Margin { get; set; } = "10px";
        public string Font { get; set; } = "";
        public string BackColor{ get; set; }
        public string ForeColor { get; set; }
        public string BackImage  { get; set; }
        public bool Stretch { get; set; }
        public bool Scroll { get; set; }=true;
        public bool Repeat { get; set; } = true;
        public string Text { get; set; }
        public List<string> Images { get; set; }
        public string FontSize { get; set; }
    }
}
