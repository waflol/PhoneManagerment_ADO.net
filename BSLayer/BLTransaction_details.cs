using PhoneManagerment_ADO.net.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerment_ADO.net.BSLayer
{
    class BLTransaction_details
    {
        DBMain db = null;
        string err;
        public BLTransaction_details()
        {
            db = new DBMain();
        }

        public DataSet getTransaction_details()
        {
            string sqlString = "select * from Customer, Phone, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_phone = Phone.ID_phone";
            return db.ExcuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool addTransaction_details(string quantity, string idtransaction, string idphone)
        {
            string sqlString = "Insert Into Transaction_Details Values(" + quantity + "," + idtransaction + "," + idphone + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool deleteTransaction_details(string idtransaction)
        {
            string sqlString = "Delete From Phone where ID_phone = " + idtransaction;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


    }
}
