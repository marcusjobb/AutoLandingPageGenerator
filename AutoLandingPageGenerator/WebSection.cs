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

    internal class WebSection
    {
        public SectionType SectionType { get; set; }
        public int ID { get; set; }
        public string Name { get; set; } = "Nameless";
        public string Label { get; set; } = "Nameless";
        public string Padding { get; set; } = "10x";
        public string Margin { get; set; } = "0px";
        public string Font { get; set; } = "";
        public string BackColor { get; set; } = "#ffffff";
        public string ForeColor { get; set; } = "#000000";
        public string BackImage { get; set; } = "";
        public bool Stretch { get; set; } = false;
        public bool Scroll { get; set; } = true;
        public bool Repeat { get; set; } = true;
        public string Text { get; set; }
        public List<string> Images { get; set; }
        public string FontSize { get; set; }
        public string CTAText1 { get; set; }
        public string CTAText2 { get; set; }
        public string CTAText3 { get; set; }
        public string CTAIcon1{ get; set; }
        public string CTAIcon2 { get; set; }
        public string CTAIcon3 { get; set; }
        public string Height { get; set; } = "20px";
        public string Width { get; set; } = "100%";
        public string ArticlePicture { get; set; } = "";
    }
}
