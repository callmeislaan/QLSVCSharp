using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    class DangNhapBLL
    {
        DAL dal = new DAL();
        public DataTable TimKiem(string ma, string matKhau)
        {
            string sql = "select * from TaiKhoan where ma = '" + ma + "' and matKhau = '" + matKhau + "'";
            return dal.getTable(sql);
        }
    }
}
