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
        public BLTransaction()
        {
            db = new DBMain();
        }
        public DataSet GetPhones()
        {
            return db.ExcuteQueryDataSet("select * from Phones", CommandType.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IDphone"></param>
        /// <param name="nameModel"></param>
        /// <param name="ram"></param>
        /// <param name="istorage"></param>
        /// <param name="display"></param>
        /// <param name="typeCamera"></param>
        /// <param name="simType"></param>
        /// <param name="networkType"></param>
        /// <param name="price"></param>
        /// <returns></returns>

        // them phone
        public bool addTransaction(string IDphone, string nameModel, string ram, string istorage, string display, string typeCamera, string simType, string networkType, string price)
        {
            return false;
        }
        //xoa phone
        public bool deleteTransaction(ref string err, string IDphone)
        {
            return false;
        }
        // cap nhat phone
        public bool updateTransaction(string IDphone, string nameModel, ref string err)
        {
            return false;
        }
    }
}
