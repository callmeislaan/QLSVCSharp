using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    class DAL
    {
        public SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection(@"Data Source=DESKTOP-CO7TLTP;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với server", "Lỗi server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable getTable(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection conn = GetConnection();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool excuteNonQuery(string sql)
        {
            try
            {
                SqlConnection conn = GetConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Clone();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
