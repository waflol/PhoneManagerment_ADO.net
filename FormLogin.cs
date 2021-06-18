using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagerment_ADO.net
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connect.Connection_String);
            con.Open();
            string str = "SELECT username FROM Table1 WHERE password='" + txt_Password.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Visible = false;
                Home obj2 = new Home();
                obj2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username and Password.");
            }
        }
    }
}
