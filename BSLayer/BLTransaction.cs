using PhoneManagerment_ADO.net.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerment_ADO.net.BSLayer
{
    class BLTransaction
    {
        DBMain db = null;
        string err;
        public BLTransaction()
        {
            db = new DBMain();
        }
        public DataSet GetPhones()
        {
            return db.ExcuteQueryDataSet("select * from Transactions", CommandType.Text);
        }


        // them phone
        public bool addTransaction(int idtrans, int totalprice, DateTime date, int idcus, string username)
        {
            string sqlString = "Insert Into Transactions Values("+idtrans.ToString()+","+totalprice.ToString()+","+date.ToString()+","+idcus.ToString()+",'"+username+"')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //xoa phone
        public bool deleteTransaction(ref string err, string IDtrans)
        {
            string sqlString = "Delete From Phone where ID_phone = " + IDtrans.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        // cap nhat phone
        public bool updateTransaction(int idtrans, int totalprice, DateTime date, int idcus, string username, ref string err)
        {
            string sqlString = "Update Phone Set Total_price = " + totalprice.ToString()+", Date = "+date.ToString()+",ID_customer = "+idcus.ToString()+",username = '"+username+"' where ID_transaction = "+idtrans.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
