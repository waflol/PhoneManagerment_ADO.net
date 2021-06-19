using PhoneManagerment_ADO.net.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneManagerment_ADO.net.BSLayer
{
    class BLPhones
    {
        DBMain db = null;
        public BLPhones()
        {
            db = new DBMain();
        }
        public DataSet GetPhones()
        {
            return db.ExcuteQueryDataSet("select * from Phones", CommandType.Text);
        }
        

        
        // them phone
        public bool addPhones(int ID_phone,string modelName,string ram, string frontCamera, string simtype, string networktype, string price, string finger, string istorage, string estorage, string rearcamera)
        {
            return false;
        }
        //xoa phone
        public bool deletePhones(ref string err,string IDphone)
        {
            return false;
        }
        // cap nhat phone
        public bool updatePhones(int ID_phone, string modelName, string ram, string frontCamera, string simtype, string networktype, string price, string finger, string istorage, string estorage, string rearcamera, ref string err)
        {
            return false;
        }
    }
}
