using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceChungKhoan.DAL;
using System.Data.SqlClient;

namespace ServiceChungKhoan.BAL
{
    public class BALDoanhNghiep
    {
        ConnectData cndata = null;
        public BALDoanhNghiep()
        {
            cndata = new ConnectData();
        }
        public DoanhNghiep getThongTinDN(String MaCK)
        {
            DoanhNghiep dn = new DoanhNghiep();
            String sql = "Select * from tbDoanhNghiep where MaCK like '"+MaCK+"'";
            cndata.openConnect();
            SqlDataReader reader = cndata.QuerySelect(sql);
            reader.Read();
            dn.DiaChi = reader["DiaChi"].ToString();
            dn.DienThoai = reader["DienThoai"].ToString();
            dn.fax = reader["fax"].ToString();
            dn.MaCK = reader["MaCK"].ToString();
            dn.Nganh = reader["Nganh"].ToString();
            dn.SanGD = reader["SanGD"].ToString();
            dn.TenDoanhNghiep = reader["TenDoanhNghiep"].ToString();
            dn.website = reader["website"].ToString();
            cndata.disconnect();
            return dn;
        }
        public List<DoanhNghiep> getAllThongTinDN()
        {
            List<DoanhNghiep> listDN=new List<DoanhNghiep>();
            String sql = "Select * from tbDoanhNghiep";
            cndata.openConnect();
            SqlDataReader reader = cndata.QuerySelect(sql);
           
            while (reader.Read())
            {
                DoanhNghiep dn = new DoanhNghiep();
                dn.DiaChi = reader["DiaChi"].ToString();
                dn.DienThoai = reader["DienThoai"].ToString();
                dn.fax = reader["fax"].ToString();
                dn.MaCK = reader["MaCK"].ToString();
                dn.Nganh = reader["Nganh"].ToString();
                dn.SanGD = reader["SanGD"].ToString();
                dn.TenDoanhNghiep = reader["TenDoanhNghiep"].ToString();
                dn.website = reader["website"].ToString();
                listDN.Add(dn);
            }
            return listDN;
        }

    }
}