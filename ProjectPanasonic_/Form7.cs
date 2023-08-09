using DevExpress.XtraEditors;
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
    public partial class Form7 : Form
    {
        private string selectedName;
        private string selectedUserName;
        private string selectedUserPswrd;
        private string selectedUserEmail;
        private string selectedDepartmentID;
        private string selectedAuthority;
        private string selectedDepartment;
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public Form7(string Name,string UserName, string UserPswrd, string UserEmail, string DepartmentID, string Authority, string connectionString)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormClosing += Form7_FormClosing;

            selectedName = Name;
            selectedUserName = UserName;
            selectedUserPswrd = UserPswrd;
            selectedUserEmail = UserEmail;
            selectedDepartmentID = DepartmentID;
            selectedAuthority = Authority;

            this.connectionString = connectionString;

            // Veritabanından kullanıcı bilgilerini yükleyin ve TextEdit alanlarına doldurun
            LoadUserData();

        }
        private void LoadUserData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Name, UserName, UserPswrd, UserEmail,Department, Job,Authority FROM TblUserinfo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", selectedName);
                    command.Parameters.AddWithValue("@UserName", selectedUserName);
                    command.Parameters.AddWithValue("@UserPswrd", selectedUserPswrd);
                    command.Parameters.AddWithValue("@UserEmail", selectedUserEmail);
                    command.Parameters.AddWithValue("@Job", selectedDepartmentID);
                    command.Parameters.AddWithValue("@Authority", selectedAuthority);


                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                   
                        reader.Read();
                        textEdit1.Text = selectedName;

                        textEdit2.Text = selectedUserName;

                        textEdit3.Text = selectedUserPswrd;

                        textEdit4.Text = selectedUserEmail;

                    comboBoxEdit1.Text = selectedDepartmentID;

                        comboBoxEdit2.Text = selectedAuthority;

                    
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı bilgileri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            ApplyColorMode(ColorModeHelper.CurrentColorMode);

            // TODO: This line of code loads data into the 'projectPanasonicDataSet.TblJob' table. You can move, or remove it, as needed.
            // this.tblJobTableAdapter.Fill(this.projectPanasonicDataSet.TblJob);

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string yeniadsoyad = textEdit1.Text;
            string yeniusername = textEdit2.Text;
            string yenisifre = textEdit3.Text;
            string yeniemail = textEdit4.Text;
            string yenijob = comboBoxEdit1.Text;
            string yeniyetki = comboBoxEdit2.Text;
          


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string UpdateQuery = "UPDATE TblUserinfo SET Name = @yeniadsoyad,UserName = @yeniusername, UserPswrd = @yenisifre, UserEmail = @yeniemail, Job = @yenijob, Authority = @yeniyetki where UserName = @yeniusername ";
                string UpdateQuery1 = "UPDATE TblUser SET Name = @yeniadsoyad,UserName = @yeniusername, UserPswrd = @yenisifre, UserEmail = @yeniemail, Authority = @yeniyetki where UserName = @yeniusername ";
                using (SqlCommand command1 = new SqlCommand(UpdateQuery1, connection))
                {
                    // Set the parameter values
                    command1.Parameters.AddWithValue("@yeniadsoyad", yeniadsoyad);
                    command1.Parameters.AddWithValue("@yenisifre", yenisifre);
                    command1.Parameters.AddWithValue("@yeniemail", yeniemail);
                    command1.Parameters.AddWithValue("@yeniyetki", yeniyetki);
                    command1.Parameters.AddWithValue("@yeniusername", yeniusername);


                    // Execute the UPDATE statement
                  command1.ExecuteNonQuery();
                    

                }
                    using (SqlCommand command = new SqlCommand(UpdateQuery, connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@yeniadsoyad", yeniadsoyad);
                    command.Parameters.AddWithValue("@yenisifre", yenisifre);
                    command.Parameters.AddWithValue("@yeniemail", yeniemail);
                    command.Parameters.AddWithValue("@yenijob", yenijob);
                    command.Parameters.AddWithValue("@yeniyetki", yeniyetki);
                    command.Parameters.AddWithValue("@yeniusername", yeniusername);
                  

                    // Execute the UPDATE statement
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kullanıcının bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme işlemi başarısız oldu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }


            //DialogResult sonuc;
            //sonuc = MessageBox.Show("Kullanıcının bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false; // Formun kapatılmasını iptal et
                Form3 form3 = new Form3();
                form3.Show(); // Form1'i göster
            }
        }
    }
    }
    

