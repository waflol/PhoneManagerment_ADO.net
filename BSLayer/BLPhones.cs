using PhoneManagerment_ADO.net.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneManagerment_ADO.net.BSLayer {
    class BLPhones {
        DBMain db = null;
        string err;
        public BLPhones() {
            db = new DBMain();
        }
        public DataSet GetPhones() {
            return db.ExcuteQueryDataSet("select * from Phone", CommandType.Text);
        }

        public int returnMaxID() {
            string sqlString = "select max(ID_phone) as max_id from Phone";
            DataSet ds = db.ExcuteQueryDataSet(sqlString, CommandType.Text);
            try {
                if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                    return 0;
                else
                    return int.Parse(ds.Tables[0].Rows[0]["max_id"].ToString());
            } catch (Exception error) {
                return 0;
            }


        }

        // them phone
        public bool addPhones(int ID_phone, string modelName, string ram, string frontCamera, string simtype, string networktype, string price, string finger, string istorage, string estorage, string rearcamera) {

            string sqlString = "Insert Into Phone Values('" + modelName + "','" + ram + "','" + frontCamera + "','" + simtype + "','" + networktype + "','" + price + "','" + finger + "','" + istorage + "','" + estorage + "','" + rearcamera + "'," + ID_phone.ToString() + ")";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        //xoa phone
        public bool deletePhones(ref string err, string IDphone) {
            string sqlString = "Delete From Phone where ID_phone = " + IDphone;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        // cap nhat phone
        public bool updatePhones(int ID_phone, string modelName, string ram, string frontCamera, string simtype, string networktype, string price, string finger, string istorage, string estorage, string rearcamera, ref string err) {
            string sqlString = "Update Phone Set Model_Name = '" + modelName + "', ram = '" + ram + ",Front_Camera = '" + frontCamera + "',Sim_Type = '" + simtype + "',Network_Type = '" + networktype + "', Price = '" + price + "',Finger = '" + finger + "',istorage = '" + istorage + "',estorage = '" + estorage + "',Rear_Camera = '" + rearcamera + "' where ID_phone = " + ID_phone.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet search_ModelName(string namephone) {
            string sqltring = "SELECT * FROM Phone WHERE Model_Name LIKE '" + namephone + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }
    }
}
