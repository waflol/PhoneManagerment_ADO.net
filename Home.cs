using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneManagerment_ADO.net.DBLayer;

namespace PhoneManagerment_ADO.net {
    public partial class Home : Form {
        public Image image1 = Properties.Resources.store2;
        public Image image2 = Properties.Resources.store;
        public Image image3 = Properties.Resources.smartphone_redmi_800x450;
        private List<Image> images = new List<Image>();
        int b = 0;
        public Home() {
            InitializeComponent();
            images.Add(image1);
            images.Add(image2);
            images.Add(image3);
            pb_HinhNen.BackgroundImage = images[b];
            pb_HinhNen.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer_BackGroundChange.Start();

        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e) {
            Form_AddTransaction form_addTrans = new Form_AddTransaction();
            form_addTrans.ShowDialog();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void addNewPhoneToolStripMenuItem_Click(object sender, EventArgs e) {
            Form_AddNewPhone form_addnewphone = new Form_AddNewPhone();
            form_addnewphone.ShowDialog();
        }

        private void phoneDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
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

        private void timer1_Tick(object sender, EventArgs e) {
            if (b == 2) {
                b = 0;
            } else b++;

            pb_HinhNen.BackgroundImage = images[b];
            pb_HinhNen.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer_BackGroundChange.Start();

        }
        private void LoadHinhNen() {

        }
        private void pb_HinhNen_Click(object sender, EventArgs e) {

        }




        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e) {
            Change_Pass change_Pass = new Change_Pass();
            change_Pass.ShowDialog();
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e) {
            if (FormLogin.currentAccount == "Admin") {
                New_Acc new_Acc = new New_Acc();
                new_Acc.ShowDialog();
            } else {
                MessageBox.Show("You are not the Administrator");
            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e) {
            if (FormLogin.currentAccount == "Admin") {
                Mange_Acc acc = new Mange_Acc();
                acc.ShowDialog();
            } else {
                MessageBox.Show("You are not the Administrator");
            }
        }

        private void customerDetailToolStripMenuItem_Click(object sender, EventArgs e) {
            Customer_ID_Detail customer_ID_Detail = new Customer_ID_Detail();
            customer_ID_Detail.ShowDialog();
        }
    }
}
