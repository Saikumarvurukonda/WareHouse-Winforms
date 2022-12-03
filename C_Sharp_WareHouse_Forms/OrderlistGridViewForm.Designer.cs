namespace WareHouse_Management
{
    partial class OrderlistGridViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderlistGridViewForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBxProductSearch = new System.Windows.Forms.TextBox();
            this.txtboxClientSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnMakeNewOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxQuantitySearch = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxProductSearch
            // 
            this.txtBxProductSearch.BackColor = System.Drawing.Color.White;
            this.txtBxProductSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxProductSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtBxProductSearch.Location = new System.Drawing.Point(521, 229);
            this.txtBxProductSearch.Name = "txtBxProductSearch";
            this.txtBxProductSearch.Size = new System.Drawing.Size(147, 26);
            this.txtBxProductSearch.TabIndex = 3;
            this.txtBxProductSearch.Text = "Search by Product";
            this.txtBxProductSearch.Enter += new System.EventHandler(this.ClearText);
            this.txtBxProductSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBxProductSearch_KeyUp);
            this.txtBxProductSearch.Leave += new System.EventHandler(this.txtBxProductSearch_Leave);
            // 
            // txtboxClientSearch
            // 
            this.txtboxClientSearch.BackColor = System.Drawing.Color.White;
            this.txtboxClientSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxClientSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtboxClientSearch.Location = new System.Drawing.Point(369, 229);
            this.txtboxClientSearch.Name = "txtboxClientSearch";
            this.txtboxClientSearch.Size = new System.Drawing.Size(147, 26);
            this.txtboxClientSearch.TabIndex = 2;
            this.txtboxClientSearch.Text = "Search by Client";
            this.txtboxClientSearch.Enter += new System.EventHandler(this.ClearText);
            this.txtboxClientSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxClientSearch_KeyUp);
            this.txtboxClientSearch.Leave += new System.EventHandler(this.txtboxClientSearch_Leave);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteOrder.BackgroundImage")));
            this.btnDeleteOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteOrder.Location = new System.Drawing.Point(586, 102);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(82, 89);
            this.btnDeleteOrder.TabIndex = 1;
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMakeNewOrder
            // 
            this.btnMakeNewOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnMakeNewOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMakeNewOrder.BackgroundImage")));
            this.btnMakeNewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMakeNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeNewOrder.FlatAppearance.BorderSize = 0;
            this.btnMakeNewOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMakeNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeNewOrder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeNewOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMakeNewOrder.Location = new System.Drawing.Point(418, 102);
            this.btnMakeNewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeNewOrder.Name = "btnMakeNewOrder";
            this.btnMakeNewOrder.Size = new System.Drawing.Size(98, 89);
            this.btnMakeNewOrder.TabIndex = 0;
            this.btnMakeNewOrder.UseVisualStyleBackColor = false;
            this.btnMakeNewOrder.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(3, 261);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1239, 291);
            this.dataGridView1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 258);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxQuantitySearch
            // 
            this.txtBoxQuantitySearch.BackColor = System.Drawing.Color.White;
            this.txtBoxQuantitySearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxQuantitySearch.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxQuantitySearch.Location = new System.Drawing.Point(827, 229);
            this.txtBoxQuantitySearch.Name = "txtBoxQuantitySearch";
            this.txtBoxQuantitySearch.Size = new System.Drawing.Size(147, 26);
            this.txtBoxQuantitySearch.TabIndex = 5;
            this.txtBoxQuantitySearch.Text = "Search by Quantity";
            this.txtBoxQuantitySearch.Enter += new System.EventHandler(this.ClearText);
            this.txtBoxQuantitySearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxQuantitySearch_KeyUp_1);
            this.txtBoxQuantitySearch.Leave += new System.EventHandler(this.txtBoxQuantitySearch_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(674, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // OrderlistGridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1245, 555);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBxProductSearch);
            this.Controls.Add(this.txtBoxQuantitySearch);
            this.Controls.Add(this.txtboxClientSearch);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnMakeNewOrder);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1261, 594);
            this.MinimumSize = new System.Drawing.Size(1261, 594);
            this.Name = "OrderlistGridViewForm";
            this.Text = "Orders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderlistGridViewForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderlistGridViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxProductSearch;
        private System.Windows.Forms.TextBox txtboxClientSearch;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnMakeNewOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxQuantitySearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}