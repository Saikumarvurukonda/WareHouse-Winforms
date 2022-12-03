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
    public partial class OrderAdding : Form
    {
        Containers container;

        public OrderAdding(Containers cont)
        {
            InitializeComponent();
            container = cont;
        }

        private void btnCanx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderAdding_Load(object sender, EventArgs e)
        {
            var customerList = Containers.CustomerList;
            foreach (var item in customerList)
            {
                comboBox1.Items.Add(item);
            }
            var productList = Containers.ProductList;
            foreach (var item in productList)
            {
                comboBox2.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controls.OfType<ComboBox>().Any(item => item.SelectedItem == null))
                    throw new Exception("Please choose Customer & Product");
                if(numricUpDownQuan.Value <= 0)
                    throw new Exception("Quantity can not be zero");
                Customer customer = (Customer)comboBox1.SelectedItem;
                Product product = (Product)comboBox2.SelectedItem;
                if (product.Quantity - (int)numricUpDownQuan.Value < 0)
                    throw new Exception("Product quantity is less than ordered products count");
                product.Quantity -= (int)numricUpDownQuan.Value;
                if (product.Quantity == 0)
                    Containers.ProductList.Remove(product);
                Order order = new Order(customer,product,(int)numricUpDownQuan.Value,dateTimePicker1.Value);
                container.AddOrder(order);
                MessageBox.Show("Order Completed Successfully", "Congratulations",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null) return;
            var remaining = ((Product)comboBox2.SelectedItem).Quantity;
            toolTip1.Show($"Selected Product Quantity : {remaining}", comboBox2, 20, 20, 5000);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
