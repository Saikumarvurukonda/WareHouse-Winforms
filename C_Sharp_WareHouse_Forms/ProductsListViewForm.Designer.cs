namespace WareHouse_Management
{
    partial class ProductsDataGridtViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsDataGridtViewForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pnlUpdatePRD = new System.Windows.Forms.Panel();
            this.richTxtBxAddrUpd = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numrcUpDwnPrice = new System.Windows.Forms.NumericUpDown();
            this.btnCanXUpd = new System.Windows.Forms.Button();
            this.txtBxNameUpd = new System.Windows.Forms.TextBox();
            this.btnSaveUpd = new System.Windows.Forms.Button();
            this.lbl4Upd = new System.Windows.Forms.Label();
            this.lbl3Upd = new System.Windows.Forms.Label();
            this.lbl2Upd = new System.Windows.Forms.Label();
            this.lbl1Upd = new System.Windows.Forms.Label();
            this.btnUpdatePRD = new System.Windows.Forms.Button();
            this.btnDeletePRD = new System.Windows.Forms.Button();
            this.btnAddPRD = new System.Windows.Forms.Button();
            this.dataGridViewPRD = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUpdatePRD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrcUpDwnPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(279, 184);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(256, 26);
            this.textBoxSearch.TabIndex = 11;
            this.textBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyUp);
            // 
            // pnlUpdatePRD
            // 
            this.pnlUpdatePRD.BackColor = System.Drawing.Color.Transparent;
            this.pnlUpdatePRD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpdatePRD.Controls.Add(this.richTxtBxAddrUpd);
            this.pnlUpdatePRD.Controls.Add(this.numericUpDown1);
            this.pnlUpdatePRD.Controls.Add(this.numrcUpDwnPrice);
            this.pnlUpdatePRD.Controls.Add(this.btnCanXUpd);
            this.pnlUpdatePRD.Controls.Add(this.txtBxNameUpd);
            this.pnlUpdatePRD.Controls.Add(this.btnSaveUpd);
            this.pnlUpdatePRD.Controls.Add(this.lbl4Upd);
            this.pnlUpdatePRD.Controls.Add(this.lbl3Upd);
            this.pnlUpdatePRD.Controls.Add(this.lbl2Upd);
            this.pnlUpdatePRD.Controls.Add(this.lbl1Upd);
            this.pnlUpdatePRD.Location = new System.Drawing.Point(662, 55);
            this.pnlUpdatePRD.Name = "pnlUpdatePRD";
            this.pnlUpdatePRD.Size = new System.Drawing.Size(572, 155);
            this.pnlUpdatePRD.TabIndex = 32;
            this.pnlUpdatePRD.Visible = false;
            // 
            // richTxtBxAddrUpd
            // 
            this.richTxtBxAddrUpd.BackColor = System.Drawing.Color.White;
            this.richTxtBxAddrUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTxtBxAddrUpd.Location = new System.Drawing.Point(357, 9);
            this.richTxtBxAddrUpd.Name = "richTxtBxAddrUpd";
            this.richTxtBxAddrUpd.Size = new System.Drawing.Size(189, 104);
            this.richTxtBxAddrUpd.TabIndex = 24;
            this.richTxtBxAddrUpd.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(78, 87);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(189, 26);
            this.numericUpDown1.TabIndex = 23;
            // 
            // numrcUpDwnPrice
            // 
            this.numrcUpDwnPrice.BackColor = System.Drawing.Color.White;
            this.numrcUpDwnPrice.DecimalPlaces = 2;
            this.numrcUpDwnPrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numrcUpDwnPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numrcUpDwnPrice.Location = new System.Drawing.Point(77, 48);
            this.numrcUpDwnPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numrcUpDwnPrice.Name = "numrcUpDwnPrice";
            this.numrcUpDwnPrice.Size = new System.Drawing.Size(189, 26);
            this.numrcUpDwnPrice.TabIndex = 23;
            // 
            // btnCanXUpd
            // 
            this.btnCanXUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCanXUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanXUpd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanXUpd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanXUpd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCanXUpd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCanXUpd.Location = new System.Drawing.Point(315, 119);
            this.btnCanXUpd.Name = "btnCanXUpd";
            this.btnCanXUpd.Size = new System.Drawing.Size(94, 27);
            this.btnCanXUpd.TabIndex = 21;
            this.btnCanXUpd.Text = "Cancel";
            this.btnCanXUpd.UseVisualStyleBackColor = false;
            this.btnCanXUpd.Click += new System.EventHandler(this.btnCanXUpd_Click);
            // 
            // txtBxNameUpd
            // 
            this.txtBxNameUpd.BackColor = System.Drawing.Color.White;
            this.txtBxNameUpd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxNameUpd.Location = new System.Drawing.Point(77, 10);
            this.txtBxNameUpd.Name = "txtBxNameUpd";
            this.txtBxNameUpd.Size = new System.Drawing.Size(189, 26);
            this.txtBxNameUpd.TabIndex = 11;
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.BackColor = System.Drawing.Color.Green;
            this.btnSaveUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUpd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveUpd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveUpd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveUpd.Location = new System.Drawing.Point(132, 119);
            this.btnSaveUpd.Name = "btnSaveUpd";
            this.btnSaveUpd.Size = new System.Drawing.Size(94, 27);
            this.btnSaveUpd.TabIndex = 20;
            this.btnSaveUpd.Text = "Save";
            this.btnSaveUpd.UseVisualStyleBackColor = false;
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // lbl4Upd
            // 
            this.lbl4Upd.AutoSize = true;
            this.lbl4Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl4Upd.ForeColor = System.Drawing.Color.White;
            this.lbl4Upd.Location = new System.Drawing.Point(272, 13);
            this.lbl4Upd.Name = "lbl4Upd";
            this.lbl4Upd.Size = new System.Drawing.Size(79, 18);
            this.lbl4Upd.TabIndex = 15;
            this.lbl4Upd.Text = "Description";
            // 
            // lbl3Upd
            // 
            this.lbl3Upd.AutoSize = true;
            this.lbl3Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3Upd.ForeColor = System.Drawing.Color.White;
            this.lbl3Upd.Location = new System.Drawing.Point(10, 89);
            this.lbl3Upd.Name = "lbl3Upd";
            this.lbl3Upd.Size = new System.Drawing.Size(62, 18);
            this.lbl3Upd.TabIndex = 16;
            this.lbl3Upd.Text = "Quantity";
            // 
            // lbl2Upd
            // 
            this.lbl2Upd.AutoSize = true;
            this.lbl2Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2Upd.ForeColor = System.Drawing.Color.White;
            this.lbl2Upd.Location = new System.Drawing.Point(27, 50);
            this.lbl2Upd.Name = "lbl2Upd";
            this.lbl2Upd.Size = new System.Drawing.Size(39, 18);
            this.lbl2Upd.TabIndex = 17;
            this.lbl2Upd.Text = "Price";
            // 
            // lbl1Upd
            // 
            this.lbl1Upd.AutoSize = true;
            this.lbl1Upd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1Upd.ForeColor = System.Drawing.Color.White;
            this.lbl1Upd.Location = new System.Drawing.Point(10, 12);
            this.lbl1Upd.Name = "lbl1Upd";
            this.lbl1Upd.Size = new System.Drawing.Size(45, 18);
            this.lbl1Upd.TabIndex = 10;
            this.lbl1Upd.Text = "Name";
            // 
            // btnUpdatePRD
            // 
            this.btnUpdatePRD.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdatePRD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdatePRD.BackgroundImage")));
            this.btnUpdatePRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdatePRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePRD.FlatAppearance.BorderSize = 0;
            this.btnUpdatePRD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdatePRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePRD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdatePRD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdatePRD.Location = new System.Drawing.Point(455, 86);
            this.btnUpdatePRD.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePRD.Name = "btnUpdatePRD";
            this.btnUpdatePRD.Size = new System.Drawing.Size(80, 61);
            this.btnUpdatePRD.TabIndex = 29;
            this.btnUpdatePRD.UseVisualStyleBackColor = false;
            this.btnUpdatePRD.Click += new System.EventHandler(this.btnUpdatePRD_Click);
            // 
            // btnDeletePRD
            // 
            this.btnDeletePRD.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletePRD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePRD.BackgroundImage")));
            this.btnDeletePRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeletePRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePRD.FlatAppearance.BorderSize = 0;
            this.btnDeletePRD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeletePRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePRD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeletePRD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeletePRD.Location = new System.Drawing.Point(367, 86);
            this.btnDeletePRD.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePRD.Name = "btnDeletePRD";
            this.btnDeletePRD.Size = new System.Drawing.Size(80, 61);
            this.btnDeletePRD.TabIndex = 30;
            this.btnDeletePRD.UseVisualStyleBackColor = false;
            this.btnDeletePRD.Click += new System.EventHandler(this.btnDeletePRD_Click);
            // 
            // btnAddPRD
            // 
            this.btnAddPRD.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPRD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPRD.BackgroundImage")));
            this.btnAddPRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPRD.FlatAppearance.BorderSize = 0;
            this.btnAddPRD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddPRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPRD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPRD.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddPRD.Location = new System.Drawing.Point(279, 86);
            this.btnAddPRD.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPRD.Name = "btnAddPRD";
            this.btnAddPRD.Size = new System.Drawing.Size(80, 61);
            this.btnAddPRD.TabIndex = 31;
            this.btnAddPRD.UseVisualStyleBackColor = false;
            this.btnAddPRD.Click += new System.EventHandler(this.btnAddPRD_Click);
            // 
            // dataGridViewPRD
            // 
            this.dataGridViewPRD.AllowUserToAddRows = false;
            this.dataGridViewPRD.AllowUserToDeleteRows = false;
            this.dataGridViewPRD.AllowUserToOrderColumns = true;
            this.dataGridViewPRD.AllowUserToResizeRows = false;
            this.dataGridViewPRD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPRD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPRD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewPRD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPRD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPRD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPRD.Location = new System.Drawing.Point(3, 216);
            this.dataGridViewPRD.MultiSelect = false;
            this.dataGridViewPRD.Name = "dataGridViewPRD";
            this.dataGridViewPRD.ReadOnly = true;
            this.dataGridViewPRD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPRD.Size = new System.Drawing.Size(1240, 375);
            this.dataGridViewPRD.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 235);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(279, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Search";
            // 
            // ProductsDataGridtViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1262, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewPRD);
            this.Controls.Add(this.pnlUpdatePRD);
            this.Controls.Add(this.btnUpdatePRD);
            this.Controls.Add(this.btnDeletePRD);
            this.Controls.Add(this.btnAddPRD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1262, 631);
            this.MinimumSize = new System.Drawing.Size(1262, 631);
            this.Name = "ProductsDataGridtViewForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsDataGridtViewForm_Load);
            this.pnlUpdatePRD.ResumeLayout(false);
            this.pnlUpdatePRD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrcUpDwnPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel pnlUpdatePRD;
        private System.Windows.Forms.Button btnCanXUpd;
        private System.Windows.Forms.TextBox txtBxNameUpd;
        private System.Windows.Forms.Button btnSaveUpd;
        private System.Windows.Forms.Label lbl4Upd;
        private System.Windows.Forms.Label lbl3Upd;
        private System.Windows.Forms.Label lbl2Upd;
        private System.Windows.Forms.Label lbl1Upd;
        private System.Windows.Forms.Button btnUpdatePRD;
        private System.Windows.Forms.Button btnDeletePRD;
        private System.Windows.Forms.Button btnAddPRD;
        private System.Windows.Forms.DataGridView dataGridViewPRD;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numrcUpDwnPrice;
        private System.Windows.Forms.RichTextBox richTxtBxAddrUpd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}