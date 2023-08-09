using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Resources;
using System.Threading;


namespace ProjectPanasonic_
{


    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // veya FormBorderStyle.Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormClosing += Form2_FormClosing;
           
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
           
            ApplyColorMode(ColorModeHelper.CurrentColorMode);

        }
       
        private void ApplyColorMode(ColorModeHelper.ColorMode colorMode)
        {
            switch (colorMode)
            {
                case ColorModeHelper.ColorMode.Default:
                    // Varsayılan renkleri uygulayabilirsiniz.
                    this.BackColor = SystemColors.Control;
                    break;
                case ColorModeHelper.ColorMode.DarkMode:
                    // Karanlık mod renkleri uygulayabilirsiniz.
                    this.BackColor = Color.FromArgb(50, 50, 50);
                    break;
                case ColorModeHelper.ColorMode.BlueMode:
                    // Mavi mod renkleri uygulayabilirsiniz.
                    this.BackColor = Color.FromArgb(50, 50, 100);
                    break;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Programı kapatmak istiyor musunuz?", "Program Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button3);
            if (sonuc == DialogResult.No)
            {
                return;
            }
            else if (sonuc == DialogResult.Yes)
            {
                Application.Exit(); // Programı kapat

            }
        }

        private void kullanıcıTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();



        }

        private void rolDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {





            DialogResult result = MessageBox.Show("İletişim bilgilerimizin bulunduğu web sitemize yönlendiriliyorsunuz.", "BİZE ULAŞIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Web sitesine yönlendir
                System.Diagnostics.Process.Start("https://ewtr.panasonic.com/tr/iletisim/");
            }
            else if (result == DialogResult.No)
            {
                return;
            }

        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string yazıBilgisi = "Panasonic Electric Works Türkiye, İstanbul’da yer alan endüstriyel tesislerinde faaliyet göstermekte olup; konfor, güvenlik ve enerji verimliliği sağlayan yenilikçi ürün ve çözümlerini dünya pazarlarına ulaştırmayı ve insan odaklı yaklaşımlarla daha iyi ve konforlu bir ‘yaşam’ sunmayı hedeflemektedir. 2014 yılında gerçekleştirdiği yatırımla birlikte, sektörünün öncü ve “Super Brand” statüsüne sahip markası VİKO’yu da bünyesinde bulunduran Panasonic Electric Works Türkiye, 60’dan fazla ülkeye gerçekleştirdiği ihracat ile markalarını dünya pazarlarında başarıyla temsil etmekte ve Türkiye’deki sektör liderliğini sürdürmektedir.\r\n";

            MessageBox.Show(yazıBilgisi, "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult result = MessageBox.Show("Web sitesine yönlendirilmek ister misiniz?", "Hakkımızda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Web sitesine yönlendir
                System.Diagnostics.Process.Start("https://ewtr.panasonic.com/tr/urunler/");
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Programı kapat
            }
        }

        private void varsayılanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyColorMode(ColorModeHelper.ColorMode.Default);
            ApplyColorModeToOtherForms(ColorModeHelper.ColorMode.Default);
        }

        private void karanlıkModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyColorMode(ColorModeHelper.ColorMode.DarkMode);
            ApplyColorModeToOtherForms(ColorModeHelper.ColorMode.DarkMode);
        }

        private void maviModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyColorMode(ColorModeHelper.ColorMode.BlueMode);
            ApplyColorModeToOtherForms(ColorModeHelper.ColorMode.BlueMode);
        }
        private void ApplyColorModeToOtherForms(ColorModeHelper.ColorMode colorMode)
        {
            // Form3, Form4, Form5, Form6 gibi diğer formlardaki renk modlarını güncellemek için kullanılır.
            foreach (Form form in Application.OpenForms)
            {
                if (form == this || form is Form2) continue; // Mevcut formu ve Form2'yi atlatıyorum.

                if (form is Form3 form3)
                {
                    form3.ApplyColorMode(colorMode);
                }
                else if (form is Form4 form4)
                {
                    form4.ApplyColorMode(colorMode);
                }
               //diğer formların kontrolü
            }

            // Yardımcı sınıfta güncel renk modunu kaydediyoruz.
            ColorModeHelper.CurrentColorMode = colorMode;
        }

        

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ingiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }
        
    }



}
