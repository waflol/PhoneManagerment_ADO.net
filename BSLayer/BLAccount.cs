using PhoneManagerment_ADO.net.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerment_ADO.net.BSLayer
{
    class BLAccount
    {
        string err;
        DBMain db = null;
        public BLAccount()
        {
            db = new DBMain();
        }
        public DataSet GetAccount()
        {
            return db.ExcuteQueryDataSet("select * from Accounts", CommandType.Text);
        }

        public bool checkAccount(string user, string pass)
        {
            string sqlcmm = "select * from Accounts where username = '" + user + "' and password = '" + pass+"'";

            DataSet ds = db.ExcuteQueryDataSet(sqlcmm, CommandType.Text);
           
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }

        public bool ExistAccount(string user)
        {
            string sqlcmm = "select * from Accounts where username = '" + user + "'";

            DataSet ds = db.ExcuteQueryDataSet(sqlcmm, CommandType.Text);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }
        // them phone
        public bool addAccount(string user, string pass)
        {
            return false;
        }
        //xoa phone
        public bool deleteAccount(ref string err, string user)
        {
            return false;
        }
        // cap nhat phone
        public bool updateAccount(string user, string pass, ref string err)
        {
            return false;
        }
    }
}
