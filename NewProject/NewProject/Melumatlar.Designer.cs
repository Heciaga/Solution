
namespace NewProject
{
    partial class Melumatlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtidn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxkon_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsellprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_idn = new System.Windows.Forms.MaskedTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.sellprice = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkontra = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serial = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtidn,
            this.txtName,
            this.txtkod,
            this.cbxkon_name,
            this.txtprice,
            this.txtsellprice,
            this.Delete});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Azure;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1270, 405);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // txtidn
            // 
            this.txtidn.DataPropertyName = "idn";
            this.txtidn.HeaderText = "No";
            this.txtidn.MinimumWidth = 6;
            this.txtidn.Name = "txtidn";
            this.txtidn.ReadOnly = true;
            this.txtidn.Width = 125;
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtName.DataPropertyName = "name";
            this.txtName.HeaderText = "Mal Adi";
            this.txtName.MinimumWidth = 6;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // txtkod
            // 
            this.txtkod.DataPropertyName = "serial";
            this.txtkod.HeaderText = "Kod";
            this.txtkod.MinimumWidth = 6;
            this.txtkod.Name = "txtkod";
            this.txtkod.ReadOnly = true;
            this.txtkod.Width = 125;
            // 
            // cbxkon_name
            // 
            this.cbxkon_name.DataPropertyName = "kontra";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.cbxkon_name.DefaultCellStyle = dataGridViewCellStyle11;
            this.cbxkon_name.HeaderText = "Kontragent";
            this.cbxkon_name.MinimumWidth = 6;
            this.cbxkon_name.Name = "cbxkon_name";
            this.cbxkon_name.ReadOnly = true;
            this.cbxkon_name.Width = 125;
            // 
            // txtprice
            // 
            this.txtprice.DataPropertyName = "price";
            this.txtprice.HeaderText = "Maya Qiymeti";
            this.txtprice.MinimumWidth = 6;
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtprice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtprice.Width = 125;
            // 
            // txtsellprice
            // 
            this.txtsellprice.DataPropertyName = "sellprice1";
            this.txtsellprice.HeaderText = "Satis Qiymeti";
            this.txtsellprice.MinimumWidth = 6;
            this.txtsellprice.Name = "txtsellprice";
            this.txtsellprice.ReadOnly = true;
            this.txtsellprice.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 45);
            this.panel1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Image = global::NewProject.Properties.Resources.edit1;
            this.button4.Location = new System.Drawing.Point(108, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 41);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Image = global::NewProject.Properties.Resources.download;
            this.button2.Location = new System.Drawing.Point(155, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 38);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Image = global::NewProject.Properties.Resources.download2;
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 38);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Image = global::NewProject.Properties.Resources.new3;
            this.button3.Location = new System.Drawing.Point(64, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 38);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 460);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(924, 414);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 41);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button_idn);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.sellprice);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.price);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtkontra);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.serial);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.name);
            this.panel3.Location = new System.Drawing.Point(12, 518);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1275, 214);
            this.panel3.TabIndex = 10;
            // 
            // button_idn
            // 
            this.button_idn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button_idn.Location = new System.Drawing.Point(372, 104);
            this.button_idn.Name = "button_idn";
            this.button_idn.Size = new System.Drawing.Size(43, 22);
            this.button_idn.TabIndex = 11;
            this.button_idn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_idn.TextChanged += new System.EventHandler(this.button_idn_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(413, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 27);
            this.button5.TabIndex = 10;
            this.button5.Text = "...\r\n";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sellprice
            // 
            this.sellprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellprice.Location = new System.Drawing.Point(643, 58);
            this.sellprice.Name = "sellprice";
            this.sellprice.Size = new System.Drawing.Size(123, 22);
            this.sellprice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Satis Qiymeti :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maya Qiymeti :";
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Location = new System.Drawing.Point(643, 19);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(123, 22);
            this.price.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kontragent :";
            // 
            // txtkontra
            // 
            this.txtkontra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkontra.Location = new System.Drawing.Point(145, 104);
            this.txtkontra.Name = "txtkontra";
            this.txtkontra.Size = new System.Drawing.Size(270, 22);
            this.txtkontra.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Malin Kodu :";
            // 
            // serial
            // 
            this.serial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serial.Location = new System.Drawing.Point(145, 58);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(305, 22);
            this.serial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Malin Adi :";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(145, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(305, 22);
            this.name.TabIndex = 0;
            // 
            // Melumatlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Melumatlar";
            this.Text = "Melumatlar";
            this.Load += new System.EventHandler(this.Melumatlar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtkontra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox serial;
        private System.Windows.Forms.MaskedTextBox sellprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox price;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.MaskedTextBox button_idn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtidn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtkod;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxkon_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtsellprice;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}