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

namespace NewProject
{


    public partial class Login : Form
    {
       

        public Login()
        {
            InitializeComponent();
            
        }

        private void sign_btn_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;

            string connetionString;
            SqlConnection cnn;
            connetionString = "server=DESKTOP-BEP2C2E;database=Logix14db;UID=sa;password=12@_Heci";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Login yoxlanisi
            var from2 = new Form2();
            DateTime time = new DateTime();
            time = DateTime.Now;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("Select count (*) from users where name=@name and pass=@pass", cnn);
            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@name", textBox1.Text);
            myCommand.Parameters.AddWithValue("@pass", textBox2.Text);
            

            if (myCommand.ExecuteScalar().ToString() == "1")
            {
                this.timer1.Start();
                this.progressBar1.Visible = true;
                MessageBox.Show("Giriş Uğurlu");
                

                using (Form2 f2 = new Form2())
                {
                    this.Hide();
                    f2.Text = "User : "+textBox1.Text;
                    f2.ShowDialog();

                    cnn.Close();

                   
                }
            }
           
          else
                {
                    MessageBox.Show("Yanlış İstifadəçi adı və ya Şifrə", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //and whatever you have to retrieve
            

            //MessageBox.Show("(myReader["Name"].ToString())");




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sign_btn_Click(this, new EventArgs());
                //textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

       
    }

 }

