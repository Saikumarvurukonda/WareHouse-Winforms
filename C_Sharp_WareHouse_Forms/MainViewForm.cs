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
    public partial class MainViewForm : Form
    {
        Login loginForm = new Login();
        ProductAdding addingProductForm = null;
        CustomerAdding addingCustomerForm = null;
        OrderAdding addingOrderForm = null;
        Containers containers = new Containers();
        CustomerDataGridView customerDataGridForm = null;
        ProductsDataGridtViewForm productsGridView = null;
        OrderlistGridViewForm ordersGridViewForm = null;

        public MainViewForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainViewForm_FormClosed1(object sender, FormClosedEventArgs e)
        {
            SaveLoadtoFile.SaveCustomerstoXml();
            SaveLoadtoFile.SaveProductstoXml();
            SaveLoadtoFile.SaveOrderstoXml();
        }

        private void MainViewForm_Load(object sender, EventArgs e)
        {
            SaveLoadtoFile.LoadCustomersFromXML();
            SaveLoadtoFile.LoadProductsFromXML();
            SaveLoadtoFile.LoadOrdersFromXML();
            Product.IDCounter = Containers.GetLastProductID();
            Customer.IDCounter = Containers.GetLastCustomerID();
            Order.IDCounter = Containers.GetLastOrderID();
            loginForm = new Login();
            loginForm.FormClosed += LoginForm_FormClosed;
            toolStripStatusLabel1.Text = $"Logged In as : {loginForm.Username}";
            loginForm.ShowDialog();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm = null;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBxOldUserNm.Clear();
            textBxNewUsernm.Clear();
            textBxOldPass.Clear();
            textBxNewPass.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aborted","Cancel",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            panel1.Visible = false;
            return;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (textBxOldUserNm.Text == loginForm.Username && textBxOldPass.Text == loginForm.Password)
            {
                loginForm.ChangeCredentials(textBxNewUsernm.Text, textBxNewPass.Text);
                MessageBox.Show("Successfully Changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panel1.Visible = false;
            }
            else if(panel1.Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text)))
                MessageBox.Show("Please Fill All Details", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            else
                MessageBox.Show("Old Credentials are wrong!!!","ERROR",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addingProductForm == null)
            {
                addingProductForm = new ProductAdding(containers);
                addingProductForm.StartPosition = FormStartPosition.CenterParent;
                addingProductForm.FormClosed += AddingProductForm_FormClosed;
                addingProductForm.ShowDialog();
            }
            else
                addingProductForm.Activate();
            
        }

        private void AddingProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addingProductForm = null;
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(addingCustomerForm == null)
            {
                addingCustomerForm = new CustomerAdding(containers);
                addingCustomerForm.StartPosition = FormStartPosition.CenterParent;
                addingCustomerForm.FormClosed += AddingCustomerForm_FormClosed;
                addingCustomerForm.ShowDialog();
            }
            else
                addingCustomerForm.Activate();
        }

        private void AddingCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addingCustomerForm = null;
        }

        private void addNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addingOrderForm == null)
            {
                addingOrderForm = new OrderAdding(containers);
                addingOrderForm.StartPosition = FormStartPosition.CenterParent;
                addingOrderForm.FormClosed += AddingOrderForm_FormClosed;
                addingOrderForm.Show();
            }
            else
                addingOrderForm.Activate();
        }

        private void AddingOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addingOrderForm = null;
        }

        private void listOfCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerDataGridForm == null)
            {
                customerDataGridForm = new CustomerDataGridView(containers);
                customerDataGridForm.StartPosition = FormStartPosition.CenterScreen;
                customerDataGridForm.MdiParent = this;
                customerDataGridForm.FormClosed += CustomerDataGridForm_FormClosed1; ;
                customerDataGridForm.Show();
            }
            else
                customerDataGridForm.Activate();
        }

        private void CustomerDataGridForm_FormClosed1(object sender, FormClosedEventArgs e)
        {
            customerDataGridForm = null;
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productsGridView == null)
            {
                productsGridView = new ProductsDataGridtViewForm(containers);
                productsGridView.MdiParent = this;
                productsGridView.StartPosition = FormStartPosition.CenterScreen;
                productsGridView.FormClosed += ProductsGridView_FormClosed;
                productsGridView.Show();
            }
            else
                productsGridView.Activate();
        }

        private void ProductsGridView_FormClosed(object sender, FormClosedEventArgs e)
        {
            productsGridView = null;
        }

        private void allOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ordersGridViewForm == null)
            {
                ordersGridViewForm = new OrderlistGridViewForm(containers);
                ordersGridViewForm.MdiParent = this;
                ordersGridViewForm.StartPosition = FormStartPosition.CenterScreen;
                ordersGridViewForm.FormClosed += OrdersGridViewForm_FormClosed; ;
                ordersGridViewForm.Show();
            }
            else
                ordersGridViewForm.Activate();
        }

        private void OrdersGridViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ordersGridViewForm = null;
        }
    }

}




