using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ServiceChungKhoan.BAL
{
    public class ConnectData
    {
        private SqlConnection con;
        string conStr;

        public ConnectData()
        {
            try
            {
                //không sử tài khoản của chính máy. ko dùng tài khoản sa
//conStr = "data source=localhost;Integrated Security=true;Initial Catalog=StockQuotes";
               conStr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
         
            }
            catch (Exception)
            {
                
            }
        }

        public void openConnect()
        {
            con = new SqlConnection(conStr);
            con.Open();
        }
        public void disconnect()
        {
            if (con != null)
            {
                con.Close();//dong ket noi
                con.Dispose();//giai phong tai nguyen
                con = null;

            }
        }
        public SqlDataReader QuerySelect(String sql)
        {
            SqlDataReader reader=null;
            SqlCommand cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            return reader;
        }
        //ham truy van tra ve doi tuong datatable truyen vao cau truy van sql
    }
}