namespace ProjectPanasonic_
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varsayılanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karanlıkModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıTanımlamalarıToolStripMenuItem,
            this.rolDüzenlemeToolStripMenuItem,
            this.görüntüAyarlarıToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıTanımlamalarıToolStripMenuItem
            // 
            this.kullanıcıTanımlamalarıToolStripMenuItem.Name = "kullanıcıTanımlamalarıToolStripMenuItem";
            this.kullanıcıTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.kullanıcıTanımlamalarıToolStripMenuItem.Text = "Kullanıcı Tanımları";
            this.kullanıcıTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıTanımlamalarıToolStripMenuItem_Click);
            // 
            // rolDüzenlemeToolStripMenuItem
            // 
            this.rolDüzenlemeToolStripMenuItem.Name = "rolDüzenlemeToolStripMenuItem";
            this.rolDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.rolDüzenlemeToolStripMenuItem.Text = "Rol Yetki Tanımları ";
            this.rolDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.rolDüzenlemeToolStripMenuItem_Click);
            // 
            // görüntüAyarlarıToolStripMenuItem
            // 
            this.görüntüAyarlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varsayılanToolStripMenuItem,
            this.karanlıkModToolStripMenuItem,
            this.maviModToolStripMenuItem});
            this.görüntüAyarlarıToolStripMenuItem.Name = "görüntüAyarlarıToolStripMenuItem";
            this.görüntüAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.görüntüAyarlarıToolStripMenuItem.Text = "Görüntü Ayarları";
            // 
            // varsayılanToolStripMenuItem
            // 
            this.varsayılanToolStripMenuItem.Name = "varsayılanToolStripMenuItem";
            this.varsayılanToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.varsayılanToolStripMenuItem.Text = "Varsayılan";
            this.varsayılanToolStripMenuItem.Click += new System.EventHandler(this.varsayılanToolStripMenuItem_Click);
            // 
            // karanlıkModToolStripMenuItem
            // 
            this.karanlıkModToolStripMenuItem.Name = "karanlıkModToolStripMenuItem";
            this.karanlıkModToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.karanlıkModToolStripMenuItem.Text = "Karanlık Mod ";
            this.karanlıkModToolStripMenuItem.Click += new System.EventHandler(this.karanlıkModToolStripMenuItem_Click);
            // 
            // maviModToolStripMenuItem
            // 
            this.maviModToolStripMenuItem.Name = "maviModToolStripMenuItem";
            this.maviModToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.maviModToolStripMenuItem.Text = "Mavi Mod";
            this.maviModToolStripMenuItem.Click += new System.EventHandler(this.maviModToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panasonic Bakım Modülü";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kullanıcıTanımlamalarıToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem rolDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varsayılanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karanlıkModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviModToolStripMenuItem;
    }
}