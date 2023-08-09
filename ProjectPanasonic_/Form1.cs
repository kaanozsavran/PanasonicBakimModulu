using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DevExpress.DirectX.Common.Direct2D;

namespace ProjectPanasonic_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // veya FormBorderStyle.Fixed3D
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textEdit2.Properties.PasswordChar = '*';

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            
           
            }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "Select Authority from TblUser Where UserName = @UserName and UserPswrd = @UserPswrd";

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@UserName", textEdit1.Text.Trim());
            command.Parameters.AddWithValue("@UserPswrd", textEdit2.Text.Trim());

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                string yetki = reader.GetString(0);
                if (yetki=="User") 
                {

                  Form2 form2 = new Form2();    
                  form2.kullanıcıTanımlamalarıToolStripMenuItem.Visible= false;
                    form2.rolDüzenlemeToolStripMenuItem.Visible= false;
                  form2.Show();
                }
                else
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                    connection.Close();
                    //this.Close();
                }



                
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }






        }
    }
    }

