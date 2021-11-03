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
        private bool IsRefreshing = false;

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
            IsRefreshing = true;
            if (pageId < 0) pageId = 0;
            if (pageId >= webPage.Sections.Count) pageId = webPage.Sections.Count - 1;

            var section = webPage.Sections[pageId];
            txName.Text = section.Name;
            txTitle.Text = section.Label;
            txPadding.Text = section.Padding;
            txMargin.Text = section.Margin;
            cbFontFamily.Text = section.Font;
            txSize.Text = section.FontSize;
            btnBackColor.Text = section.BackColor;
            btForeColor.Text = section.ForeColor;
            btBackImage.Text = section.BackImage;
            ckStretch.Checked = section.Stretch;
            ckScroll.Checked = section.Scroll;
            ckRepeat.Checked = section.Repeat;
            txText.Text = section.Text;
            txHeight.Text = section.Height;
            txWidth.Text = section.Width;
            pictureBox1.Image = section.ArticlePicture != "" ? Image.FromFile(section.ArticlePicture) : null;

            bool txTextVisible = true;
            bool PictureVisible = false;
            bool titleVisible = true;
            comboBox1.Enabled = true;
            comboBox1.SelectedIndex = comboBox1.FindString(section.SectionType.ToString());

            switch (section.SectionType)
            {
                case SectionType.Main:
                    txTextVisible = false;
                    PictureVisible = false;
                    titleVisible = false;
                    comboBox1.Enabled = false;
                    break;
                case SectionType.Footer:
                    PictureVisible = false;
                    titleVisible = false;
                    comboBox1.Enabled = false;
                    break;
                case SectionType.NotDefined:
                    break;
                case SectionType.ScrollingBanner:
                    break;
                case SectionType.CallToAction:
                    break;
                case SectionType.Text:
                    break;
                case SectionType.TextWithImageRight:
                    PictureVisible = true;
                    break;
                case SectionType.TextWithImageLeft:
                    PictureVisible = true;
                    break;
                case SectionType.TextAndButton:
                    break;
                case SectionType.ContactForm:
                    break;
                default:
                    break;
            }

            txText.Width = PictureVisible ? 704 : 902;
            txText.Left = section.SectionType == SectionType.TextWithImageLeft ? 209 : 13;
            pictureBox1.Left = section.SectionType == SectionType.TextWithImageRight ? 721 : 13;

            txText.Visible = txTextVisible;
            pictureBox1.Visible = PictureVisible;
            lbTitle.Visible = titleVisible;
            txTitle.Visible = titleVisible;
            IsRefreshing = false;
        }

        private void UpdateSection()
        {
            var section = webPage.Sections[pageId];
            section.Name = txName.Text;
            section.Label = txTitle.Text;
            section.Padding = txPadding.Text;
            section.Margin = txMargin.Text;
            section.Font = cbFontFamily.Text;
            section.FontSize = txSize.Text;
            section.BackColor = btnBackColor.Text;
            section.ForeColor = btForeColor.Text;
            section.BackImage = btBackImage.Text;
            section.Stretch = ckStretch.Checked;
            section.Scroll = ckScroll.Checked;
            section.Repeat = ckRepeat.Checked;
            section.Text = txText.Text;
            section.Height = txHeight.Text;
            section.Width = txWidth.Text;
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

            var types = System.Enum.GetNames(typeof(SectionType));
            comboBox1.Items.AddRange(types);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            UpdateSection();
            pageId++;
            RefreshSection();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            UpdateSection();
            pageId--;
            RefreshSection();
        }

        private void BtPreview_Click(object sender, EventArgs e)
        {
            UpdateSection();
            webPage.Generate(@".\");
        }

        private void BtnBackColor_Click(object sender, EventArgs e)
        {
            var colSel = new ColorDialog
            {
                Color = ColorTranslator.FromHtml(btnBackColor.Text)
            };
            colSel.ShowDialog();
            btnBackColor.Text = ColorTranslator.ToHtml(colSel.Color);
        }

        private void BtForeColor_Click(object sender, EventArgs e)
        {
            var colSel = new ColorDialog
            {
                Color = ColorTranslator.FromHtml(btForeColor.Text)
            };
            colSel.ShowDialog();
            btForeColor.Text = ColorTranslator.ToHtml(colSel.Color);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsRefreshing)
            {
                var type = (SectionType)Enum.Parse(typeof(SectionType), comboBox1.Text);
                webPage.Sections[pageId].SectionType = type;
                RefreshSection();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var userFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            OpenFileDialog fileDlg = new()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.jfif",
                FileName = userFolder
            };
            fileDlg.ShowDialog();
            webPage.Sections[pageId].ArticlePicture = fileDlg.FileName;
            try
            {
                pictureBox1.Image = Image.FromFile(fileDlg.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Error reading image");
            }
        }
    }
}
