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
        public Image image1 = Image.FromFile("Resources\\store2.png");
        public Image image2 = Image.FromFile("Resources\\store.png");
        public Image image3 = Image.FromFile("Resources\\9531_smart.png");
        private List<Image> images = new List<Image>();
        int b = 0;
        public Home()
        {
            InitializeComponent();
            images.Add(image1);
            images.Add(image2);
            images.Add(image3);
            pb_HinhNen.BackgroundImage = images[b];
            pb_HinhNen.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer_BackGroundChange.Start();
            
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
            if (b == 0)
            {
                b = 1;
            }
            if (b == 1)
                b = 2;
            else
                b = 0;

            pb_HinhNen.BackgroundImage = images[b];
            pb_HinhNen.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer_BackGroundChange.Start();
         
        }
        private void LoadHinhNen()
        {

        }
        private void pb_HinhNen_Click(object sender, EventArgs e)
        {

        }
    }
}
