using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    class NVPhongDaoTaoBLL
    {
        DAL dal = new DAL();
        public DataTable layNV(string maNV)
        {
            string sql = "select * from NvPhongDaoTao where maNV = '" + maNV + "'";
            return dal.getTable(sql);
        }
    }
}
