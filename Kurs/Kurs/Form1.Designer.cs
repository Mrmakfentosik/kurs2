namespace Kurs
{
    public partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(669, 488);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(490, -3);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.imageComboBoxEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.imageComboBoxEdit1.Properties.AutoComplete = false;
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Properties.DropDownRows = 10;
            this.imageComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Всё", "Всё", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Одежда, обувь, аксессуары ", "Одежда, обувь, аксессуары ", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Продукты питания, напитки ", "Продукты питания, напитки ", 18),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Строительство и ремонт ", "Строительство и ремонт ", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Сырье и материалы ", "Сырье и материалы ", 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Товары для детей, игрушки ", "Товары для детей, игрушки ", 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Подарки, сувениры ", "Подарки, сувениры ", 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Электроника, бытовая техника ", "Электроника, бытовая техника ", 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Мебель ", "Мебель ", 7),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Косметика, гигиена ", "Косметика, гигиена ", 8),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Промышленное оборудование ", "Промышленное оборудование ", 9),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Авто, мото ", "Авто, мото ", 10),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Медицина, здоровье ", "Медицина, здоровье ", 11),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Спорт, охота, туризм ", "Спорт, охота, туризм ", 12),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Животные и растения ", "Животные и растения ", 13),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Книги, канцелярия ", "Книги, канцелярия ", 14),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Музыка, творчество, искусство ", "Музыка, творчество, искусство ", 15),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Услуги ", "Услуги ", 16),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Другое", "Другое", 17)});
            this.imageComboBoxEdit1.Properties.SmallImages = this.imageCollection1;
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(181, 20);
            this.imageComboBoxEdit1.TabIndex = 24;
            this.imageComboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.imageComboBoxEdit1_SelectedIndexChanged);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "1455554770_line-74_icon-icons.com_53368.png");
            this.imageCollection1.Images.SetKeyName(1, "1455739720_Kitchen_Bold_Line_Color_Mix-28_icon-icons.com_53404.png");
            this.imageCollection1.Images.SetKeyName(2, "hammer_5015.png");
            this.imageCollection1.Images.SetKeyName(3, "brick-pile_39534.png");
            this.imageCollection1.Images.SetKeyName(4, "cube_geek_magic_rubics_toy_icon_183195.png");
            this.imageCollection1.Images.SetKeyName(5, "3605329-bucket-color-decoration-improvement-paint-renovation_107859.png");
            this.imageCollection1.Images.SetKeyName(6, "gift_icon-icons.com_48294.png");
            this.imageCollection1.Images.SetKeyName(7, "Sofa_5519.png");
            this.imageCollection1.Images.SetKeyName(8, "3612310-birthday-cosmetics-lipstick-makeup-nail-polish-sixteen-sweet_107925.png");
            this.imageCollection1.Images.SetKeyName(9, "3986752-building-factory-industry-icon_112345.png");
            this.imageCollection1.Images.SetKeyName(10, "3741751-bussiness-dellivery-ecommerce-marketplace-onlinestore-store_108906.png");
            this.imageCollection1.Images.SetKeyName(11, "syringe_medical_5333.png");
            this.imageCollection1.Images.SetKeyName(12, "footbal_icon-icons.com_53569.png");
            this.imageCollection1.Images.SetKeyName(13, "paw_icon-icons.com_48254.png");
            this.imageCollection1.Images.SetKeyName(14, "1490128081-newspaper01_82108.png");
            this.imageCollection1.Images.SetKeyName(15, "guitar_music_3848.png");
            this.imageCollection1.Images.SetKeyName(16, "1455739720_Kitchen_Bold_Line_Color_Mix-28_icon-icons.com_53404 (1).png");
            this.imageCollection1.Images.SetKeyName(17, "3844472-hamburger-list-menu-more-navigation_110338.png");
            this.imageCollection1.Images.SetKeyName(18, "pizza_food_4682.png");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 488);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imageComboBoxEdit1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

