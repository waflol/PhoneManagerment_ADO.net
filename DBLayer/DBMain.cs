using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerment_ADO.net.DBLayer
{
    class DBMain
    {
        string ConnStr = Connect.Connection_String; // thêm conn
        //string ConnStr2 = Connect.Connection_String2;
        //string ConnStr3 = Connect.Connection_String3;
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;

        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            //try
            //{
                
            //}
            //catch
            //{
            //    try
            //    {
            //        conn = new SqlConnection(ConnStr2);
            //    }
            //    catch
            //    {
            //        conn = new SqlConnection(ConnStr3);
            //    }
            //}
            
            comm = conn.CreateCommand();
        }

        public DataSet ExcuteQueryDataSet(string strSQL, CommandType ct)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Successed");
                f = true;

            }
            catch(SqlException err)
            {
                error = err.Message;
                System.Windows.Forms.MessageBox.Show("Un Successed");
            }
            finally
            {
                conn.Close();
            }
            return f;

        }




    }
}
