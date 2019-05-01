using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Class
{
    public class SinhVien: Nguoi
    {
        public string khoa { get; set; }
        public string queQuan { get; set; }
        public int khoaHoc { get; set; }
        public string maLopCoDinh { get; set; }

    }
}
