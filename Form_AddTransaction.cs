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
            listCart.Columns.Add("ID phone", 0);
            listCart.Columns.Add("Phone", 125);
            listCart.Columns.Add("Price", 125);
            listCart.Columns.Add("Quantity", 125);
            Total_Price_Textbox.Text = "0";
        }
        private string phoneChosed;
        private string PricePhone;

        BLPhones phone = new BLPhones();
        public void loadPhone()
        {
            dgv_watchPhone.DataSource = phone.GetPhones().Tables[0];
            dgv_watchPhone.Columns[10].Visible = false;
           
        }



        private void Total_Price_Label_Click(object sender, EventArgs e) {

        }

        private void Reset_Button_Click(object sender, EventArgs e) {
            
            
        }
        DataSet phone_search_model = new DataSet();

        private void Form_AddTransaction_Load(object sender, EventArgs e)
        {
            loadPhone();
            listCart.View = View.Details;
            listCart.GridLines = true;
            listCart.FullRowSelect = true;

            listCart.Columns[0].Text = "Phone";
            listCart.Columns[0].Width = 0;

            listCart.Columns[1].Text = "Phone";
            listCart.Columns[1].Width = 125;

            listCart.Columns[2].Text = "Price";
            listCart.Columns[2].Width = 125;

            listCart.Columns[3].Text = "Quantity";
            listCart.Columns[3].Width = 125;

            

        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            dgv_watchPhone.DataSource = phone.search_ModelName(txt_Phone.Text).Tables[0];
            dgv_watchPhone.Columns[10].Visible = false;
        }


        private List<string> id_phone = new List<string>();


        private void btn_Add_Click(object sender, EventArgs e)
        {
            int a = dgv_watchPhone.CurrentCell.RowIndex;
            int totalPrice = 0;
            try
            {
                if (dgv_watchPhone.Rows[a].Cells[10].Value != null)
                {
                    if(numeric_Quantity.Value > 0)
                    {

                        string[] arr = new string[4];
                        ListViewItem itm;
                        //add items to ListView
                        arr[0] = dgv_watchPhone.Rows[a].Cells[10].Value.ToString();
                        arr[1] = dgv_watchPhone.Rows[a].Cells[0].Value.ToString();
                        arr[2] = dgv_watchPhone.Rows[a].Cells[5].Value.ToString();
                        arr[3] = numeric_Quantity.Value.ToString();
                        itm = new ListViewItem(arr);


                        if(id_phone.IndexOf(arr[0]) == -1)
                        {
                            listCart.Items.Add(itm);
                            id_phone.Add(arr[0]);
                        }
                        else
                        {
                            int x = Convert.ToInt32(listCart.Items[id_phone.IndexOf(arr[0])].SubItems[3].Text) + (int)numeric_Quantity.Value;
                            listCart.Items[id_phone.IndexOf(arr[0])].SubItems[3].Text = x.ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn số lượng");
                    }   
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Vui lòng chọn phone");
            }
            for (int i = 0; i < listCart.Items.Count;i++)
            {
                totalPrice += (Convert.ToInt32(listCart.Items[i].SubItems[2].Text) * Convert.ToInt32(listCart.Items[i].SubItems[3].Text));
            }

            Total_Price_Textbox.Text = totalPrice.ToString();
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listCart.SelectedItems)
            {
                int index = listCart.Items.IndexOf(item);
                listCart.Items.RemoveAt(index);

            }

        }
    }
}
