using QuanLySinhVien.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    class DsSVLopMonHocBLL
    {
        DAL dal = new DAL();
        public DataTable timKiem(string dieuKien)
        {
            string sql = "select * from SinhVienLopMonHoc where maSV = '" + dieuKien + "'";
            return dal.getTable(sql);
        }

        public DataTable xemTatCa(string maLopMonHoc)
        {
            string sql = "select * from SinhVienLopMonHoc where maLopMonHoc = '" + maLopMonHoc + "'";
            return dal.getTable(sql);
        }

        public bool them(SVLopMonHoc sv)
        {
            string sql = "insert into SinhVienLopMonHoc(maSV, maLopMonHoc, diemLT, diemTH)" +
                " values (N'" + sv.maSV + "', N'" + sv.maLopMonHoc + "', '" + sv.diemLT + "', '" + sv.diemTH + "')";
            return dal.excuteNonQuery(sql);
        }

        public bool sua(SVLopMonHoc sv)
        {
            string sql = "update SinhVienLopMonHoc set diemLt = '" + sv.diemLT + "', diemTH = '" + sv.diemTH + "'" +
                " where maSV = '" + sv.maSV + "' and maLopMonHoc = '" + sv.maLopMonHoc + "'";
            return dal.excuteNonQuery(sql);
        }

        public bool xoa(string maSV, string maLopMonHoc)
        {
            string sql = "delete SinhVienLopMonHoc where maSV = '" + maSV + "' and maLopMonHoc = '" + maLopMonHoc + "'";
            return dal.excuteNonQuery(sql);
        }

        public DataTable layDsSVLopMonHoc(string maLopMonHoc)
        {
            string sql = "select * from SinhVienLopMonHoc where maLopMonHoc = '" + maLopMonHoc + "'";
            return dal.getTable(sql);
        }

        public DataTable layDsSinhVien()
        {
            string sql = "select * from SinhVien";
            return dal.getTable(sql);
        }
    }
}
