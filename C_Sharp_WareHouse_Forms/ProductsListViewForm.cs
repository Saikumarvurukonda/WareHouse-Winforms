using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouse_Management
{
    public partial class ProductsDataGridtViewForm : Form
    {
        Containers container;
        ProductAdding AddingProductForm;

        public ProductsDataGridtViewForm(Containers cont)
        {
            InitializeComponent();
            container = cont;
            container.ProductsUpdate += UpdateProductDataGrid;
        }

        private void UpdateProductDataGrid()
        {
            DataTable table = CustomerDataGridView.ConvertToDataTable(Containers.ProductList);
            dataGridViewPRD.DataSource = table;
        }

        private void btnAddPRD_Click(object sender, EventArgs e)
        {
            if (AddingProductForm == null)
            {
                AddingProductForm = new ProductAdding(container);
                AddingProductForm.StartPosition = FormStartPosition.CenterParent;
                AddingProductForm.FormClosed += AddingProductForm_FormClosed;
                AddingProductForm.Show();
            }
            else
                AddingProductForm.Activate();
        }

        private void AddingProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddingProductForm = null;
        }

        private void ProductsDataGridtViewForm_Load(object sender, EventArgs e)
        {
            DataTable table = CustomerDataGridView.ConvertToDataTable(Containers.ProductList);
            dataGridViewPRD.DataSource = table;
        }

        private void btnDeletePRD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPRD.SelectedRows is null || dataGridViewPRD.SelectedRows[0].Cells[0].Value == null)
                    throw new Exception("No any element to remove");
                int id = Convert.ToInt32(dataGridViewPRD.SelectedRows[0].Cells[0].Value);
                if (MessageBox.Show("Are you sure to remove selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    container.DeleteProduct(id);
                    MessageBox.Show("Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            catch
            {
                MessageBox.Show("No any product selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatePRD_Click(object sender, EventArgs e)
        {
            try
            {
                pnlUpdatePRD.Visible = true;
                txtBxNameUpd.Text = dataGridViewPRD.SelectedRows[0].Cells[1].Value.ToString();
                numrcUpDwnPrice.Text = dataGridViewPRD.SelectedRows[0].Cells[2].Value.ToString();
                numericUpDown1.Text = dataGridViewPRD.SelectedRows[0].Cells[3].Value.ToString();
                richTxtBxAddrUpd.Text = dataGridViewPRD.SelectedRows[0].Cells[4].Value.ToString();
                dataGridViewPRD.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose any Product", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                pnlUpdatePRD.Visible = false;
            }
        }

        private void btnCanXUpd_Click(object sender, EventArgs e)
        {
            dataGridViewPRD.Enabled = true;
            pnlUpdatePRD.Visible = false;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBxNameUpd.Text))
                    throw new Exception("Please fill all rows");
                if (numericUpDown1.Value <= 0)
                    throw new Exception("Quantity can not be 0 (zero)");
                if (numrcUpDwnPrice.Value <= 0)
                    throw new Exception("Price has not been set");
                int index = Convert.ToInt32(dataGridViewPRD.SelectedRows[0].Cells[0].Value);
                container.UpdateProduct(index, txtBxNameUpd.Text, numrcUpDwnPrice.Value,
                    (int)numericUpDown1.Value, richTxtBxAddrUpd.Text);
                MessageBox.Show("Successfully Updated", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewPRD.Enabled = true;
                pnlUpdatePRD.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string keyword = textBoxSearch.Text;
            var matchedItems = (!int.TryParse(keyword, out int digit)?
                    Containers.ProductList.FindAll(item => item.ArticleName.IndexOf
                    (keyword, 0, StringComparison.OrdinalIgnoreCase) == 0 || item.Description.IndexOf
                    (keyword, 0, StringComparison.OrdinalIgnoreCase) == 0).ToList() :
                    Containers.ProductList.FindAll(item => item.UniqueID == Convert.ToInt32(keyword)).ToList());
            DataTable table = CustomerDataGridView.ConvertToDataTable(matchedItems);
            dataGridViewPRD.DataSource = table;

        }
    }
}
