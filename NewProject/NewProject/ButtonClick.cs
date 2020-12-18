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
    public partial class ButtonClick : Form
    {
        public ButtonClick()
        {
            InitializeComponent();
        }

       

        void addButton()
        {
            string connetionString = "server=DESKTOP-BEP2C2E;database=Logix14db;UID=sa;password=12@_Heci";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (SqlConnection sqlCon = new SqlConnection(connetionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select idn 'ID No', name Kontragent, tel 'Tel No' from sm_kontra", sqlCon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }
        private void ButtonClick_Load(object sender, EventArgs e)
        {
            addButton();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Melumatlar button = new Melumatlar();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                button.button_idn.Text = row.Cells["ID No"].Value.ToString();
                textBox1.Text = row.Cells["ID No"].Value.ToString();
            }
            this.Close();
        }
    }
}
