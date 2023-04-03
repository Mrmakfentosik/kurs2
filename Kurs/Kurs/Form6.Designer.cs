namespace Kurs
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin.Controls.MaterialLabel materialLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.Text1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Text2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Check2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Check1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button = new Bunifu.Framework.UI.BunifuThinButton2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialLabel1.Location = new System.Drawing.Point(124, 293);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(153, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "зарегистрироваться";
            materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // Text1
            // 
            this.Text1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text1.BorderColorFocused = System.Drawing.Color.Blue;
            this.Text1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Text1.BorderThickness = 3;
            this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text1.isPassword = false;
            this.Text1.Location = new System.Drawing.Point(41, 62);
            this.Text1.Margin = new System.Windows.Forms.Padding(4);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(354, 44);
            this.Text1.TabIndex = 0;
            this.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Text1.OnValueChanged += new System.EventHandler(this.Text1_OnValueChanged);
            // 
            // Text2
            // 
            this.Text2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text2.BorderColorFocused = System.Drawing.Color.Blue;
            this.Text2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Text2.BorderThickness = 3;
            this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text2.isPassword = true;
            this.Text2.Location = new System.Drawing.Point(41, 147);
            this.Text2.Margin = new System.Windows.Forms.Padding(4);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(354, 44);
            this.Text2.TabIndex = 1;
            this.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Check2
            // 
            this.Check2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Check2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Check2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Check2.Checked = true;
            this.Check2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Check2.ForeColor = System.Drawing.Color.White;
            this.Check2.Location = new System.Drawing.Point(140, 208);
            this.Check2.Name = "Check2";
            this.Check2.Size = new System.Drawing.Size(20, 20);
            this.Check2.TabIndex = 4;
            this.Check2.OnChange += new System.EventHandler(this.Check2_OnChange);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(166, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Запомнить меня";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Check1
            // 
            this.Check1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Check1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Check1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Check1.Checked = true;
            this.Check1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Check1.ForeColor = System.Drawing.Color.White;
            this.Check1.Location = new System.Drawing.Point(402, 158);
            this.Check1.Name = "Check1";
            this.Check1.Size = new System.Drawing.Size(20, 20);
            this.Check1.TabIndex = 6;
            this.Check1.OnChange += new System.EventHandler(this.Check1_OnChange);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Button
            // 
            this.Button.ActiveBorderThickness = 1;
            this.Button.ActiveCornerRadius = 20;
            this.Button.ActiveFillColor = System.Drawing.Color.Red;
            this.Button.ActiveForecolor = System.Drawing.Color.White;
            this.Button.ActiveLineColor = System.Drawing.Color.Green;
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.BackColor = System.Drawing.SystemColors.Control;
            this.Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button.BackgroundImage")));
            this.Button.ButtonText = "Войти";
            this.Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button.IdleBorderThickness = 1;
            this.Button.IdleCornerRadius = 20;
            this.Button.IdleFillColor = System.Drawing.Color.White;
            this.Button.IdleForecolor = System.Drawing.Color.Black;
            this.Button.IdleLineColor = System.Drawing.Color.DarkViolet;
            this.Button.Location = new System.Drawing.Point(107, 247);
            this.Button.Margin = new System.Windows.Forms.Padding(5);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(181, 41);
            this.Button.TabIndex = 3;
            this.Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(423, 341);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(materialLabel1);
            this.Controls.Add(this.Check1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Check2);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox Text1;
        private Bunifu.Framework.UI.BunifuMetroTextbox Text2;
        private Bunifu.Framework.UI.BunifuThinButton2 Button;
        private Bunifu.Framework.UI.BunifuCheckbox Check2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCheckbox Check1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}