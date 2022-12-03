using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WareHouse_Management
{
    public partial class ProductAdding : Form
    {
        Containers container;

        public ProductAdding(Containers cont)
        {
            InitializeComponent();
            container = cont;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.Controls.OfType<TextBox>().Any( x=> string.IsNullOrEmpty(x.Text)))
                    throw new Exception("Please fill all rows");
                if(numricUpDownQuan.Value <= 0)
                    throw new Exception("Quantity can not be 0 (zero)");
                if (numrcUpDwnPrice.Value <= 0)
                    throw new Exception("Price has not been set");
                Product prod = new Product(textBxPrdNm.Text, numrcUpDwnPrice.Value, (int)numricUpDownQuan.Value, richTextBoxDesc.Text);
                container.AddProduct(prod);
                MessageBox.Show("Added to DataBase","Sucess",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Close();        
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void numricUpDownQuan_Leave(object sender, EventArgs e)
        {
            if(numricUpDownQuan.Value <= 0)
                toolTip1.Show("Please fill quantity", numricUpDownQuan, 10, 30,5000);
        }

        private void numrcUpDwnPrice_Leave(object sender, EventArgs e)
        {
            if (numrcUpDwnPrice.Value <= 0)
                toolTip1.Show("Price can not be zero or minus value", numrcUpDwnPrice, 10, 30, 5000);
        }
    }
}
