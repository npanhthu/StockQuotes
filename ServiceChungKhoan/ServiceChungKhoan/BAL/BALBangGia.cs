using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceChungKhoan.DAL;
using System.Data.SqlClient;

namespace ServiceChungKhoan.BAL
{
    public class BALBangGia
    {
        private ConnectData cndata;

        public BALBangGia()
        {
            cndata = new ConnectData();
        }

        public BangGia getInforBangGiaHienTai(string MaCK)
        {
            BangGia bg = new BangGia();
            try
            {
                string ngayhientai = layNgayHienTai();
                string sql = "Select * from tbLichSuGia Where MaCK Like '" + MaCK + "' and Ngay = '" + ngayhientai + "'";
                cndata.openConnect();
                SqlDataReader reader = cndata.QuerySelect(sql);
                reader.Read();
                bg.Beta = float.Parse(reader["Beta"].ToString());
                bg.DongCua = float.Parse(reader["DongCua"].ToString());
                bg.EPS = float.Parse(reader["EPS"].ToString());
                bg.EPS4QuyTruoc = float.Parse(reader["EPS4QuyTruoc"].ToString());
                bg.GCN52Tuan = float.Parse(reader["GCN52Tuan"].ToString());
                bg.GTN52Tuan = float.Parse(reader["GTN52Tuan"].ToString());
                bg.GiaCaoNhat = float.Parse(reader["GiaCaoNhat"].ToString());
                bg.GiaSoSach = float.Parse(reader["GiaSoSach"].ToString());
                bg.GiaThapNhat = float.Parse(reader["GiaThapNhat"].ToString());
                bg.KLLuuHanh = float.Parse(reader["KLLuuHanh"].ToString());
                bg.KLTB10Ngay = float.Parse(reader["KLTB10Ngay"].ToString());
                bg.KLTB13Tuan = float.Parse(reader["KLTB13Tuan"].ToString());
                bg.KhoiLuong = float.Parse(reader["KhoiLuong"].ToString());
                bg.MaCK = reader["MaCK"].ToString();
                bg.MoCua = float.Parse(reader["MoCua"].ToString());
                bg.Ngay = reader["Ngay"].ToString();
                bg.PE = float.Parse(reader["PE"].ToString());
                bg.ROA = float.Parse(reader["ROA"].ToString());
                bg.ThamChieu = float.Parse(reader["ThamChieu"].ToString());
                bg.VonThiTruong = float.Parse(reader["VonThiTruong"].ToString());
            }
            catch (FormatException)
            {
            }
            return bg;
        }

        public List<BangGia> getHistoryBangGia(string MaCk)
        {
            List<BangGia> listbg = new List<BangGia>();

            string sql = "Select * from tbLichSuGia Where MaCK Like '" + MaCk + "' ORDER BY Ngay ASC";
            cndata.openConnect();
            SqlDataReader reader = cndata.QuerySelect(sql);
            while (reader.Read())
            {
                try
                {
                    BangGia bg = new BangGia();
                    bg.Beta = float.Parse(reader["Beta"].ToString());
                    bg.EPS = float.Parse(reader["EPS"].ToString());
                    bg.DongCua = float.Parse(reader["DongCua"].ToString());
                    bg.EPS4QuyTruoc = float.Parse(reader["EPS4QuyTruoc"].ToString());
                    bg.GCN52Tuan = float.Parse(reader["GCN52Tuan"].ToString());
                    bg.GTN52Tuan = float.Parse(reader["GTN52Tuan"].ToString());
                    bg.GiaCaoNhat = float.Parse(reader["GiaCaoNhat"].ToString());
                    bg.GiaSoSach = float.Parse(reader["GiaSoSach"].ToString());
                    bg.GiaThapNhat = float.Parse(reader["GiaThapNhat"].ToString());
                    bg.KLLuuHanh = float.Parse(reader["KLLuuHanh"].ToString());
                    bg.KLTB10Ngay = float.Parse(reader["KLTB10Ngay"].ToString());
                    bg.KLTB13Tuan = float.Parse(reader["KLTB13Tuan"].ToString());
                    bg.KhoiLuong = float.Parse(reader["KhoiLuong"].ToString());
                    bg.MaCK = reader["MaCK"].ToString();
                    bg.MoCua = float.Parse(reader["MoCua"].ToString());
                    bg.Ngay = reader["Ngay"].ToString();
                    bg.PE = float.Parse(reader["PE"].ToString());
                    bg.ROA = float.Parse(reader["ROA"].ToString());
                    bg.ThamChieu = float.Parse(reader["ThamChieu"].ToString());
                    bg.VonThiTruong = float.Parse(reader["VonThiTruong"].ToString());
                    listbg.Add(bg);
                }
                catch (FormatException)
                {
                }
            }
            return listbg;
        }

        private string layNgayHienTai()
        {
            string ngayhientai = "";
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            ngayhientai += year + "-" + month + "-" + day;
            return ngayhientai;
        }
    }
}