using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
using static DevExpress.Skins.SolidColorHelper;
using static DevExpress.XtraEditors.Mask.MaskSettings;


namespace ProjectPanasonic_
{
    public partial class Form3 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public Form3()
        {
            InitializeComponent();
           

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // veya FormBorderStyle.Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormClosing += Form3_FormClosing;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            LoadUsers();



            ApplyColorMode(ColorModeHelper.CurrentColorMode);


            ApplyColorMode(ColorModeHelper.CurrentColorMode);


            tblUserinfoBindingSource3.DataSource = this.projectPanasonicDataSet.TblUserinfo;


            // TODO: This line of code loads data into the 'projectPanasonicDataSet.TblJob' table. You can move, or remove it, as needed.
            this.tblJobTableAdapter.Fill(this.projectPanasonicDataSet.TblJob);
            // TODO: This line of code loads data into the 'projectPanasonicDataSet.TblUserinfo' table. You can move, or remove it, as needed.
            this.tblUserinfoTableAdapter.Fill(this.projectPanasonicDataSet.TblUserinfo);

            this.WindowState = FormWindowState.Maximized;


        }
        private void LoadUsers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Name, UserName, UserPswrd, UserEmail, Department,Job, Authority FROM TblUserinfo";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    gridControl1.DataSource = reader;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından kullanıcılar yüklenirken hata oluştu: " + ex.Message);
            }
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

            this.Hide();          
            Form4 f4 = new Form4();
            f4.Show();


        }


        private void gridControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false; // Formun kapatılmasını iptal et
                Form2 form2 = new Form2();
                form2.Show(); // Form1'i göster
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblUserinfoBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tblJobBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tblUserinfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            // Seçili kullanıcıyı al
            string selectedName = Convert.ToString(gridView1.GetFocusedRowCellValue("Name"));
            string selectedUserName = Convert.ToString(gridView1.GetFocusedRowCellValue("UserName"));
            string selectedUserPswrd = Convert.ToString(gridView1.GetFocusedRowCellValue("UserPswrd"));
            string selectedUserEmail = Convert.ToString(gridView1.GetFocusedRowCellValue("UserEmail"));
            string selectedDepartmentID = Convert.ToString(gridView1.GetFocusedRowCellValue("Job"));
            string selectedAuthority = Convert.ToString(gridView1.GetFocusedRowCellValue("Authority"));

            this.Hide();

            // Form7'yi açmak ve kullanıcı bilgilerini taşımak için
            using (var form7 = new Form7(selectedName, selectedUserName, selectedUserPswrd, selectedUserEmail,selectedDepartmentID, selectedAuthority,connectionString))
            {
                
                form7.ShowDialog();
              

                // Form7 kapandığında yapılacak işlemler (isteğe bağlı)
            }
        }
    }
}
