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
        }

        private void melumatlar_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "server=DESKTOP-BEP2C2E;database=Logix14db;UID=sa;password=12@_Heci";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select idn No,serial kod, name 'Mal adi',price 'maya qiyymeti' from sm_goods", cnn);
            DataSet ds = new DataSet();
            sd.Fill(ds, "sm_goods");
            dataGridView1.Visible = true;
            dataGridView1.DataSource = ds.Tables[0];

            cnn.Close();
        }
    }
}
