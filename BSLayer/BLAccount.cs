﻿using PhoneManagerment_ADO.net.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
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
            string sqlcmd = "select * from Accounts where username = '" + user + "' and password = '" + pass+"'";
            DataSet data = db.ExcuteQueryDataSet(sqlcmd, CommandType.Text);
            if (data.Tables[0].Rows.Count == 1)
                return true;
            else return false;
        }

        // them phone
        public bool addAccount(string user, string pass)
        {
            return false;
        }
        //xoa phone
        public bool deletePhones(ref string err, string user)
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
