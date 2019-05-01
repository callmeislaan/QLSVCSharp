using QuanLySinhVien.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DangNhapBLL().TimKiem(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
            try
            {
                if (txtTaiKhoan.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtMatKhau.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    string maNV = dt.Rows[0][0].ToString();
                    new FormNvPhongDaoTao(maNV).Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnDangNhap_Click(sender, e);
            }
        }

        private bool KiemTraDangNhap()
        {
            return false;
        }
    }
}
