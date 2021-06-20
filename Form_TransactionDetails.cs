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

namespace PhoneManagerment_ADO.net
{
    public partial class Form_TransactionDetails : Form
    {
        public Form_TransactionDetails()
        {
            InitializeComponent();
        }
        BLTransaction_details transaction_Detail = new BLTransaction_details();

        void LoadData()
        {
            GridView_Details_Trans.DataSource = transaction_Detail.getTransaction_details().Tables[0];
            GridView_Details_Trans.Columns[23].HeaderText = "Seller";

            // Ẩn các dòng ko cần thiết
          
            GridView_Details_Trans.Columns[5].Visible = false;
            GridView_Details_Trans.Columns[6].Visible = false;
            GridView_Details_Trans.Columns[7].Visible = false;
            GridView_Details_Trans.Columns[8].Visible = false;
            GridView_Details_Trans.Columns[9].Visible = false;
            GridView_Details_Trans.Columns[11].Visible = false;
            GridView_Details_Trans.Columns[12].Visible = false;
            GridView_Details_Trans.Columns[13].Visible = false;
            GridView_Details_Trans.Columns[14].Visible = false;
            GridView_Details_Trans.Columns[15].Visible = false;
            GridView_Details_Trans.Columns[16].Visible = false;
            GridView_Details_Trans.Columns[17].Visible = false;
            GridView_Details_Trans.Columns[18].Visible = false;
            GridView_Details_Trans.Columns[19].Visible = false;
            GridView_Details_Trans.Columns[20].Visible = false;
            GridView_Details_Trans.Columns[22].Visible = false;

            GridView_Details_Trans.AutoResizeColumns();
        }
        private void Form_TransactionDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txt_IDTrans_TextChanged(object sender, EventArgs e)
        {
            GridView_Details_Trans.DataSource = transaction_Detail.search_byPhonenum(txt_IDTrans.Text).Tables[0];
        }
    }
}
