namespace AutoLandingPageGenerator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private int pageId = 0;
        private readonly WebPage webPage = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshSection()
        {
            if (pageId < 0) pageId = 0;
            if (pageId >= webPage.Sections.Count) pageId = webPage.Sections.Count - 1;
            var section = webPage.Sections[pageId];
            txName.Text = section.Name;
            txTitle.Text = section.Title;
            txPadding.Text = section.Padding;
            txMargin.Text = section.Margin;
            cbFontFamily.Text = section.Font;
            txSize.Text = section.FontSize;
            btnBackColor.Text = section.BackColor;
            btnBackColor.Text = section.ForeColor;
            btBackImage.Text = section.BackImage;
            ckStretch.Checked = section.Stretch;
            ckScroll.Checked = section.Scroll;
            ckRepeat.Checked = section.Repeat;
            txText.Text= section.Text;
        }

        private void UpdateSection()
        {
            var section = webPage.Sections[pageId];
            section.Name = txName.Text;
            section.Title = txTitle.Text;
            section.Padding = txPadding.Text;
            section.Margin = txMargin.Text;
            section.Font = cbFontFamily.Text;
            section.FontSize = txSize.Text;
            section.BackColor = btnBackColor.Text;
            section.ForeColor = btnBackColor.Text;
            section.BackImage = btBackImage.Text;
            section.Stretch = ckStretch.Checked;
            section.Scroll = ckScroll.Checked;
            section.Repeat = ckRepeat.Checked;
            section.Text = txText.Text;
            webPage.Sections[pageId] = section;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFontFamily.Items.Add("Georgia, serif");
            cbFontFamily.Items.Add("\"Gill Sans\", sans-serif");
            cbFontFamily.Items.Add("sans-serif");
            cbFontFamily.Items.Add("serif");
            cbFontFamily.Items.Add("system-ui");
            cbFontFamily.Items.Add("monospace");
            cbFontFamily.Items.Add("cursive");
            cbFontFamily.Items.Add("fantasy");
            cbFontFamily.Items.Add("ui-monospace");
            RefreshSection();
        }

        private void BtMoveLeft_Click(object sender, EventArgs e)
        {
            UpdateSection();
            pageId--;
            RefreshSection();
        }

        private void BtMoveRight_Click(object sender, EventArgs e)
        {
            UpdateSection();
            pageId++;
            RefreshSection();
        }

        private void BtPreview_Click(object sender, EventArgs e)
        {
            UpdateSection();
            webPage.Generate(@".\");
        }

    }
}
