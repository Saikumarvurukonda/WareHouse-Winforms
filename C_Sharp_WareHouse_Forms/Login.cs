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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string Username = "username";
        public string Password = "password";
        bool check = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == Username && txtBoxPassw.Text == Password)
            {
                check = true;
                Close();
            }
            else if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text)))
            {
                MessageBox.Show("Please Fill All Details", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("WRONG CREDENTIALS", "ERROR GENERATED",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    Environment.Exit(0);
                else
                    return;
            }
        }


        public void ChangeCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!check)
                Environment.Exit(0);
        }
    }
}
