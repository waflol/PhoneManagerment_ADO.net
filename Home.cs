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
        //public Image image1 = Image.FromFile("Resource//iphone1.jpg");
        public Home()
        {
            InitializeComponent();
            //pb_HinhNen.BackgroundImage = image1;
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

        private void transactionDetailToolStripMenuItem_Click(object sender, EventArgs e) {
            Form_TransactionDetails form_TransactionDetails = new Form_TransactionDetails();
            form_TransactionDetails.ShowDialog();
        }

        private void benefitToolStripMenuItem_Click(object sender, EventArgs e) {
            Form_Report report = new Form_Report();
            report.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void LoadHinhNen()
        {

        }
        private void pb_HinhNen_Click(object sender, EventArgs e)
        {

        }
    }
}
