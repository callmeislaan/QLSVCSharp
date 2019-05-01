using QuanLySinhVien.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    class DsSVLopCoDinhBLL
    {
        DAL dal = new DAL();
        public DataTable timKiem(string dieuKien, string maLopCoDinh)
        {
            string sql = "select * from SinhVien where maSV like '%" + dieuKien + "%' and maLopCoDinh = '" + maLopCoDinh + "'";
            return dal.getTable(sql);
        }

        public DataTable xemTatCa(string maLopCoDinh)
        {
            string sql = "select * from SinhVien where maLopCoDinh = '" + maLopCoDinh + "'";
            return dal.getTable(sql);
        }

        public bool them(SVLopCoDinh sv)
        {
            string sql = "insert into SinhVien(maSV, maLopCoDinh)" +
                " values (N'" + sv.maSV + "', N'" + sv.maLopCoDinh + "')";
            return dal.excuteNonQuery(sql);
        }

        public bool xoa(string maSV, string maLopCoDinh)
        {
            string sql = "delete SinhVien where maSV = '" + maSV + "' and maLopCoDinh = '" + maLopCoDinh + "'";
            return dal.excuteNonQuery(sql);
        }

        public DataTable layDsSVLopCoDinh(string maLopCoDinh)
        {
            string sql = "select * from SinhVien where maLopCoDinh = '" + maLopCoDinh + "'";
            return dal.getTable(sql);
        }

        public DataTable layDsSinhVien()
        {
            string sql = "select * from SinhVien";
            return dal.getTable(sql);
        }
    }
}
