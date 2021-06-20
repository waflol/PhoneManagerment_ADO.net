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
    public partial class Form_AddTransaction : Form {
        public Form_AddTransaction() {
            InitializeComponent();
        }
        BLTransaction_details transaction_Detail = new BLTransaction_details();
        BLTransaction transaction = new BLTransaction();
        BLCustomers customer = new BLCustomers();
        // tạo đối tượng thực thi tầng nghiệp vụ
        BLPhones Phone = new BLPhones();
        // biến để lưu dữ liệu truy vẫn
        DataSet Phone_search_dataset = new DataSet();
        // biến tổng tiền
        private int Total_cost = 0;
        // biến giá tiền điện thoại bị xoá
        private int Phone_remove_cost = 0;
        // biến trỏ giá trị trong datagridvieww
        private int index;
        // biến trỏ giá trị để xoá trong datagridview
        private int index_remove;
        // tạo mảng lưu tên điện thoại đã chọn
        private List<string> Phones_name_buying = new List<string>();
        // tạo biến điện thoại sẽ bị xoá
        string Phone_remove;
        // tạo biến phoneID để lấy phoneID report
        private List<string> phoneID = new List<string>();


        private bool isAlready(string PhoneName) {
            for (int i = 0; i < GridView_Cart.Rows.Count; i++) {
                if (GridView_Cart.Rows[i].Cells[0].Value != null) {
                    if (GridView_Cart.Rows[i].Cells[0].Value.Equals(PhoneName)) {
                        index = i;
                        return true;
                    }
                }
            }
            return false;
        }
        private void Add_Phone_Button_Click(object sender, EventArgs e) {
            if ((int)numeric_Quantity.Value > 0 && Phone_Name_Textbox.Text != "") {
                // kiểm tra điện thoại đã đươcc thêm hay chưa
                if (!isAlready(Phone_Name_Textbox.Text)) {
                    GridView_Cart.Rows.Add(Phone_Name_Textbox.Text, txt_Price.Text, numeric_Quantity.Value);
                    Phones_name_buying.Add(Phone_Name_Textbox.Text);
                } else {
                    // cập nhật lại cột số lượng trong hoá đơn
                    GridView_Cart[2, index].Value = int.Parse(GridView_Cart[2, index].Value.ToString()) + (int)numeric_Quantity.Value;
                }
                Total_cost += int.Parse(txt_Price.Text) * (int)numeric_Quantity.Value;
                Total_Cost_Textbox.Text = Total_cost.ToString();
                // reset lại panel điện thoại
                foreach (var c in Phone_Info_Panel.Controls) {
                    if (c is TextBox) {
                        (c as TextBox).Text = "";
                    }
                    numeric_Quantity.Value = 1;
                }
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
                numeric_Quantity.Value = 1;
            }
            GridView_Cart.Rows.Clear();
            GridView_Cart.Refresh();
        }
        private void Phone_Name_Textbox_TextChanged(object sender, EventArgs e) {
            
            try {
                Phone_search_dataset = Phone.search_ModelName(Phone_Search_Textbox.Text);

                if (Phone_search_dataset.Tables.Count > 0 && Phone_Search_Textbox.Text != "") {
                    Phone_Name_Textbox.Text = Phone_search_dataset.Tables[0].Rows[0][0].ToString();
                    txt_Ram.Text = Phone_search_dataset.Tables[0].Rows[0][1].ToString();
                    txt_istorage.Text = Phone_search_dataset.Tables[0].Rows[0][8].ToString();
                    txt_Display.Text = Phone_search_dataset.Tables[0].Rows[0][3].ToString();
                    txt_sim.Text = Phone_search_dataset.Tables[0].Rows[0][4].ToString();
                    txt_camera.Text = Phone_search_dataset.Tables[0].Rows[0][5].ToString();
                    txt_Price.Text = Phone_search_dataset.Tables[0].Rows[0][6].ToString();
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

        private void GridView_Cart_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                index_remove = GridView_Cart.CurrentCell.RowIndex;
                if (GridView_Cart.Rows[index_remove].Cells[0].Value != null) {
                    // gán phone trong datagridview đã chọn
                    Phone_remove = GridView_Cart.Rows[index_remove].Cells[0].Value.ToString();
                }
            } catch { }
        }

        private void Remove_Button_Click(object sender, EventArgs e) {
            try {
                // xoá tên điện thoại ra khỏi mảnng
                Phones_name_buying.RemoveAt(index_remove);
                Total_cost -= int.Parse(GridView_Cart.Rows[index_remove].Cells[1].Value.ToString()) * int.Parse(GridView_Cart.Rows[index_remove].Cells[2].Value.ToString());
                // xoá row trên datagridview
                GridView_Cart.Rows.RemoveAt(index_remove);
                Total_Cost_Textbox.Text = Total_cost.ToString();
            } catch { }
        }

        private void Export_Button_Click(object sender, EventArgs e)
        {
           
            customer.addCustomer(Name_Textbox.Text, Phone_Number_Textbox.Text, Address_Textbox.Text, customer.returnMaxID()+1);
            transaction.addTransaction(transaction.returnMaxID() + 1,Total_cost, dtpk_BuyDate.Value, customer.returnMaxID(), FormLogin.currentAccount);
            int index_Row = 0;
            foreach (DataRow rows in GridView_Cart.Rows)
            {
                transaction_Detail.addTransaction_details(rows[2].ToString(), transaction.returnMaxID().ToString(), phoneID[index_Row]);
                index_Row += 1;
            }
        }
    }
}
