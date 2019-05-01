using QuanLySinhVien.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    class MonHocBLL
    {
        DAL dal = new DAL();

        public DataTable xemTatCa()
        {
            string sql = "select * from MonHoc";
            return dal.getTable(sql);
        }

        public DataTable timKiemMonHoc(string dieuKien)
        {
            string sql = "select * from MonHoc where maMonHoc like '%" + dieuKien + "%'" +
                " or tenMonHoc like '%" + dieuKien + "%'";
            return dal.getTable(sql);
        }

        public bool themMonHoc(MonHoc mon)
        {
            string sql = "insert into MonHoc values(N'"
                + mon.maMon + "', N'" + mon.tenMon + "', '" + mon.soTinChiLT + "', '" + mon.soTinChiTH + "'" +
                ", N'" + mon.maKhoa + "')";
            return dal.excuteNonQuery(sql);
        }

        public bool suaMonHoc(MonHoc mon)
        {
            string sql = "update MonHoc set tenMonHoc = N'" + mon.tenMon + "', soTinChiLT = '"
                + mon.soTinChiLT + "', soTinChiTH = N'" + mon.soTinChiTH + "', N' maKhoa = '" + mon.maKhoa + 
                "' where maMonHoc = N'" + mon.maMon + "'";
            return dal.excuteNonQuery(sql);
        }

        public bool xoaMonHoc(string maMon)
        {
            string sql = "delete MonHoc where maMonHoc = N'" + maMon + "'";
            return dal.excuteNonQuery(sql);
        }

        public DataTable layKhoa()
        {
            string sql = "select * from Khoa";
            return dal.getTable(sql);
        }
    }
}
