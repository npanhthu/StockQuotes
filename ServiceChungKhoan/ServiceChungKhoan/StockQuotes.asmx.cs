using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServiceChungKhoan.DAL;
using ServiceChungKhoan.BAL;

namespace ServiceChungKhoan
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        [WebMethod]
        public DoanhNghiep DoanhNghiepInfor(string MaCk)
        {
            DoanhNghiep dn = new BALDoanhNghiep().getThongTinDN(MaCk);
            return dn;
        }
        [WebMethod]
        public List<DoanhNghiep> AllDoanhNghiepInfor()
        {
            List<DoanhNghiep> ldn = new BALDoanhNghiep().getAllThongTinDN();
            return ldn;
        }
        [WebMethod]
        public BangGia BangGiaCKHienTai(string MaCk)
        {
            BangGia bg = new BangGia();
            bg = new BALBangGia().getInforBangGiaHienTai(MaCk);
            return bg;
        }
        [WebMethod]
        public List<BangGia> BangGiaLichSu(string MaCk)
        {
            List<BangGia> listbg = new List<BangGia>();
            listbg = new BALBangGia().getHistoryBangGia(MaCk);
            return listbg;
        }
    }
}