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

        BLPhones phone = new BLPhones();

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
                numeric_Quantity.Value = 0;
            }
        }
        DataSet phone_search_model = new DataSet();
        private void Phone_Name_Textbox_TextChanged(object sender, EventArgs e) {
            
            phone_search_model = phone.search_ModelName(Phone_Name_Textbox.Text);

            txt_Ram.Text = phone_search_model.Tables[0].Rows[1]["ram"].ToString();
            txt_istorage.Text = phone_search_model.Tables[0].Rows[1]["istorage"].ToString();
            //txt_Display.Text = phone_search_model.Tables[0].Rows[1]["Display"].ToString();
            txt_sim.Text = phone_search_model.Tables[0].Rows[1]["Sim_Type"].ToString();
            txt_camera.Text = phone_search_model.Tables[0].Rows[1]["Front_Camera"].ToString();
            txt_Price.Text = phone_search_model.Tables[0].Rows[1]["Price"].ToString();
        }
    }
}
