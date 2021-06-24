﻿using System;
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
    public partial class Deal_Result : Form {
        private int Trans_id;
        public Deal_Result(int id) {
            InitializeComponent();
            Trans_id = id;
        }

        private void Deal_Result_Load(object sender, EventArgs e) {
            BLTransaction_details transaction_Detail = new BLTransaction_details();
            dataGridView1.DataSource = transaction_Detail.search_byTrans_ID(Trans_id).Tables[0];
        }
    }
}
