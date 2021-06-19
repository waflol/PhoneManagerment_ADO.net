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
            string sqlString = "select * from "
        }

    }
}
