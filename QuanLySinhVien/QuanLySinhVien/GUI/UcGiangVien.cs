using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.Class;
using QuanLyGiangVien.BLL;

namespace QuanLySinhVien.GUI
{
    public partial class UcGiangVien : UserControl
    {
        GiangVien gv = new GiangVien();
        GiangVienBLL bll = new GiangVienBLL();
        int index;

        public UcGiangVien()
        {
            InitializeComponent();
        }

        private string tuDongMa()
        {
            DataTable dt = bll.timKiemTheoKhoa(cbKhoa.Text);
            string maDau = cbKhoa.Text;

            return new MaTuDong().maTuDong(dt, maDau);

        }
        private void layThongTinGiangVien()                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
        {
            gv.ma = txtMaGV.Text;
            gv.hoTen = txtHoTen.Text.Trim();
            gv.maKhoa = cbKhoa.Text;
            gv.ngaySinh = dtpNgaySinh.Value;
            gv.diaChi = txtDiaChi.Text;
            gv.email = txtEmail.Text;
            gv.soDT = txtSoDT.Text;
            gv.gioiTinh = rdNam.Checked ? true : false;
        }

        private string datMatKhau()
        {
            return dtpNgaySinh.Value.ToString("ddMMyyyy");
        }

        private void BtnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsGiangVien.DataSource = bll.layDsGv();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                layThongTinGiangVien();
                gv.matKhau = datMatKhau();
                if (gv.ma == string.Empty)
                {
                    MessageBox.Show("Mã giảng viên không được trống");
                }
                else if (gv.maKhoa == string.Empty)
                {
                    MessageBox.Show("Mã khoa không được để trống");
                }
                else if (gv.hoTen == string.Empty)
                {
                    MessageBox.Show("Họ tên không được để trống");
                }
                else
                {
                    if (bll.themGV(gv))
                    {
                        MessageBox.Show("Thêm giảng viên thành công");
                        dgvDsGiangVien.DataSource = bll.timKiemGiangVien(gv.ma);
                        BtnDatLai_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UcGiangVien_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = bll.layDsKhoa();
            cbKhoa.ValueMember = "maKhoa";
            cbKhoa.DisplayMember = "maKhoa";
        }

        private void CbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaGV.Text = tuDongMa();
        }

        private void DgvDsGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDsGiangVien.Rows[index];
                    txtDiaChi.Text = row.Cells["colDiaChi"].Value.ToString();
                    txtEmail.Text = row.Cells["colEmail"].Value.ToString();
                    txtHoTen.Text = row.Cells["colHoTen"].Value.ToString();
                    txtMaGV.Text = row.Cells["colMaGV"].Value.ToString();
                    txtSoDT.Text = row.Cells["colSoDT"].Value.ToString();
                    dtpNgaySinh.Text = row.Cells["colNgaySinh"].Value.ToString();
                    cbKhoa.Text = row.Cells["colMaKhoa"].Value.ToString();
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

        private void BtnDatLai_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtMaGV.Text = "";
            txtSoDT.Text = "";
            txtTimKiem.Text = "";
            cbKhoa.Text = "";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn giảng viên");
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có chắc xóa giảng viên: "
                    + dgvDsGiangVien.Rows[index].Cells[1].Value.ToString(), "Thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (bll.xoaGV(dgvDsGiangVien.Rows[index].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Xóa thành công");
                        BtnXemTatCa_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDsGiangVien.DataSource = bll.timKiemGiangVien(txtTimKiem.Text.Trim());
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            layThongTinGiangVien();
            if (bll.suaGV(gv))
            {
                MessageBox.Show("Sửa thành công");
                dgvDsGiangVien.DataSource = bll.timKiemGiangVien(gv.ma);
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void BtnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc đặt lại mật khẩu cho: " + txtHoTen.Text, "Thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                if (bll.resetPasswrod(txtMaGV.Text, datMatKhau()))
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Không thành công");
            }
        }
    }
}
