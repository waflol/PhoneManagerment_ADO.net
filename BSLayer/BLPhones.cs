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
        public bool addPhones(string IDphone, string nameModel,string ram, string istorage, string display, string typeCamera, string simType, string networkType, string price )
        {
            return 0;
        }
        //xoa phone
        public bool deletePhones(ref string err,string IDphone)
        {
            return 0;
        }
        // cap nhat phone
        public bool updatePhones(string IDphone, string nameModel, ref string err)
        {
            return 0;
        }
    }
}
