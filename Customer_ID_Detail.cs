using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneManagerment_ADO.net.BSLayer;

namespace PhoneManagerment_ADO.net {
    public partial class Customer_ID_Detail : Form {

        BLCustomers customers = new BLCustomers();
        public Customer_ID_Detail() {
            InitializeComponent();
            dataGridView1.DataSource = customers.GetCustomers().Tables[0];
        }

        //customers.GetCustomers();
        private void KH_Textbox_TextChanged(object sender, EventArgs e) {
            dataGridView1.DataSource = customers.FindCustomer_SDT(SDT_Textbox.Text).Tables[0];
        }

        private void Reload_Button_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = customers.GetCustomers().Tables[0];
        }
    }
}
