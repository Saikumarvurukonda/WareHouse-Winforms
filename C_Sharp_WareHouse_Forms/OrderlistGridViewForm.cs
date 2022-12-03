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
    public partial class OrderlistGridViewForm : Form
    {
        Containers container = null;
        OrderAdding addingOrderForm = null;

        public OrderlistGridViewForm(Containers cont)
        {
            InitializeComponent();
            container = cont;
            container.OrdersUpdate += UpdateDataGrid;
        }

        private void OrderlistGridViewForm_Load(object sender, EventArgs e)
        {
            DataTable table = ConvertToDataTable();
            dataGridView1.DataSource = table;
        }

        private void UpdateDataGrid()
        {
            DataTable table = ConvertToDataTable();
            dataGridView1.DataSource = table;
        }

        private void OrderlistGridViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (addingOrderForm == null)
            {
                addingOrderForm = new OrderAdding(container);
                addingOrderForm.StartPosition = FormStartPosition.CenterParent;
                addingOrderForm.FormClosed += AddingOrderForm_FormClosed;
                addingOrderForm.ShowDialog();
            }
            else
                addingOrderForm.Activate();
        }

        private void AddingOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addingOrderForm = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows is null || dataGridView1.SelectedRows[0].Cells[0].Value == null)
                    throw new Exception("No any element to remove");
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                if (MessageBox.Show("Are you sure to remove selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    container.DeleteOrder(id);
                    MessageBox.Show("Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            catch
            {
                MessageBox.Show("No any Order Selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ConvertToDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("Order ID", typeof(int)));
            table.Columns.Add(new DataColumn("Client", typeof(Customer)));
            table.Columns.Add(new DataColumn("Product ID", typeof(Product)));
            table.Columns.Add(new DataColumn("Quantity", typeof(int)));
            table.Columns.Add(new DataColumn("Ordered Time", typeof(DateTime)));
            table.Columns.Add(new DataColumn("Order Status", typeof(OrderStatus)));
            var list = Containers.OrderList;
            foreach (Order item in list)
            {
                DataRow row = table.NewRow();
                row["Order ID"] = item.OrderID;
                row["Client"] = item.Client;
                row["Product ID"] = item.Product;
                row["Quantity"] = item.Quantity;
                row["Ordered Time"] = item.OrderedTime.ToShortDateString();
                row["Order Status"] = item.Status;
                table.Rows.Add(row);
            }
            return table;
        }

        private void txtboxClientSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string keyword = txtboxClientSearch.Text;
                var matchedItems = (!int.TryParse(keyword, out int digit)) ?
                    Containers.OrderList.FindAll(item => item.Client.FirstName.IndexOf
                (keyword, 0, StringComparison.OrdinalIgnoreCase) == 0 || item.Client.LastName.IndexOf
                (keyword, 0, StringComparison.OrdinalIgnoreCase) == 0).ToList() :
                throw new Exception("Please type only letters");
                DataTable table = CustomerDataGridView.ConvertToDataTable(matchedItems);
                dataGridView1.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ClearText(object sender, EventArgs e)
        {
            var txtBxSearch = (sender as TextBox);
            if (txtBxSearch.Text.Contains("Search by "))
            {
                txtBxSearch.Text = "";
                txtBxSearch.ForeColor = Color.Black;
            }
        }

        private void txtboxClientSearch_Leave(object sender, EventArgs e)
        {
            if (txtboxClientSearch.Text == "")
            {
                txtboxClientSearch.ForeColor = Color.Silver;
                txtboxClientSearch.Text = "Search by Client";
            }
        }

        private void txtBxProductSearch_Leave(object sender, EventArgs e)
        {
            if (txtBxProductSearch.Text == "")
            {
                txtBxProductSearch.ForeColor = Color.Silver;
                txtBxProductSearch.Text = "Search by Product";
            }
        }

        private void txtBoxQuantitySearch_Leave(object sender, EventArgs e)
        {
            if (txtBoxQuantitySearch.Text == "")
            {
                txtBoxQuantitySearch.ForeColor = Color.Silver;
                txtBoxQuantitySearch.Text = "Search by Quantity";
            }
        }

        private void txtBxProductSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string keyword = txtBxProductSearch.Text;
            var matchedItems = Containers.OrderList.FindAll(item => item.Product.ArticleName.
                IndexOf(keyword, 0, StringComparison.OrdinalIgnoreCase) == 0).ToList();
            DataTable table = CustomerDataGridView.ConvertToDataTable(matchedItems);
            dataGridView1.DataSource = table;
        }

        private void txtBoxQuantitySearch_KeyUp_1(object sender, KeyEventArgs e)
        {
            try
            {
                
                string keyword = txtBoxQuantitySearch.Text;
                if (keyword.Length > 0 && char.IsLetter(keyword[0]))
                    throw new Exception("Please enter only Numbers");
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    DataTable tabl = CustomerDataGridView.ConvertToDataTable(Containers.OrderList);
                    dataGridView1.DataSource = tabl;
                    return;
                }
                var matchedItems = Containers.OrderList.FindAll(item => item.Quantity == Convert.ToInt32(keyword)).ToList();
                DataTable table = CustomerDataGridView.ConvertToDataTable(matchedItems);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var matchedItems = Containers.OrderList.FindAll(item => 
            item.OrderedTime.Year == dateTimePicker1.Value.Year &&
            item.OrderedTime.Month == dateTimePicker1.Value.Month &&
            item.OrderedTime.Day == dateTimePicker1.Value.Day);
            DataTable table = CustomerDataGridView.ConvertToDataTable(matchedItems);
            dataGridView1.DataSource = table;
        }
    }
}
 