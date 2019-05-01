using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Class
{
    public class MonHoc
    {
        public string maMon { get; set; }
        public string tenMon { get; set; }
        public int soTinChiLT { get; set; }
        public int soTinChiTH { get; set; }
        public float diemLT { get; set; }
        public float diemTH { get; set; }
        public string maKhoa { get; set; }

        public int tongTinChi()
        {
            return soTinChiLT + soTinChiTH;
        }
        
        public float tinhDiemTB()
        {
            return (diemLT + diemTH) / 2;
        }

        public string tinhDiemChu()
        {
            float diem = tinhDiemTB();
            if (diem < 4)
                return "F";
            else if (diem <= 4.6)
                return "D";
            else if (diem <= 5.4)
                return "D+";
            else if (diem <= 6.1)
                return "C";
            else if (diem <= 6.9)
                return "C+";
            else if (diem <= 7.6)
                return "B";
            else if (diem < 8.4)
                return "B+";
            else
                return "A";
        }
    }
}
