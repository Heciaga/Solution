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

        void PopulationComcobox()
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

                /*---------------Sum deyerin getirilmesi------Haci style------*/

                /*
                textBox1.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()));
                }*/
            }
        }



        private void Melumatlar_Load_1(object sender, EventArgs e)
        {
            PopulationComcobox();
            populateDatagridview();
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
                    /*
                    foreach (DataGridViewRow rw in this.dataGridView1.Rows)
                    {
                        for (int i = 0; i < rw.Cells.Count; i++)
                        {
                            if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                            {
                                MessageBox.Show(rw.Cells[i].ColumnIndex + "Xana bos ola bilmez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    //}*/

                    sqlCmd.ExecuteNonQuery();
                      populateDatagridview();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Silmek istediyinizden Eminsiniz??", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connetionString))
                    {
                        sqlCon.Open();
                        DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                        SqlCommand sqlCmd = new SqlCommand("MallarDelete", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mal_idn", Convert.ToInt32(dgvRow.Cells["txtidn"].Value));
                        sqlCmd.ExecuteNonQuery();
                        populateDatagridview();
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
    }
}
