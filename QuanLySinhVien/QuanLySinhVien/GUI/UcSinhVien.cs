using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.BLL;
using QuanLySinhVien.Class;

namespace QuanLySinhVien.GUI
{
    public partial class UcSinhVien : UserControl
    {
        SinhVienBLL bll = new SinhVienBLL();
        SinhVien sv = new SinhVien();

        public UcSinhVien()
        {
            InitializeComponent();
        }

        private string maTuDong()
        {
            DataTable dt = bll.timKiemSinhVienTheoLopCoDinh(cbMaLopCoDinh.Text);
            string maDau = cbMaLopCoDinh.Text;
            return new MaTuDong().maTuDong(dt, maDau);
        }

        private void layLop()
        {
            DataTable dt = bll.layDsLop();
            cbMaLopCoDinh.DataSource = dt;
            cbMaLopCoDinh.ValueMember = "maLopCoDinh";
            cbMaLopCoDinh.DisplayMember = "maLopCoDinh";
        }

        private string datMatKhau()
        {
            return sv.ngaySinh.ToString("ddMMyyyy");
        }

        private void layThongTinSV()
        {
            sv.diaChi = txtDiaChi.Text.Trim();
            sv.email = txtEmail.Text.Trim();
            sv.gioiTinh = rdNam.Checked ? true : false;
            sv.hoTen = txtHoTen.Text.Trim();
            sv.ma = txtMaSV.Text.Trim();
            sv.ngaySinh = dtpNgaySinh.Value;
            sv.queQuan = txtQueQuan.Text.Trim();
            sv.soDT = txtSoDT.Text.Trim();
            sv.maLopCoDinh = cbMaLopCoDinh.Text;
            sv.matKhau = datMatKhau();
        }
        
        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDsSinhVien.DataSource = bll.timKiemSinhVien(txtTimKiem.Text.Trim());

        }

        private void BtnXemTatCa_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.layDsSV();
            dgvDsSinhVien.DataSource = dt;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Họ tên không được trống");
            }
            else if (txtMaSV.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Mã sinh viên không được để trống");
            }
            else if (cbMaLopCoDinh.Text == string.Empty)
            {
                MessageBox.Show("Lớp cố định không được để trống");
            }
            else
            {
                layThongTinSV();
                if (bll.themSV(sv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDsSinhVien.DataSource = bll.timKiemSinhVien(sv.ma);
                    BtnDatLai_Click(sender, e);
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (index >= 0)
                {
                    DialogResult chon = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                    if (chon == DialogResult.Yes)
                    {
                        bll.xoaSV(dgvDsSinhVien.Rows[index].Cells[0].Value.ToString());
                        MessageBox.Show("Đã xóa thành công", "Thông báo");
                        BtnXemTatCa_Click(sender, e);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int index;

        private void DgvDsSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDsSinhVien.Rows[index];
                    txtDiaChi.Text = row.Cells["colDiaChi"].Value.ToString();
                    txtEmail.Text = row.Cells["colEmail"].Value.ToString();
                    txtHoTen.Text = row.Cells["colHoTen"].Value.ToString();
                    txtMaSV.Text = row.Cells["colMaSV"].Value.ToString();
                    txtQueQuan.Text = row.Cells["colQueQuan"].Value.ToString();
                    txtSoDT.Text = row.Cells["colSoDT"].Value.ToString();
                    cbMaLopCoDinh.Text = row.Cells["colMaLopCoDinh"].Value.ToString();
                    dtpNgaySinh.Text = row.Cells["colNgaySinh"].Value.ToString();
                    if (row.Cells["colGioiTinh"].Value.Equals(true))
                        rdNam.Checked = true;
                    else
                        rdNu.Checked = true;
                }
                catch (Exception)
                {

                }
            }
            
        }

        private void UcSinhVien_Load(object sender, EventArgs e)
        {
            layLop();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Họ tên không được trống");
            }
            else if (txtMaSV.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Mã sinh viên không được để trống");
            }
            else if (cbMaLopCoDinh.Text == string.Empty)
            {
                MessageBox.Show("Lớp cố định không được để trống");
            }
            else
            {
                layThongTinSV();
                if (!bll.suaSV(sv))
                    MessageBox.Show("Không thành công");
                else
                {
                    MessageBox.Show("Thành công");
                    dgvDsSinhVien.DataSource = bll.timKiemSinhVien(sv.ma);
                }
            }
        }

        private void BtnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                layThongTinSV();
                string matKhau = datMatKhau();
                if (bll.resetPasswrod(sv.ma, matKhau))
                {
                    MessageBox.Show("Đã đặt lại mật khẩu");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDatLai_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            rdNam.Checked = true;
            txtHoTen.Text = "";
            txtMaSV.Text = "";
            txtQueQuan.Text = "";
            txtSoDT.Text = "";
            cbMaLopCoDinh.Text = "";
        }

        private void CbTenLopCoDinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaSV.Text = maTuDong();
        }
    }
}
