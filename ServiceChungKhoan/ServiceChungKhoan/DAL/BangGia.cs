using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceChungKhoan.DAL
{
    public class BangGia
    {
        public string MaCK { get; set; }
        public string Ngay { get; set; }
        public float ThamChieu { get; set; }
        public float MoCua { get; set; }
        public float DongCua { get; set; }
        public float GiaThapNhat { get; set; }
        public float GiaCaoNhat { get; set; }
        public float KhoiLuong { get; set; }
        public float KLTB13Tuan { get; set; }
        public float KLTB10Ngay { get; set; }
        public float GCN52Tuan { get; set; }
        public float GTN52Tuan { get; set; }
        public float EPS { get; set; }
        public float PE { get; set; }
        public float VonThiTruong { get; set; }
        public float KLLuuHanh { get; set; }
        public float GiaSoSach { get; set; }
        public float ROA { get; set; }
        public float Beta { get; set; }
        public float EPS4QuyTruoc { get; set; }
        public BangGia()
        {
            MaCK = "";
            Ngay = "";
            ThamChieu = 0;
            MoCua = 0;
            DongCua = 0;
            GiaThapNhat = 0;
            GiaCaoNhat = 0;
            KhoiLuong = 0;
            KLTB13Tuan = 0;
            KLTB10Ngay = 0;
            GCN52Tuan = 0;
            GTN52Tuan = 0;
            EPS = 0;
            PE = 0;
            VonThiTruong = 0;
            KLLuuHanh = 0;
            GiaSoSach = 0;
            ROA = 0;
            Beta = 0;
            EPS4QuyTruoc = 0;
        }
    }
}