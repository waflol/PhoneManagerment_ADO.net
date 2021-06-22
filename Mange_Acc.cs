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
    public partial class Mange_Acc : Form {
        public Mange_Acc() {
            InitializeComponent();
        }
        string name_delete = "";
        string x = "";
        BLAccount acc = new BLAccount();
        private void Mange_Acc_Load(object sender, EventArgs e) {
            LoadData();
        }

        void LoadData() {
            dataGridView1.DataSource = acc.GetAccount().Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                int a = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[a].Cells[0].Value != null) {
                    // gán model name trong datagridview đã chọn
                    name_delete = dataGridView1.Rows[a].Cells[0].Value.ToString();
                    Name_Textbox.Text = name_delete;
                    //label3.Text = Phone_Id;
                }
            } catch { }
        }

        private void Name_Textbox_TextChanged(object sender, EventArgs e) {
            dataGridView1.DataSource = acc.FindAccount(Name_Textbox.Text).Tables[0];
        }

        private void Delete_Button_Click(object sender, EventArgs e) {
            acc.deleteAccount(ref x,name_delete);
            LoadData();
        }
    }
}
