using QuanLySinhVien.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    class LopCoDinhBLL
    {
        DAL dal = new DAL();

        public DataTable xemTatCa()
        {
            string sql = "select * from LopCoDinh";
            return dal.getTable(sql);
        }

        public DataTable timKiemLop(string dieuKien)
        {
            string sql = "select * from LopCoDinh where maLopCoDinh like '%" + dieuKien + "%'" +
                " or tenLopCoDinh like '%" + dieuKien + "%' or maKhoa like '%" + dieuKien + "%'";
            return dal.getTable(sql);
        }

        public bool themLop(LopCoDinh lop)
        {
            string sql = "insert into LopCoDinh(maLopCoDinh, tenLopCoDinh, maKhoa, khoaHoc, maGV) values(N'" 
                + lop.maLop + "', N'" + lop.tenLop + "', N'" + lop.maKhoa + "', '" 
                + lop.khoaHoc + "', N'" + lop.maGV + "')";
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

        public bool suaLop(LopCoDinh lop)
        {
            string sql = "update LopCoDinh set tenLopCodinh = N'" + lop.tenLop + "', maKhoa = N'" + lop.maKhoa + "', khoaHoc ='"
                + lop.khoaHoc + "', maGV = N'" + lop.maGV + "' where maLopCoDinh = N'" + lop.maLop + "'";
            return dal.excuteNonQuery(sql);
        }

        public bool xoaLop(string maLop)
        {
            string sql = "delete LopCoDinh where maLopCoDinh = N'" + maLop + "'";
            return dal.excuteNonQuery(sql);
        }
    }
}
