﻿namespace AutoLandingPageGenerator
{

    partial class fmLandingPageWizard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbInfopage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.lbWidth = new System.Windows.Forms.Label();
            this.txWidth = new System.Windows.Forms.TextBox();
            this.lbHeight = new System.Windows.Forms.Label();
            this.txHeight = new System.Windows.Forms.TextBox();
            this.cbSectionType = new System.Windows.Forms.ComboBox();
            this.lbSectionType = new System.Windows.Forms.Label();
            this.lbFontSize = new System.Windows.Forms.Label();
            this.txSize = new System.Windows.Forms.TextBox();
            this.ckRepeat = new System.Windows.Forms.CheckBox();
            this.ckStretch = new System.Windows.Forms.CheckBox();
            this.ckScroll = new System.Windows.Forms.CheckBox();
            this.btBackImage = new System.Windows.Forms.Button();
            this.lbBackImage = new System.Windows.Forms.Label();
            this.btForeColor = new System.Windows.Forms.Button();
            this.ltForeColor = new System.Windows.Forms.Label();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.lbBackgroundColor = new System.Windows.Forms.Label();
            this.lbFontFamily = new System.Windows.Forms.Label();
            this.cbFontFamily = new System.Windows.Forms.ComboBox();
            this.lbMargin = new System.Windows.Forms.Label();
            this.txMargin = new System.Windows.Forms.TextBox();
            this.lbPadding = new System.Windows.Forms.Label();
            this.txPadding = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txTitle = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbArticleImage = new System.Windows.Forms.PictureBox();
            this.txText = new System.Windows.Forms.TextBox();
            this.btPreview = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.pnSettings.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfopage
            // 
            this.lbInfopage.AutoSize = true;
            this.lbInfopage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfopage.Location = new System.Drawing.Point(12, 9);
            this.lbInfopage.Name = "lbInfopage";
            this.lbInfopage.Size = new System.Drawing.Size(214, 30);
            this.lbInfopage.TabIndex = 0;
            this.lbInfopage.Text = "Start Page Generator";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(581, 415);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(500, 415);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 36;
            this.btnPrev.Text = "&Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(151, 415);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 33;
            this.btnMoveLeft.Text = "<<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.BtnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(232, 415);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 34;
            this.btnMoveRight.Text = ">>";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.BtnMoveRight_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 415);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 32;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSettings.Controls.Add(this.lbWidth);
            this.pnSettings.Controls.Add(this.txWidth);
            this.pnSettings.Controls.Add(this.lbHeight);
            this.pnSettings.Controls.Add(this.txHeight);
            this.pnSettings.Controls.Add(this.cbSectionType);
            this.pnSettings.Controls.Add(this.lbSectionType);
            this.pnSettings.Controls.Add(this.lbFontSize);
            this.pnSettings.Controls.Add(this.txSize);
            this.pnSettings.Controls.Add(this.ckRepeat);
            this.pnSettings.Controls.Add(this.ckStretch);
            this.pnSettings.Controls.Add(this.ckScroll);
            this.pnSettings.Controls.Add(this.btBackImage);
            this.pnSettings.Controls.Add(this.lbBackImage);
            this.pnSettings.Controls.Add(this.btForeColor);
            this.pnSettings.Controls.Add(this.ltForeColor);
            this.pnSettings.Controls.Add(this.btnBackgroundColor);
            this.pnSettings.Controls.Add(this.lbBackgroundColor);
            this.pnSettings.Controls.Add(this.lbFontFamily);
            this.pnSettings.Controls.Add(this.cbFontFamily);
            this.pnSettings.Controls.Add(this.lbMargin);
            this.pnSettings.Controls.Add(this.txMargin);
            this.pnSettings.Controls.Add(this.lbPadding);
            this.pnSettings.Controls.Add(this.txPadding);
            this.pnSettings.Controls.Add(this.lbTitle);
            this.pnSettings.Controls.Add(this.txTitle);
            this.pnSettings.Controls.Add(this.lbName);
            this.pnSettings.Controls.Add(this.txName);
            this.pnSettings.Location = new System.Drawing.Point(12, 52);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(931, 143);
            this.pnSettings.TabIndex = 1;
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWidth.Location = new System.Drawing.Point(239, 82);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(52, 21);
            this.lbWidth.TabIndex = 14;
            this.lbWidth.Text = "Width";
            // 
            // txWidth
            // 
            this.txWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txWidth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txWidth.Location = new System.Drawing.Point(239, 110);
            this.txWidth.Name = "txWidth";
            this.txWidth.Size = new System.Drawing.Size(62, 22);
            this.txWidth.TabIndex = 15;
            this.txWidth.Text = "100%";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeight.Location = new System.Drawing.Point(167, 82);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(56, 21);
            this.lbHeight.TabIndex = 12;
            this.lbHeight.Text = "Height";
            // 
            // txHeight
            // 
            this.txHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txHeight.Location = new System.Drawing.Point(167, 106);
            this.txHeight.Name = "txHeight";
            this.txHeight.Size = new System.Drawing.Size(62, 22);
            this.txHeight.TabIndex = 13;
            // 
            // cbSectionType
            // 
            this.cbSectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSectionType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSectionType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSectionType.FormattingEnabled = true;
            this.cbSectionType.Location = new System.Drawing.Point(526, 41);
            this.cbSectionType.Name = "cbSectionType";
            this.cbSectionType.Size = new System.Drawing.Size(248, 29);
            this.cbSectionType.TabIndex = 7;
            this.cbSectionType.SelectedIndexChanged += new System.EventHandler(this.CbSectionType_SelectedIndexChanged);
            // 
            // lbSectionType
            // 
            this.lbSectionType.AutoSize = true;
            this.lbSectionType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSectionType.Location = new System.Drawing.Point(526, 17);
            this.lbSectionType.Name = "lbSectionType";
            this.lbSectionType.Size = new System.Drawing.Size(95, 21);
            this.lbSectionType.TabIndex = 6;
            this.lbSectionType.Text = "Section type";
            // 
            // lbFontSize
            // 
            this.lbFontSize.AutoSize = true;
            this.lbFontSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFontSize.Location = new System.Drawing.Point(440, 82);
            this.lbFontSize.Name = "lbFontSize";
            this.lbFontSize.Size = new System.Drawing.Size(71, 21);
            this.lbFontSize.TabIndex = 18;
            this.lbFontSize.Text = "Font size";
            // 
            // txSize
            // 
            this.txSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txSize.Location = new System.Drawing.Point(440, 106);
            this.txSize.Name = "txSize";
            this.txSize.Size = new System.Drawing.Size(62, 22);
            this.txSize.TabIndex = 19;
            // 
            // ckRepeat
            // 
            this.ckRepeat.AutoSize = true;
            this.ckRepeat.Location = new System.Drawing.Point(851, 86);
            this.ckRepeat.Name = "ckRepeat";
            this.ckRepeat.Size = new System.Drawing.Size(62, 19);
            this.ckRepeat.TabIndex = 27;
            this.ckRepeat.Text = "Repeat";
            this.ckRepeat.UseVisualStyleBackColor = true;
            // 
            // ckStretch
            // 
            this.ckStretch.AutoSize = true;
            this.ckStretch.Location = new System.Drawing.Point(782, 86);
            this.ckStretch.Name = "ckStretch";
            this.ckStretch.Size = new System.Drawing.Size(63, 19);
            this.ckStretch.TabIndex = 26;
            this.ckStretch.Text = "Stretch";
            this.ckStretch.UseVisualStyleBackColor = true;
            // 
            // ckScroll
            // 
            this.ckScroll.AutoSize = true;
            this.ckScroll.Checked = true;
            this.ckScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckScroll.Location = new System.Drawing.Point(782, 109);
            this.ckScroll.Name = "ckScroll";
            this.ckScroll.Size = new System.Drawing.Size(55, 19);
            this.ckScroll.TabIndex = 28;
            this.ckScroll.Text = "Scroll";
            this.ckScroll.UseVisualStyleBackColor = true;
            // 
            // btBackImage
            // 
            this.btBackImage.Location = new System.Drawing.Point(701, 107);
            this.btBackImage.Name = "btBackImage";
            this.btBackImage.Size = new System.Drawing.Size(75, 23);
            this.btBackImage.TabIndex = 25;
            this.btBackImage.Text = "button5";
            this.btBackImage.UseVisualStyleBackColor = true;
            // 
            // lbBackImage
            // 
            this.lbBackImage.AutoSize = true;
            this.lbBackImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBackImage.Location = new System.Drawing.Point(699, 82);
            this.lbBackImage.Name = "lbBackImage";
            this.lbBackImage.Size = new System.Drawing.Size(73, 21);
            this.lbBackImage.TabIndex = 24;
            this.lbBackImage.Text = "Back img";
            // 
            // btForeColor
            // 
            this.btForeColor.Location = new System.Drawing.Point(618, 107);
            this.btForeColor.Name = "btForeColor";
            this.btForeColor.Size = new System.Drawing.Size(75, 23);
            this.btForeColor.TabIndex = 23;
            this.btForeColor.Text = "button5";
            this.btForeColor.UseVisualStyleBackColor = true;
            this.btForeColor.Click += new System.EventHandler(this.BtForeColor_Click);
            // 
            // ltForeColor
            // 
            this.ltForeColor.AutoSize = true;
            this.ltForeColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltForeColor.Location = new System.Drawing.Point(616, 82);
            this.ltForeColor.Name = "ltForeColor";
            this.ltForeColor.Size = new System.Drawing.Size(79, 21);
            this.ltForeColor.TabIndex = 22;
            this.ltForeColor.Text = "ForeColor";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(530, 105);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(75, 23);
            this.btnBackgroundColor.TabIndex = 21;
            this.btnBackgroundColor.Text = "button5";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.BtnBackgroundColor_Click);
            // 
            // lbBackgroundColor
            // 
            this.lbBackgroundColor.AutoSize = true;
            this.lbBackgroundColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBackgroundColor.Location = new System.Drawing.Point(528, 80);
            this.lbBackgroundColor.Name = "lbBackgroundColor";
            this.lbBackgroundColor.Size = new System.Drawing.Size(131, 21);
            this.lbBackgroundColor.TabIndex = 20;
            this.lbBackgroundColor.Text = "BackgroundColor";
            // 
            // lbFontFamily
            // 
            this.lbFontFamily.AutoSize = true;
            this.lbFontFamily.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFontFamily.Location = new System.Drawing.Point(305, 82);
            this.lbFontFamily.Name = "lbFontFamily";
            this.lbFontFamily.Size = new System.Drawing.Size(41, 21);
            this.lbFontFamily.TabIndex = 16;
            this.lbFontFamily.Text = "Font";
            // 
            // cbFontFamily
            // 
            this.cbFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFontFamily.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFontFamily.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFontFamily.FormattingEnabled = true;
            this.cbFontFamily.Location = new System.Drawing.Point(305, 106);
            this.cbFontFamily.Name = "cbFontFamily";
            this.cbFontFamily.Size = new System.Drawing.Size(121, 29);
            this.cbFontFamily.TabIndex = 17;
            // 
            // lbMargin
            // 
            this.lbMargin.AutoSize = true;
            this.lbMargin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMargin.Location = new System.Drawing.Point(92, 82);
            this.lbMargin.Name = "lbMargin";
            this.lbMargin.Size = new System.Drawing.Size(60, 21);
            this.lbMargin.TabIndex = 10;
            this.lbMargin.Text = "Margin";
            // 
            // txMargin
            // 
            this.txMargin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMargin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txMargin.Location = new System.Drawing.Point(92, 106);
            this.txMargin.Name = "txMargin";
            this.txMargin.Size = new System.Drawing.Size(62, 22);
            this.txMargin.TabIndex = 11;
            // 
            // lbPadding
            // 
            this.lbPadding.AutoSize = true;
            this.lbPadding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPadding.Location = new System.Drawing.Point(13, 82);
            this.lbPadding.Name = "lbPadding";
            this.lbPadding.Size = new System.Drawing.Size(66, 21);
            this.lbPadding.TabIndex = 8;
            this.lbPadding.Text = "Padding";
            // 
            // txPadding
            // 
            this.txPadding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPadding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txPadding.Location = new System.Drawing.Point(13, 106);
            this.txPadding.Name = "txPadding";
            this.txPadding.Size = new System.Drawing.Size(62, 22);
            this.txPadding.TabIndex = 9;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(257, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(47, 21);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Label";
            // 
            // txTitle
            // 
            this.txTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txTitle.Location = new System.Drawing.Point(258, 41);
            this.txTitle.Name = "txTitle";
            this.txTitle.Size = new System.Drawing.Size(260, 29);
            this.txTitle.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(13, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 21);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // txName
            // 
            this.txName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txName.Location = new System.Drawing.Point(13, 41);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(239, 29);
            this.txName.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pbArticleImage);
            this.panel2.Controls.Add(this.txText);
            this.panel2.Location = new System.Drawing.Point(12, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 194);
            this.panel2.TabIndex = 29;
            // 
            // pbArticleImage
            // 
            this.pbArticleImage.Location = new System.Drawing.Point(721, 15);
            this.pbArticleImage.Name = "pbArticleImage";
            this.pbArticleImage.Size = new System.Drawing.Size(192, 160);
            this.pbArticleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArticleImage.TabIndex = 1;
            this.pbArticleImage.TabStop = false;
            this.pbArticleImage.Click += new System.EventHandler(this.PbArticleImage_Click);
            // 
            // txText
            // 
            this.txText.AcceptsReturn = true;
            this.txText.Location = new System.Drawing.Point(13, 15);
            this.txText.Multiline = true;
            this.txText.Name = "txText";
            this.txText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txText.Size = new System.Drawing.Size(704, 163);
            this.txText.TabIndex = 30;
            // 
            // btPreview
            // 
            this.btPreview.Location = new System.Drawing.Point(783, 415);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(75, 23);
            this.btPreview.TabIndex = 35;
            this.btPreview.Text = "&Preview";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.BtPreview_Click);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(864, 415);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 38;
            this.btExport.Text = "&Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.BtExport_Click);
            // 
            // fmLandingPageWizard
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnSettings);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbInfopage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmLandingPageWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auto Landing Page Generator";
            this.Load += new System.EventHandler(this.FmLandingPageWizard_Load);
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label lbPadding;
        private System.Windows.Forms.TextBox txPadding;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txTitle;
        private System.Windows.Forms.Label lbFontFamily;
        private System.Windows.Forms.ComboBox cbFontFamily;
        private System.Windows.Forms.Label lbMargin;
        private System.Windows.Forms.TextBox txMargin;
        private System.Windows.Forms.CheckBox ckRepeat;
        private System.Windows.Forms.CheckBox ckStretch;
        private System.Windows.Forms.CheckBox ckScroll;
        private System.Windows.Forms.Button btBackImage;
        private System.Windows.Forms.Label lbBackImage;
        private System.Windows.Forms.Button btForeColor;
        private System.Windows.Forms.Label ltForeColor;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Label lbBackgroundColor;
        private System.Windows.Forms.Label lbFontSize;
        private System.Windows.Forms.TextBox txSize;
        private System.Windows.Forms.TextBox txText;
        private System.Windows.Forms.Label lbInfopage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.ComboBox cbSectionType;
        private System.Windows.Forms.Label lbSectionType;
        private System.Windows.Forms.PictureBox pbArticleImage;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.TextBox txWidth;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.TextBox txHeight;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Panel panel2;
    }
}

