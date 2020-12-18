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
    public partial class Melumatlar : Form
    {
        string connetionString = "server=DESKTOP-BEP2C2E;database=Logix14db;UID=sa;password=12@_Heci";
        
        public Melumatlar()
        {
            InitializeComponent();
        }
        
        void PopulationComcobox() // datagriddeki combobox a datalarin getriilmesi
        {
            using (SqlConnection sqlCon = new SqlConnection(connetionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select idn,name from sm_kontra", sqlCon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                cbxkon_name.ValueMember = "idn";
                cbxkon_name.DisplayMember = "name";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "--Select--";

                dtbl.Rows.InsertAt(topItem, 0);
                cbxkon_name.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        void populateDatagridview()
        {
            using (SqlConnection sqlCon = new SqlConnection(connetionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select idn, name, serial, kontra, price, sellprice1 from sm_goods", sqlCon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                /*---------------Sum deyerin getirilmesi------Sahil style------*/
                SqlCommand Comm1 = new SqlCommand("select sum(sellprice1) from sm_goods", sqlCon);
                SqlDataReader DR1 = Comm1.ExecuteReader();
                    if (DR1.Read())
                    {
                        textBox1.Text = DR1.GetValue(0).ToString();
                    }
                panel2.Visible = true;
                sqlCon.Close();
            }
        }



        private void Melumatlar_Load_1(object sender, EventArgs e)
        {
            PopulationComcobox();
            populateDatagridview();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(connetionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("MallarinsertOredit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtidn"].Value == DBNull.Value)
                    {
                        sqlCmd.Parameters.AddWithValue("@mal_idn", 0);
                    }
                    else
                    sqlCmd.Parameters.AddWithValue("@mal_idn", Convert.ToInt32(dgvRow.Cells["txtidn"].Value));
                    sqlCmd.Parameters.AddWithValue("@name", dgvRow.Cells["txtName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtName"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@serial", dgvRow.Cells["txtkod"].Value == DBNull.Value ? "" : dgvRow.Cells["txtkod"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@kontra", Convert.ToInt32(dgvRow.Cells["cbxkon_name"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbxkon_name"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@price", Convert.ToDecimal(dgvRow.Cells["txtprice"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtprice"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@sellprice", Convert.ToDecimal(dgvRow.Cells["txtsellprice"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtsellprice"].Value.ToString()));
                    sqlCmd.ExecuteNonQuery();
                      populateDatagridview();
                              sqlCon.Close();
                }
            }
        }

   

        private void button2_Click_1(object sender, EventArgs e)
        {
            //dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 2;
            //dataGridView1.Rows[dataGridView1.Rows.Count - 2].Selected = true;
            
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1];
                }
                catch (IndexOutOfRangeException)
                { }
                catch (ArgumentOutOfRangeException)
                { }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.FirstDisplayedScrollingRowIndex = 0;
            //dataGridView1.Rows[0].Selected = true;
            
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    dataGridView1.Rows[0].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
                    
                }
                catch (IndexOutOfRangeException)
                { }
                catch (ArgumentOutOfRangeException)
                { }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            if (dataGridView1.Rows.Count > 0)
            {
                
                try
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Selected = true;
                    dataGridView1.BeginEdit(true);
                }
                catch (IndexOutOfRangeException)
                { }
                catch (ArgumentOutOfRangeException)
                { }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }
       
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(connetionString))
            { 
                        if (e.RowIndex >= 0)
                            {
                                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                                name.Text = row.Cells["txtName"].Value.ToString();
                                serial.Text = row.Cells["txtkod"].Value.ToString();
                                button_idn.Text = row.Cells["cbxkon_name"].Value.ToString();
                                price.Text = row.Cells["txtprice"].Value.ToString();
                                sellprice.Text = row.Cells["txtsellprice"].Value.ToString();
                                sqlCon.Open();
                                if (button_idn.Text != "")
                                {
                                    button_idn_TextChanged(sender,e);
                                }
                            }
                sqlCon.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonClick menu = new ButtonClick();
                        menu.ShowDialog();
            button_idn.Text = menu.textBox1.Text;
        }

        private void button_idn_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connetionString))
            {
                    sqlCon.Open();
                    if (button_idn.Text != "")
                    {
                        SqlCommand Comm1 = new SqlCommand("select name from sm_kontra where idn= @idn", sqlCon);
                        Comm1.Parameters.AddWithValue("@idn", int.Parse(button_idn.Text));
                        SqlDataReader DR1 = Comm1.ExecuteReader();
                        if (DR1.Read())
                        {
                            txtkontra.Text = DR1.GetValue(0).ToString();
                        }
                    }
                
                sqlCon.Close();
            }
        }
    }
}
