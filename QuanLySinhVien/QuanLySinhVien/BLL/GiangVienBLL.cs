using QuanLySinhVien;
using QuanLySinhVien.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiangVien.BLL
{
    class GiangVienBLL
    {
        DAL dal = new DAL();

        public DataTable layDsGv()
        {
            string sql = "select * from GiangVien";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public bool themGV(GiangVien gv)
        {
            string sql = "insert into GiangVien(maGV, hoTen, ngaySinh, diaChi," +
                " gioiTinh, email, soDT, maKhoa) values (N'" + gv.ma + "', N'" + gv.hoTen + "'," +
                " N'" + gv.ngaySinh.ToString("yyyy-MM-dd") + "', N'" + gv.diaChi +
                "', '" + gv.gioiTinh + "', N'" + gv.email + "', N'" + gv.soDT + "', N'" + gv.maKhoa + "');" +
                "insert into TaiKhoan values (N'" + gv.ma + "', N'" + gv.matKhau + "', 'gv')";
            return dal.excuteNonQuery(sql);
        }

        public bool suaGV(GiangVien gv)
        {
            string sql = "update GiangVien set hoTen = N'" + gv.hoTen + "'," +
                " ngaySinh = '" + gv.ngaySinh.ToString("yyyy-MM-dd") + "', diaChi = N'" + gv.diaChi +
                "', gioiTinh = '" + gv.gioiTinh + "', email = N'" + gv.email + "', soDT = N'" + gv.soDT + "', maKhoa = N'" + gv.maKhoa + "' where maGV = '" + gv.ma + "'";
            return dal.excuteNonQuery(sql);
        }

        public bool xoaGV(string maGV)
        {
            string sql = "delete GiangVien where maGV = '" + maGV + "';" +
                "delete TaiKhoan where ma = '" + maGV + "'";
            return dal.excuteNonQuery(sql);
        }

        public bool resetPasswrod(string maGV, string matKhau)
        {
            string sql = "update TaiKhoan set matKhau = '" + matKhau + "' where ma = '" + maGV + "'";
            return dal.excuteNonQuery(sql);
        }

        public DataTable timKiemGiangVien(string dieuKien)
        {
            string sql = "select * from GiangVien where maGV like '%" + dieuKien + "%' or hoTen like '%" + dieuKien + "%' or maKhoa like '%" + dieuKien + "%'";
            DataTable dt = dal.getTable(sql);
            return dt;
        }

        public DataTable timKiemTheoKhoa(string maKhoa)
        {
            string sql = "select * from GiangVien where maKhoa = '" + maKhoa + "'";
            return dal.getTable(sql);
        }

        public DataTable layDsKhoa()
        {
            string sql = "select maKhoa from Khoa";
            DataTable dt = dal.getTable(sql);
            return dt;
        }

        public DataTable laySiSoKhoa(string maKhoa)
        {
            string sql = "select count(*) from GiangVien where maKhoa = '" + maKhoa + "'";
            return dal.getTable(sql);
        }
    }
}
