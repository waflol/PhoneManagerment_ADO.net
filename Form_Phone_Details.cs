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
    public partial class Form_Phone_Details : Form {
        public Form_Phone_Details() {
            InitializeComponent();
            LoadData();
        }

        BLPhones phone = new BLPhones();
        private string Phone_Id;
        private string x = " ";

        void LoadData() {
            GridView_PhoneRecord.DataSource = phone.GetPhones().Tables[0];
            GridView_PhoneRecord.Columns[10].Visible = false;

        

        }

        private void btn_Delete_Click(object sender, EventArgs e) {
            phone.deletePhones(ref x, Phone_Id);
            LoadData();
        }

        private void GridView_PhoneRecord_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                int a = GridView_PhoneRecord.CurrentCell.RowIndex;
                if (GridView_PhoneRecord.Rows[a].Cells[10].Value != null) {
                    // gán model name trong datagridview đã chọn
                    Phone_Id = GridView_PhoneRecord.Rows[a].Cells[10].Value.ToString();
                }
            } catch { }
        }

        private void txt_PhoneID_TextChanged(object sender, EventArgs e)
        {
            //string search_value = txt_PhoneID.Text;
            //GridView_PhoneRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //foreach (DataGridViewRow row in GridView_PhoneRecord.Rows)
            //{
            //    if(row.Cells[10].Value.ToString().Equals(search_value))
            //    {
            //        row.Selected = true;
            //        break;
            //    }
            //}
            GridView_PhoneRecord.DataSource = phone.search_ModelName(txt_PhoneID.Text).Tables[0];
            GridView_PhoneRecord.Columns[10].Visible = false;

        }
    }
}
