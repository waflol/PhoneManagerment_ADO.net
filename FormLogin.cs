using PhoneManagerment_ADO.net.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneManagerment_ADO.net.BSLayer;
namespace PhoneManagerment_ADO.net
{
    public partial class FormLogin : Form
    {
        private string currentAccount = "";
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            string user = txt_Username.Text;
            string pass = txt_Password.Text;
            BLAccount acc = new BLAccount();

            if (acc.checkAccount(user,pass))
            {
                currentAccount = user;
                this.Visible = false;
                Home obj2 = new Home();
                obj2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username and Password.");
            }
        }
    }
}
