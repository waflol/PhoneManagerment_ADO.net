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
namespace PhoneManagerment_ADO.net
{
    public partial class Form_AddNewPhone : Form
    {
        public Form_AddNewPhone()
        {
            InitializeComponent();
        }
       
        private void btn_Save_Click(object sender, EventArgs e)
        {
            BLPhones phone = new BLPhones();
            phone.addPhones(Convert.ToInt32(txt_IDphone.Text), txt_ModelName.Text, cbb_Ram.Text, cbb_FrontCamera.Text, cbb_SimType.Text, cbb_NetworkType.Text, txt_Price.Text, cbb_FingerprintSensor.Text, cbb_InternalStorage.Text, cbb_InternalStorage.Text, cbb_RearCamera.Text);
        }
    }
}
