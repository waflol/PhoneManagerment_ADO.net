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
    public partial class Form_AddTransaction : Form {
        public Form_AddTransaction() {
            InitializeComponent();

        }

        // tạo đối tượng thực thi tầng nghiệp vụ
        BLPhones phone = new BLPhones();
        // biến để lưu dữ liệu truy vẫn
        DataSet phone_search_dataset = new DataSet();
        // biến tổng tiền
        private int total_cost = 0;
        // tạo mảng lưu tên điện thoại đã chọn
        private List<string> Phones_name_buying = new List<string>();

        private void Add_Phone_Button_Click(object sender, EventArgs e) {
            if ((int)numeric_Quantity.Value > 0) {
                GridView_Cart.Rows.Add(Phone_Name_Textbox.Text, txt_Price.Text, numeric_Quantity.Value);
                Phones_name_buying.Add(Phone_Name_Textbox.Text);
            } else {
                MessageBox.Show("An image Phone ?");
            }
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
                numeric_Quantity.Value = 0;
            }
        }
        private void Phone_Name_Textbox_TextChanged(object sender, EventArgs e) {

            try {
                phone_search_dataset = phone.search_ModelName(Phone_Search_Textbox.Text);

                if (phone_search_dataset.Tables.Count > 0 && Phone_Search_Textbox.Text != "") {
                    Phone_Name_Textbox.Text = phone_search_dataset.Tables[0].Rows[0][0].ToString();
                    txt_Ram.Text = phone_search_dataset.Tables[0].Rows[0][1].ToString();
                    txt_istorage.Text = phone_search_dataset.Tables[0].Rows[0][8].ToString();
                    txt_Display.Text = phone_search_dataset.Tables[0].Rows[0][3].ToString();
                    txt_sim.Text = phone_search_dataset.Tables[0].Rows[0][4].ToString();
                    txt_camera.Text = phone_search_dataset.Tables[0].Rows[0][5].ToString();
                    txt_Price.Text = phone_search_dataset.Tables[0].Rows[0][6].ToString();
                } else
                    throw new Exception();
            } catch {
                Phone_Name_Textbox.Text = "";
                txt_Ram.Text = "";
                txt_istorage.Text = "";
                txt_Display.Text = "";
                txt_sim.Text = "";
                txt_camera.Text = "";
                txt_Price.Text = "";
            }
        }
    }
}
