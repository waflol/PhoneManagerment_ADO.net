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
        }

        BLPhones phone = new BLPhones();
        private string Phone_Id;

        private void Form_Phone_Details_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'phoneDBDataSet.Phone' table. You can move, or remove it, as needed.
            this.phoneTableAdapter.Fill(this.phoneDBDataSet.Phone);

        }

        private void btn_Delete_Click(object sender, EventArgs e) {
            phone.deletePhones(Phone_Id);
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

    }
}
