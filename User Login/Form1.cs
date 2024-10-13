using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
       

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text=="1234" && txtUserName.Text == "yakas")
            {
                MessageBox.Show("Basarili olarak girdiniz!");
            }
            else
            {
                MessageBox.Show("Hatali username veya password girdiniz!", "Hatali Giris");
            }
        }
    }
}
