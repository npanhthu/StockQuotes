using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace ServiceChungKhoan
{
    class ConnectData
    {
        private SqlConnection con;

        public ConnectData()
        {
            try
            {
                //không sử tài khoản của chính máy. ko dùng tài khoản sa
                string conStr = "data source=localhost;Integrated Security=true;Initial Catalog=DataSinhVien";
                //sử dụng tài khoản sa
                //  string conStr = "data source=localhost;Initial Catalog=DataSinhVien;Persist Security Info=True;User ID=sa;Password=123456";
                con = new SqlConnection(conStr);
                con.Open();
            }
            catch (Exception ex)
            {
            }
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

        //ham truy van tra ve doi tuong datatable truyen vao cau truy van sql
        public ArrayList<string> Query(string sql)
        {
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            cm.EndExecuteReader();
        }

        //hàm truy vấn không cần trả về dành cho truy vấn update,insert,delete
        public int QueryUpdate(string sql)
        {
            SqlCommand cm = new SqlCommand(sql, con);
            int numrow = cm.ExecuteNonQuery();
            return numrow;//truy vấn này sẽ trã về số hàng bị thay đỗi bỡi những câu truy vấn update.nên nếu cái này =0 thì update ko làm đc gì cả
        }
    }
}