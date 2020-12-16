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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void melumatlar_Click(object sender, EventArgs e)
        {







            /*Form3 menu = new Form3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, Visible = true };*/

            Melumatlar menu = new Melumatlar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, Visible = true };

            menu.FormBorderStyle = (FormBorderStyle)comboBox1.SelectedIndex;
            this.panel3.Controls.Add(menu);
            menu.Text = "Mallar";
            menu.Show();
            
            /*
            string connetionString;
            SqlConnection cnn;
            connetionString = "server=DESKTOP-BEP2C2E;database=Logix14db;UID=sa;password=12@_Heci";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select idn No,serial kod,barcode, name 'Mal adi',price 'maya qiyymeti' from sm_goods", cnn);
            DataSet ds = new DataSet();
            sd.Fill(ds, "sm_goods");
            menu.dataGridView1.Visible = true;
            menu.dataGridView1.DataSource = ds.Tables[0];
            cnn.Close();
            */


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result != DialogResult.No)
            {
                
            }
            */
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
