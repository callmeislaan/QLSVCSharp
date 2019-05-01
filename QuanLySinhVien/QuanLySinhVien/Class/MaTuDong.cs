using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Class
{
    public class MaTuDong
    {
        public string maTuDong(DataTable dt, string maDau)
        {
            string ma = maDau;

            int so = 0;
            int soLuong = dt.Rows.Count;
            if (soLuong == 0)
            {
                so = 1;
            }
            else if (soLuong == 1)
            {
                if (dt.Rows[0][0].ToString().Substring(dt.Rows[0][0].ToString().Length - 2) != "01")
                {
                    so = 1;
                }
                else
                {
                    so = 2;
                }
            }
            else
            {
                int maKhoaLength = dt.Rows[0][0].ToString().Length - 2;
                int i = 0;
                do
                {
                    string x = dt.Rows[i + 1][0].ToString().Substring(dt.Rows[0][0].ToString().Length - 2);
                    string y = dt.Rows[i][0].ToString().Substring(dt.Rows[0][0].ToString().Length - 2);
                    int a = int.Parse(x);
                    int b = int.Parse(y);
                    if (a - b > 1)
                    {
                        so = a + 1;
                        break;
                    }
                    i++;
                } while (i < soLuong - 1);
                so = int.Parse(dt.Rows[i][0].ToString().Substring(dt.Rows[0][0].ToString().Length - 2)) + 1;
            }

            if (so < 10)
            {
                ma += "0" + so;
            }
            else
            {
                ma += so;
            }



            return ma;
        }
    }
}
