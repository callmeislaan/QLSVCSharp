using QuanLySinhVien.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    class SinhVienBLL
    {
        DAL dal = new DAL();

        public DataTable layDsSV()
        {
            string sql = "select * from SinhVien";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public bool themSV(SinhVien sv)
        {
            string sql = "insert into SinhVien(maSV, hoTen, maLopCoDinh, ngaySinh, diaChi," +
                " gioiTinh, email, soDT, queQuan) values (N'" + sv.ma + "', N'" + sv.hoTen + "'," +
                " N'" + sv.maLopCoDinh + "', N'" + sv.ngaySinh.ToString("yyyy-MM-dd") + "', N'" + sv.diaChi +
                "', '" + sv.gioiTinh + "', N'" + sv.email + "', N'" + sv.soDT + "', N'" + sv.queQuan + "');" +
                "insert into TaiKhoan values (N'" + sv.ma + "', N'" + sv.matKhau + "', 'sv')";
            return dal.excuteNonQuery(sql);
        }

        public bool suaSV(SinhVien sv)
        {
            string sql = "update SinhVien set hoTen = N'" + sv.hoTen + "'," +
                " maLopCoDinh = N'" + sv.maLopCoDinh + "', ngaySinh = '" + sv.ngaySinh.ToString("yyyy-MM-dd") + "', diaChi = N'" + sv.diaChi +
                "', gioiTinh = '" + sv.gioiTinh + "', email = N'" + sv.email + "', soDT = N'" + sv.soDT + "', queQuan = N'" + sv.queQuan + "' where maSV = '" + sv.ma + "'";
            return dal.excuteNonQuery(sql);
        }
        
        public bool xoaSV(string maSV)
        {
            string sql = "delete SinhVien where maSV = '" + maSV + "';" +
                "delete TaiKhoan where ma = '" + maSV + "'";
            return dal.excuteNonQuery(sql);
        }

        public bool resetPasswrod(string maSV, string matKhau)
        {
            string sql = "update TaiKhoan set matKhau = '" + matKhau + "' where ma = '" + maSV + "'";
            return dal.excuteNonQuery(sql);
        }

        public DataTable timKiemSinhVien(string dieuKien)
        {
            string sql = "select * from SinhVien where maSV like '%" + dieuKien + "%' or hoTen like '%" + dieuKien + "%' or maLopCoDinh like '%" + dieuKien + "%'";
            DataTable dt = dal.getTable(sql);
            return dt;
        }

        public DataTable timKiemSinhVienTheoLopCoDinh(string maLopCoDinh)
        {
            string sql = "select * from SinhVien where maLopCoDinh = '" + maLopCoDinh + "'";
            return dal.getTable(sql);
        }

        public DataTable layDsLop()
        {
            string sql = "select maLopCoDinh from LopCoDinh";
            DataTable dt = dal.getTable(sql);
            return dt;
        }

        public DataTable laySiSoLop(string maLop)
        {
            string sql = "select count(*) from SinhVien where maLopCoDinh = '" + maLop + "'";
            return dal.getTable(sql);
        }
    }
}
