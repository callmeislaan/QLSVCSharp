using QuanLySinhVien.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    class KhoaBLL
    {
        DAL dal = new DAL();
        public DataTable xemTatCa()
        {
            string sql = "select * from Khoa";
            return dal.getTable(sql);
        }

        public DataTable timKiemKhoa(string dieuKien)
        {
            string sql = "select * from Khoa where maKhoa like '%" 
                + dieuKien + "%' or tenKhoa like '%" + dieuKien 
                + "%' or truongKhoa like '%" + dieuKien + "%'";
            return dal.getTable(sql);
        }

        public bool themKhoa(Khoa khoa)
        {
            string sql = "insert into Khoa values(N'" + khoa.maKhoa 
                + "', N'" + khoa.tenKhoa + "', N'" + khoa.truongKhoa + "')";
            return dal.excuteNonQuery(sql);
        }

        public bool suaKhoa(Khoa khoa)
        {
            string sql = "update Khoa set tenKhoa = N'" + khoa.tenKhoa 
                + "', truongKhoa = N'" + khoa.truongKhoa + "' where maKhoa = N'" 
                + khoa.maKhoa + "'";
            return dal.excuteNonQuery(sql);
        }

        public bool xoaKhoa(string maKhoa)
        {
            string sql = "delete Khoa where maKhoa = N'" + maKhoa + "'";
            return dal.excuteNonQuery(sql);
        }

        //public DataTable xemCacLop(string maKhoa)
        //{
        //    string sql = ""
        //}
    }
}
