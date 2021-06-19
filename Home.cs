using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagerment_ADO.net
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddTransaction form_addTrans = new Form_AddTransaction();
            form_addTrans.ShowDialog();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void addNewPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddNewPhone form_addnewphone = new Form_AddNewPhone();
            form_addnewphone.ShowDialog();
        }

        private void phoneDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Phone_Details formphonedetail = new Form_Phone_Details();
            formphonedetail.ShowDialog();
        }
    }
}
