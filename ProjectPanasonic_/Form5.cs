using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectPanasonic_
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // veya FormBorderStyle.Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormClosing += Form5_FormClosing;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ApplyColorMode(ColorModeHelper.CurrentColorMode);


            // TODO: This line of code loads data into the 'projectPanasonicDataSet.TblUserinfo' table. You can move, or remove it, as needed.
            this.tblUserinfoTableAdapter.Fill(this.projectPanasonicDataSet.TblUserinfo);
            // TODO: This line of code loads data into the 'projectPanasonicDataSet.TblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.projectPanasonicDataSet.TblUser);

        }
        public void ApplyColorMode(ColorModeHelper.ColorMode colorMode)
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
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            // Önce tüm alanların dolu olup olmadığını kontrol ediyoruz.
            if (comboBoxEdit1.EditValue == null &&
                string.IsNullOrEmpty(lookUpEdit1.Text) ||
                string.IsNullOrEmpty(comboBoxEdit1.Text) ||
               
                lookUpEdit1.EditValue == null)





            {
                // Eğer bir veya daha fazla alan boşsa, kullanıcıya bir hata mesajı gösteriyoruz ve güncelleme işlemini yapmıyoruz.
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Güncelleme işlemi için geri dönüyoruz ve kodun devamını çalıştırmıyoruz.
            }
            MessageBox.Show("Yetki Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kullaniciadi = lookUpEdit1.Text;
            string yetki = comboBoxEdit1.Text;


            string UpdateQuery = "UPDATE TblUser set Authority = @yetki where UserName=@kullaniciadi";

            // Create a SqlConnection and SqlCommand
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(UpdateQuery, connection))
            {
                // Set the parameter values
                command.Parameters.AddWithValue("@yetki", yetki);
                command.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);


                // Open the database connection
                connection.Open();

                // Execute the INSERT statement
                command.ExecuteNonQuery();

                // Close the database connection
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false; // Formun kapatılmasını iptal et
                Form2 form2 = new Form2();
                form2.Show(); // Form1'i göster
            }
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }
    }
}
