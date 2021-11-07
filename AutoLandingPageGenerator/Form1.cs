namespace AutoLandingPageGenerator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class fmLandingPageWizard : Form
    {
        private int pageId = 0;
        private bool IsRefreshing = false;

        private readonly WebPage webPage = new();
        public fmLandingPageWizard()
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
            btnBackgroundColor.Text = section.BackgroundColor;
            btForeColor.Text = section.TextColor;
            btBackImage.Text = section.BackImage;
            ckStretch.Checked = section.Stretch;
            ckScroll.Checked = section.Scroll;
            ckRepeat.Checked = section.Repeat;
            txText.Text = section.Text;
            txHeight.Text = section.Height;
            txWidth.Text = section.Width;
            pbArticleImage.Image = section.ArticlePicture != "" ? Image.FromFile(section.ArticlePicture) : null;

            bool txTextVisible = true;
            bool PictureVisible = false;
            bool titleVisible = true;
            cbSectionType.Enabled = true;
            cbSectionType.SelectedIndex = cbSectionType.FindString(section.SectionType.ToString());

            switch (section.SectionType)
            {
                case SectionType.Main:
                    txTextVisible = false;
                    PictureVisible = false;
                    titleVisible = false;
                    cbSectionType.Enabled = false;
                    break;
                case SectionType.Footer:
                    PictureVisible = false;
                    titleVisible = false;
                    cbSectionType.Enabled = false;
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
            pbArticleImage.Left = section.SectionType == SectionType.TextWithImageRight ? 721 : 13;

            txText.Visible = txTextVisible;
            pbArticleImage.Visible = PictureVisible;
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
            section.BackgroundColor = btnBackgroundColor.Text;
            section.TextColor = btForeColor.Text;
            section.BackImage = btBackImage.Text;
            section.Stretch = ckStretch.Checked;
            section.Scroll = ckScroll.Checked;
            section.Repeat = ckRepeat.Checked;
            section.Text = txText.Text;
            section.Height = txHeight.Text;
            section.Width = txWidth.Text;
            webPage.Sections[pageId] = section;
        }

        private void FmLandingPageWizard_Load(object sender, EventArgs e)
        {             
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
            cbSectionType.Items.AddRange(types);
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

        private void BtnBackgroundColor_Click(object sender, EventArgs e)
        {
            var colSel = new ColorDialog
            {
                Color = ColorTranslator.FromHtml(btnBackgroundColor.Text)
            };
            colSel.ShowDialog();
            btnBackgroundColor.Text = ColorTranslator.ToHtml(colSel.Color);
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

        private void CbSectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsRefreshing)
            {
                var type = (SectionType)Enum.Parse(typeof(SectionType), cbSectionType.Text);
                webPage.Sections[pageId].SectionType = type;
                RefreshSection();
            }
        }

        private void PbArticleImage_Click(object sender, EventArgs e)
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
                pbArticleImage.Image = Image.FromFile(fileDlg.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Error reading image");
            }
        }

        private void BtExport_Click(object sender, EventArgs e)
        {
            UpdateSection();
            var userFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var exportPath = Path.Combine(userFolder, "StartPages", webPage.Sections[0].Name);
            if (!Directory.Exists(exportPath)) Directory.CreateDirectory(exportPath);
            webPage.Generate(exportPath);
        }
    }
}
