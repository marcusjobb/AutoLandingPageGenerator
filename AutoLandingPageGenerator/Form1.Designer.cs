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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main page";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "&Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "&Preview";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 52;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 53;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(787, 143);
            this.panel1.TabIndex = 6;
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
            this.lbFontSize.Location = new System.Drawing.Point(305, 84);
            this.lbFontSize.Name = "lbFontSize";
            this.lbFontSize.Size = new System.Drawing.Size(71, 21);
            this.lbFontSize.TabIndex = 10;
            this.lbFontSize.Text = "Font size";
            // 
            // txSize
            // 
            this.txSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txSize.Location = new System.Drawing.Point(305, 108);
            this.txSize.Name = "txSize";
            this.txSize.Size = new System.Drawing.Size(62, 22);
            this.txSize.TabIndex = 11;
            // 
            // ckRepeat
            // 
            this.ckRepeat.AutoSize = true;
            this.ckRepeat.Location = new System.Drawing.Point(716, 88);
            this.ckRepeat.Name = "ckRepeat";
            this.ckRepeat.Size = new System.Drawing.Size(62, 19);
            this.ckRepeat.TabIndex = 20;
            this.ckRepeat.Text = "Repeat";
            this.ckRepeat.UseVisualStyleBackColor = true;
            // 
            // ckStretch
            // 
            this.ckStretch.AutoSize = true;
            this.ckStretch.Location = new System.Drawing.Point(647, 88);
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
            this.ckScroll.Location = new System.Drawing.Point(647, 111);
            this.ckScroll.Name = "ckScroll";
            this.ckScroll.Size = new System.Drawing.Size(55, 19);
            this.ckScroll.TabIndex = 19;
            this.ckScroll.Text = "Scroll";
            this.ckScroll.UseVisualStyleBackColor = true;
            // 
            // btBackImage
            // 
            this.btBackImage.Location = new System.Drawing.Point(566, 109);
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
            this.lbBackImage.Location = new System.Drawing.Point(564, 84);
            this.lbBackImage.Name = "lbBackImage";
            this.lbBackImage.Size = new System.Drawing.Size(73, 21);
            this.lbBackImage.TabIndex = 16;
            this.lbBackImage.Text = "Back img";
            // 
            // btForeColor
            // 
            this.btForeColor.Location = new System.Drawing.Point(483, 109);
            this.btForeColor.Name = "btForeColor";
            this.btForeColor.Size = new System.Drawing.Size(75, 23);
            this.btForeColor.TabIndex = 15;
            this.btForeColor.Text = "button5";
            this.btForeColor.UseVisualStyleBackColor = true;
            // 
            // ltForeColor
            // 
            this.ltForeColor.AutoSize = true;
            this.ltForeColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltForeColor.Location = new System.Drawing.Point(481, 84);
            this.ltForeColor.Name = "ltForeColor";
            this.ltForeColor.Size = new System.Drawing.Size(79, 21);
            this.ltForeColor.TabIndex = 14;
            this.ltForeColor.Text = "ForeColor";
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(395, 107);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(75, 23);
            this.btnBackColor.TabIndex = 13;
            this.btnBackColor.Text = "button5";
            this.btnBackColor.UseVisualStyleBackColor = true;
            // 
            // lbBackColor
            // 
            this.lbBackColor.AutoSize = true;
            this.lbBackColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBackColor.Location = new System.Drawing.Point(393, 82);
            this.lbBackColor.Name = "lbBackColor";
            this.lbBackColor.Size = new System.Drawing.Size(77, 21);
            this.lbBackColor.TabIndex = 12;
            this.lbBackColor.Text = "Backcolor";
            // 
            // lbFontFamily
            // 
            this.lbFontFamily.AutoSize = true;
            this.lbFontFamily.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFontFamily.Location = new System.Drawing.Point(170, 84);
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
            this.cbFontFamily.Location = new System.Drawing.Point(170, 108);
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
            this.panel2.Size = new System.Drawing.Size(787, 194);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(582, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 160);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txText
            // 
            this.txText.Location = new System.Drawing.Point(11, 12);
            this.txText.Multiline = true;
            this.txText.Name = "txText";
            this.txText.Size = new System.Drawing.Size(562, 163);
            this.txText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

