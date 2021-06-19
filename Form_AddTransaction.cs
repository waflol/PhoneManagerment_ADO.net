﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagerment_ADO.net {
    public partial class Form_AddTransaction : Form {
        public Form_AddTransaction() {
            InitializeComponent();

        }
        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Add_Phone_Button_Click(object sender, EventArgs e) {
            GridView_Cart.Rows.Add("Iphone X", 10, 3);
        }

        private void PhoneName_Label_Click(object sender, EventArgs e) {

        }

        private void Total_Price_Label_Click(object sender, EventArgs e) {

        }

        private void Reset_Button_Click(object sender, EventArgs e) {
            foreach (var c in Customer_Panel.Controls) {
                if (c is TextBox) {
                    (c as TextBox).Text = "";
                }
            }
            foreach (var c in Phone_Info_Panel.Controls) {
                if (c is TextBox) {
                    (c as TextBox).Text = "";
                }
                cbb_PhoneName.SelectedIndex = -1;
                numeric_Quantity.Value = 0;
            }
        }
    }
}
