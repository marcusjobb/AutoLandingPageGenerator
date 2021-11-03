namespace AutoLandingPageGenerator
{

    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbWidth = new System.Windows.Forms.Label();
            this.txWidth = new System.Windows.Forms.TextBox();
            this.lbHeight = new System.Windows.Forms.Label();
            this.txHeight = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFontSize = new System.Windows.Forms.Label();
            this.txSize = new System.Windows.Forms.TextBox();
            this.ckRepeat = new System.Windows.Forms.CheckBox();
            this.ckStretch = new System.Windows.Forms.CheckBox();
            this.ckScroll = new System.Windows.Forms.CheckBox();
            this.btBackImage = new System.Windows.Forms.Button();
            this.lbBackImage = new System.Windows.Forms.Label();
            this.btForeColor = new System.Windows.Forms.Button();
            this.ltForeColor = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.lbBackColor = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txText = new System.Windows.Forms.TextBox();
            this.btPreview = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfopage
            // 
            this.lbInfopage.AutoSize = true;
            this.lbInfopage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfopage.Location = new System.Drawing.Point(12, 9);
            this.lbInfopage.Name = "lbInfopage";
            this.lbInfopage.Size = new System.Drawing.Size(116, 30);
            this.lbInfopage.TabIndex = 0;
            this.lbInfopage.Text = "Main page";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(713, 415);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 50;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(632, 415);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 51;
            this.btnPrev.Text = "&Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(270, 415);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 52;
            this.btnMoveLeft.Text = "<<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(351, 415);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 53;
            this.btnMoveRight.Text = ">>";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 415);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 54;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbWidth);
            this.panel1.Controls.Add(this.txWidth);
            this.panel1.Controls.Add(this.lbHeight);
            this.panel1.Controls.Add(this.txHeight);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbFontSize);
            this.panel1.Controls.Add(this.txSize);
            this.panel1.Controls.Add(this.ckRepeat);
            this.panel1.Controls.Add(this.ckStretch);
            this.panel1.Controls.Add(this.ckScroll);
            this.panel1.Controls.Add(this.btBackImage);
            this.panel1.Controls.Add(this.lbBackImage);
            this.panel1.Controls.Add(this.btForeColor);
            this.panel1.Controls.Add(this.ltForeColor);
            this.panel1.Controls.Add(this.btnBackColor);
            this.panel1.Controls.Add(this.lbBackColor);
            this.panel1.Controls.Add(this.lbFontFamily);
            this.panel1.Controls.Add(this.cbFontFamily);
            this.panel1.Controls.Add(this.lbMargin);
            this.panel1.Controls.Add(this.txMargin);
            this.panel1.Controls.Add(this.lbPadding);
            this.panel1.Controls.Add(this.txPadding);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.txTitle);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.txName);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 143);
            this.panel1.TabIndex = 6;
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWidth.Location = new System.Drawing.Point(239, 82);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(52, 21);
            this.lbWidth.TabIndex = 25;
            this.lbWidth.Text = "Width";
            // 
            // txWidth
            // 
            this.txWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txWidth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txWidth.Location = new System.Drawing.Point(239, 110);
            this.txWidth.Name = "txWidth";
            this.txWidth.Size = new System.Drawing.Size(62, 22);
            this.txWidth.TabIndex = 26;
            this.txWidth.Text = "100%";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeight.Location = new System.Drawing.Point(167, 82);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(56, 21);
            this.lbHeight.TabIndex = 23;
            this.lbHeight.Text = "Height";
            // 
            // txHeight
            // 
            this.txHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txHeight.Location = new System.Drawing.Point(167, 106);
            this.txHeight.Name = "txHeight";
            this.txHeight.Size = new System.Drawing.Size(62, 22);
            this.txHeight.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(526, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 29);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(526, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Section type";
            // 
            // lbFontSize
            // 
            this.lbFontSize.AutoSize = true;
            this.lbFontSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFontSize.Location = new System.Drawing.Point(440, 82);
            this.lbFontSize.Name = "lbFontSize";
            this.lbFontSize.Size = new System.Drawing.Size(71, 21);
            this.lbFontSize.TabIndex = 10;
            this.lbFontSize.Text = "Font size";
            // 
            // txSize
            // 
            this.txSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txSize.Location = new System.Drawing.Point(440, 106);
            this.txSize.Name = "txSize";
            this.txSize.Size = new System.Drawing.Size(62, 22);
            this.txSize.TabIndex = 11;
            // 
            // ckRepeat
            // 
            this.ckRepeat.AutoSize = true;
            this.ckRepeat.Location = new System.Drawing.Point(851, 86);
            this.ckRepeat.Name = "ckRepeat";
            this.ckRepeat.Size = new System.Drawing.Size(62, 19);
            this.ckRepeat.TabIndex = 20;
            this.ckRepeat.Text = "Repeat";
            this.ckRepeat.UseVisualStyleBackColor = true;
            // 
            // ckStretch
            // 
            this.ckStretch.AutoSize = true;
            this.ckStretch.Location = new System.Drawing.Point(782, 86);
            this.ckStretch.Name = "ckStretch";
            this.ckStretch.Size = new System.Drawing.Size(63, 19);
            this.ckStretch.TabIndex = 18;
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
            this.ckScroll.TabIndex = 19;
            this.ckScroll.Text = "Scroll";
            this.ckScroll.UseVisualStyleBackColor = true;
            // 
            // btBackImage
            // 
            this.btBackImage.Location = new System.Drawing.Point(701, 107);
            this.btBackImage.Name = "btBackImage";
            this.btBackImage.Size = new System.Drawing.Size(75, 23);
            this.btBackImage.TabIndex = 17;
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
            this.lbBackImage.TabIndex = 16;
            this.lbBackImage.Text = "Back img";
            // 
            // btForeColor
            // 
            this.btForeColor.Location = new System.Drawing.Point(618, 107);
            this.btForeColor.Name = "btForeColor";
            this.btForeColor.Size = new System.Drawing.Size(75, 23);
            this.btForeColor.TabIndex = 15;
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
            this.ltForeColor.TabIndex = 14;
            this.ltForeColor.Text = "ForeColor";
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(530, 105);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(75, 23);
            this.btnBackColor.TabIndex = 13;
            this.btnBackColor.Text = "button5";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.BtnBackColor_Click);
            // 
            // lbBackColor
            // 
            this.lbBackColor.AutoSize = true;
            this.lbBackColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBackColor.Location = new System.Drawing.Point(528, 80);
            this.lbBackColor.Name = "lbBackColor";
            this.lbBackColor.Size = new System.Drawing.Size(77, 21);
            this.lbBackColor.TabIndex = 12;
            this.lbBackColor.Text = "Backcolor";
            // 
            // lbFontFamily
            // 
            this.lbFontFamily.AutoSize = true;
            this.lbFontFamily.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFontFamily.Location = new System.Drawing.Point(305, 82);
            this.lbFontFamily.Name = "lbFontFamily";
            this.lbFontFamily.Size = new System.Drawing.Size(41, 21);
            this.lbFontFamily.TabIndex = 8;
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
            this.cbFontFamily.TabIndex = 9;
            // 
            // lbMargin
            // 
            this.lbMargin.AutoSize = true;
            this.lbMargin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMargin.Location = new System.Drawing.Point(92, 82);
            this.lbMargin.Name = "lbMargin";
            this.lbMargin.Size = new System.Drawing.Size(60, 21);
            this.lbMargin.TabIndex = 6;
            this.lbMargin.Text = "Margin";
            // 
            // txMargin
            // 
            this.txMargin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMargin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txMargin.Location = new System.Drawing.Point(92, 106);
            this.txMargin.Name = "txMargin";
            this.txMargin.Size = new System.Drawing.Size(62, 22);
            this.txMargin.TabIndex = 7;
            // 
            // lbPadding
            // 
            this.lbPadding.AutoSize = true;
            this.lbPadding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPadding.Location = new System.Drawing.Point(13, 82);
            this.lbPadding.Name = "lbPadding";
            this.lbPadding.Size = new System.Drawing.Size(66, 21);
            this.lbPadding.TabIndex = 4;
            this.lbPadding.Text = "Padding";
            // 
            // txPadding
            // 
            this.txPadding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPadding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txPadding.Location = new System.Drawing.Point(13, 106);
            this.txPadding.Name = "txPadding";
            this.txPadding.Size = new System.Drawing.Size(62, 22);
            this.txPadding.TabIndex = 5;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(257, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(47, 21);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Label";
            // 
            // txTitle
            // 
            this.txTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txTitle.Location = new System.Drawing.Point(258, 41);
            this.txTitle.Name = "txTitle";
            this.txTitle.Size = new System.Drawing.Size(260, 29);
            this.txTitle.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(13, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 21);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // txName
            // 
            this.txName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txName.Location = new System.Drawing.Point(13, 41);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(239, 29);
            this.txName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txText);
            this.panel2.Location = new System.Drawing.Point(12, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 194);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(721, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txText
            // 
            this.txText.AcceptsReturn = true;
            this.txText.Location = new System.Drawing.Point(13, 15);
            this.txText.Multiline = true;
            this.txText.Name = "txText";
            this.txText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txText.Size = new System.Drawing.Size(704, 163);
            this.txText.TabIndex = 0;
            // 
            // btPreview
            // 
            this.btPreview.Location = new System.Drawing.Point(496, 415);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(75, 23);
            this.btPreview.TabIndex = 55;
            this.btPreview.Text = "&Preview";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbInfopage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auto Landing Page Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btNextSection;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Button btMoveLeft;
        private System.Windows.Forms.Button btMoveRight;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel pnControls;
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
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label lbBackColor;
        private System.Windows.Forms.Panel pnPreview;
        private System.Windows.Forms.Label lbFontSize;
        private System.Windows.Forms.TextBox txSize;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.TextBox txText;
        private System.Windows.Forms.ComboBox cbSectionType;
        private System.Windows.Forms.Label lbSectionType;
        private System.Windows.Forms.Label lbInfopage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.TextBox txWidth;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.TextBox txHeight;
    }
}

