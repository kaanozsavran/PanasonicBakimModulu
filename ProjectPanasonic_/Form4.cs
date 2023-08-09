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
using static DevExpress.Data.Helpers.SyncHelper.ZombieContextsDetector;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Dapper;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.Xpo.DB.Helpers;

namespace ProjectPanasonic_
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // veya FormBorderStyle.Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormClosing += Form4_FormClosing;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ApplyColorMode(ColorModeHelper.CurrentColorMode);

            // TODO: This line of code loads data into the 'projectPanasonicDataSet.TblJob' table. You can move, or remove it, as needed.
            this.tblJobTableAdapter.Fill(this.projectPanasonicDataSet.TblJob);
            LoadAuthorityOptions();


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
        private void LoadAuthorityOptions()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string authorityQuery = "SELECT DISTINCT Authority FROM TblUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(authorityQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string authority = reader.GetString(0);
                            comboBoxEdit1.Properties.Items.Add(authority);
                        }
                    }
                }
            }
        }
        void simpleButton4_Click(object sender, EventArgs e)
        {
            // Önce tüm alanların dolu olup olmadığını kontrol ediyoruz.
            if (comboBoxEdit1.EditValue == null &&
                string.IsNullOrEmpty(textEdit1.Text) ||
                string.IsNullOrEmpty(textEdit2.Text) ||
                string.IsNullOrEmpty(textEdit3.Text) ||
                string.IsNullOrEmpty(textEdit4.Text) ||
                lookUpEdit1.EditValue == null)
                




            {
                // Eğer bir veya daha fazla alan boşsa, kullanıcıya bir hata mesajı gösteriyoruz ve güncelleme işlemini yapmıyoruz.
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Güncelleme işlemi için geri dönüyoruz ve kodun devamını çalıştırmıyoruz.
            }






            string Namesurname = textEdit1.Text;


            string Username = textEdit2.Text;


            string sifre = textEdit3.Text;


            string mail = textEdit4.Text;


            string DepartmentID = lookUpEdit1.Text;
            int DeptID = int.Parse(DepartmentID);

            string yetki = comboBoxEdit1.Text;

            // Create the INSERT statement
            string insertQuery = "INSERT INTO TblUser (Name, UserName,UserPswrd,UserEmail,DepartmentID,Authority) VALUES (@Namesurname, @Username,@sifre,@mail, @DeptID, @yetki )";

            // Create a SqlConnection and SqlCommand
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                // Set the parameter values
                command.Parameters.AddWithValue("@Namesurname", Namesurname);

                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@sifre", sifre);

                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@DeptID", DeptID);
                command.Parameters.AddWithValue("@yetki", yetki);

                // Open the database connection
                connection.Open();

                // Execute the INSERT statement
                command.ExecuteNonQuery();

                // Close the database connection

            }

            // Show a success message
            string Job = "Select Job from TblJob where DepartmentID=@DeptID";
            string JobName = "";
            using (SqlCommand command = new SqlCommand(Job, connection))
            {
                command.Parameters.AddWithValue("@DeptID", DeptID);
                // Verileri okuma için SqlDataReader nesnesini oluşturun
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Verileri okuyup bir değişkene kaydedin
                    if (reader.Read())
                    {
                        JobName = reader.GetString(0); // Sütun indeksini veya adını kullanarak değeri alın
                                                       // Değişkeninize veriyi kaydedin veya istediğiniz şekilde kullanın
                    }
                }
            }
            string ID = "Select Department from TblJob where DepartmentID=@DeptID";
            string DeptName = "";
            using (SqlCommand command = new SqlCommand(ID, connection))
            {
                command.Parameters.AddWithValue("@DeptID", DeptID);
                // Verileri okuma için SqlDataReader nesnesini oluşturun
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Verileri okuyup bir değişkene kaydedin
                    if (reader.Read())
                    {
                        DeptName = reader.GetString(0); // Sütun indeksini veya adını kullanarak değeri alın
                                                        // Değişkeninize veriyi kaydedin veya istediğiniz şekilde kullanın
                    }
                }
            }


            string IN_TblUserinfo = "INSERT INTO TblUserinfo (Name, UserName,UserPswrd,UserEmail,Department, Job,Authority) VALUES (@Namesurname, @Username,@sifre,@mail, @DeptName, @JobName, @yetki )";



            using (SqlCommand command = new SqlCommand(IN_TblUserinfo, connection))
            {
                // Set the parameter values
                command.Parameters.AddWithValue("@Namesurname", Namesurname);

                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@sifre", sifre);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@DeptName", DeptName);
                command.Parameters.AddWithValue("@JobName", JobName);
                command.Parameters.AddWithValue("@yetki", yetki);


                // Open the database connection


                // Execute the INSERT statement
                command.ExecuteNonQuery();

                // Close the database connection

            }



            DialogResult sonuc;
            sonuc = MessageBox.Show("Yeni kullanıcı eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);




            connection.Close();

            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();


        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();



        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false; // Formun kapatılmasını iptal et
                Form3 form3 = new Form3();
                form3.Show(); // Form1'i göster
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
       
    }
}
    

    
