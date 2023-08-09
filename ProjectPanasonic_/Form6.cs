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

namespace ProjectPanasonic_
{
    public partial class Form6 : Form
    {

        public Form6()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormClosing += Form6_FormClosing;
        }

        private void Form6_Load(object sender, EventArgs e)
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
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false; // Formun kapatılmasını iptal et
                Form3 form3 = new Form3();
                form3.Show(); // Form1'i göster
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
           

            // Önce tüm alanların dolu olup olmadığını kontrol ediyoruz.
            if (lookUpEdit1.EditValue == null ||
                string.IsNullOrEmpty(textEdit1.Text) ||
                string.IsNullOrEmpty(textEdit2.Text) ||
                string.IsNullOrEmpty(textEdit3.Text) ||
                string.IsNullOrEmpty(textEdit4.Text) ||
                comboBoxEdit1.SelectedItem == null)
            {
                // Eğer bir veya daha fazla alan boşsa, kullanıcıya bir hata mesajı gösteriyoruz ve güncelleme işlemini yapmıyoruz.
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Güncelleme işlemi için geri dönüyoruz ve kodun devamını çalıştırmıyoruz.
            }

            string kullaniciadi = lookUpEdit1.Text;
            string yeniadsoyad = textEdit1.Text;
            string yeniusername = textEdit2.Text;
            string yenisifre = textEdit3.Text;
            string yeniemail = textEdit4.Text;
            string yenijob = comboBoxEdit1.Text;

            

            string UpdateQuery = "UPDATE TblUserinfo SET Name = @yeniadsoyad, UserName = @yeniusername, UserPswrd = @yenisifre, UserEmail = @yeniemail, Job = @yenijob WHERE UserName = @kullaniciadi";

            // Create a SqlConnection and SqlCommand
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(UpdateQuery, connection))
            {
                // Set the parameter values
                command.Parameters.AddWithValue("@yeniadsoyad", yeniadsoyad);
                command.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                command.Parameters.AddWithValue("@yeniusername", yeniusername);
                command.Parameters.AddWithValue("@yenisifre", yenisifre);
                command.Parameters.AddWithValue("@yeniemail", yeniemail);
                command.Parameters.AddWithValue("@yenijob", yenijob);

                // Open the database connection
                connection.Open();

                // Execute the INSERT statement
                command.ExecuteNonQuery();

                // Close the database connection
                connection.Close();
            }
            

            DialogResult sonuc;
            sonuc = MessageBox.Show("Kullanıcının bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }



        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        
    }
}