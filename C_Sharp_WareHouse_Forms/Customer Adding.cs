using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WareHouse_Management
{
    public partial class CustomerAdding : Form
    {
        Containers container ;
        public CustomerAdding(Containers cont)
        {
            InitializeComponent();
            container = cont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txtBoxEmail.Text,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase))
                    throw new Exception("WRONG EMAIL FORMAT");
                if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text)))
                    throw new Exception("Please fill all rows");
                if ((!Regex.IsMatch(txtBxName.Text, @"^[a-zA-Z]{3,50}$")) 
                    || (!Regex.IsMatch(txtBxSurname.Text, @"^[a-zA-Z]{3,50}$")))
                    throw new Exception("Name or Surname can not contain any Numbers");
                if (!maskdTxtBxPhone.MaskFull)
                    throw new Exception("Please fill Contact Deatils");
                Customer cust = new Customer(txtBxName.Text, txtBxSurname.Text, txtBoxEmail.Text, maskdTxtBxPhone.Text, richTxtBxAddr.Text);
                container.AddCustomer(cust);
                MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerAdding_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void maskdTxtBxPhone_Leave(object sender, EventArgs e)
        {
            if (!maskdTxtBxPhone.MaskFull)
                toolTip1.Show("NOT ALL DATA ENTERED", maskdTxtBxPhone, 10, 30, 5000);
        }

        private void maskdTxtBxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                toolTip1.Show("Phone number must contain only digits", maskdTxtBxPhone, 10, 30, 3000);
        }

    }
}
