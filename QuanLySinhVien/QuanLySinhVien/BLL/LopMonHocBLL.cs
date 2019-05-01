using QuanLySinhVien.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    class LopMonHocBLL
    {
        DAL dal = new DAL();

        public DataTable xemTatCa()
        {
            string sql = "select * from LopMonHoc";
            return dal.getTable(sql);
        }

        public DataTable timKiemLop(string dieuKien)
        {
            string sql = "select * from LopMonHoc where maLopMonHoc like '%" + dieuKien + "%'" +
                " or maKhoa like '%" + dieuKien + "%'";
            return dal.getTable(sql);
        }

        public bool themLop(LopMonHoc lop)
        {
            //string sql = "insert into LopMonHoc(maLopMonHoc, maKhoa, khoaHoc, maGV, maMonHoc, maLopCoDinh) values(N'"
            //    + lop.maLop + "', N'" + lop.maKhoa + "', '"
            //    + lop.khoaHoc + "', N'" + lop.maGV + "', N'" + lop.maMonHoc + "', N'" + lop.maLopCoDinh + "')";
            string sql = "insert into LopMonHoc(maLopMonHoc, maLopCoDinh, maGV, maKhoa, maMonHoc, khoaHoc) " +
                "values (N'" + lop.maLop +"', N'" + lop.maLopCoDinh +"', N'" + lop.maGV + "', N'" 
                + lop.maKhoa + "', N'" + lop.maMonHoc + "', " + lop.khoaHoc+ ")";
            return dal.excuteNonQuery(sql);
        }

        public DataTable layKhoa()
        {
            string sql = "select * from Khoa";
            return dal.getTable(sql);
        }

        public DataTable layGV(string makhoa)
        {
            string sql = "select * from GiangVien where maKhoa = N'" + makhoa + "'";
            return dal.getTable(sql);
        }

        public DataTable layMonHoc(string makhoa)
        {
            string sql = "select * from MonHoc where maKhoa = N'" + makhoa + "'";
            return dal.getTable(sql);
        }

        public bool suaLop(LopMonHoc lop)
        {
            string sql = "update LopMonHoc set maLopCoDinh = N'" + lop.maLopCoDinh 
                + "', maKhoa = N'" + lop.maKhoa + "', khoaHoc ='"
                + lop.khoaHoc + "', maGV = N'" + lop.maGV + "', maMonHoc = N'" + lop.maMonHoc 
                + "' where maLopMonHoc = N'" + lop.maLop + "'";
            return dal.excuteNonQuery(sql);
        }

        public bool xoaLop(string maLop)
        {
            string sql = "delete LopMonHoc where maLopMonHoc = N'" + maLop + "'";
            return dal.excuteNonQuery(sql);
        }

        public DataTable layDsLopMonHoc(int khoaHoc, string maLopCoDinh)
        {
            string sql = "select * from LopMonHoc where khoaHoc = '" 
                + khoaHoc + "' and maLopCoDinh = N'" + maLopCoDinh + "'";
            return dal.getTable(sql);
        }

        public DataTable layLopCoDinh(string maKhoa)
        {
            string sql = "select * from LopCoDinh where maKhoa = '" + maKhoa + "'";
            return dal.getTable(sql);
        }
    }
}
