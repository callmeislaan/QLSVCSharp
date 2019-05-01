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
using QuanLySinhVien.BLL;

namespace QuanLySinhVien.GUI
{
    public partial class UcLopMonHoc : UserControl
    {

        int index = -1;
        LopMonHoc lop = new LopMonHoc();
        LopMonHocBLL bll = new LopMonHocBLL();
        public UcLopMonHoc()
        {
            InitializeComponent();
        }

        private string maTuDong()
        {
            DataTable dt = bll.layDsLopMonHoc(int.Parse(nudKhoaHoc.Value.ToString()), "" + cbMaLopCoDinh.SelectedValue);
            string maDau = "K" + nudKhoaHoc.Value + cbMonHoc.SelectedValue;
            return new MaTuDong().maTuDong(dt, maDau);
        }

        private void layThongTin()
        {
            try
            {
                lop.maLop = txtMaLop.Text;
                lop.khoaHoc = int.Parse(nudKhoaHoc.Value.ToString());
                lop.maKhoa = cbKhoa.Text;
                lop.maGV = cbGV.Text == string.Empty ? "" : cbGV.SelectedValue.ToString();
                lop.maLopCoDinh = cbMaLopCoDinh.SelectedValue.ToString();
                lop.maMonHoc = cbMonHoc.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }

        private void DgvDsLopMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDsLopMonHoc.Rows[index];
                    cbKhoa.Text = row.Cells["colMaKhoa"].Value.ToString();
                    cbGV.Text = row.Cells["colMaGV"].Value.ToString();
                    nudKhoaHoc.Value = int.Parse(row.Cells["colKhoaHoc"].Value.ToString());
                    txtMaLop.Text = row.Cells["colMaLop"].Value.ToString();
                    cbMaLopCoDinh.Text = row.Cells["colMaLopCoDinh"].Value.ToString();
                    cbMonHoc.Text = row.Cells["colMaMonHoc"].Value.ToString();
                }
                catch (Exception)
                {

                }
            }
        }

        private void UcLopMonHoc_Load(object sender, EventArgs e)
        {

            cbKhoa.DataSource = bll.layKhoa();
            cbKhoa.ValueMember = "maKhoa";
            cbKhoa.DisplayMember = "maKhoa";
        }

        private void BtnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsLopMonHoc.DataSource = bll.xemTatCa();
        }

        private void CbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            cbGV.Text = "";
            cbGV.DataSource = bll.layGV(cbKhoa.Text);
            if (ckbTenGV.Checked)
            {
                cbGV.DisplayMember = "hoTen";
            }
            else
            {
                cbGV.DisplayMember = "maGV";
            }
            cbGV.ValueMember = "maGV";

            cbMonHoc.Text = "";
            cbMonHoc.DataSource = bll.layMonHoc(cbKhoa.Text);
            if (ckbTenMH.Checked)
            {
                cbMonHoc.DisplayMember = "tenMonHoc";
            }
            else
            {
                cbMonHoc.DisplayMember = "maMonHoc";
            }
            cbMonHoc.ValueMember = "maMonHoc";

            cbMaLopCoDinh.Text = "";
            cbMaLopCoDinh.DataSource = bll.layLopCoDinh(cbKhoa.Text);
            if (ckbTenMH.Checked)
            {
                cbMaLopCoDinh.DisplayMember = "tenLopCoDinh";
            }
            else
            {
                cbMaLopCoDinh.DisplayMember = "maLopCoDinh";
            }
            cbMaLopCoDinh.ValueMember = "maLopCoDinh";
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            layThongTin();
            if (txtMaLop.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Mã lớp không được trống");
            }
            else if (cbKhoa.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Mã khoa không được trống");
            }
            else if (cbGV.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Giảng viên không được trống");
            }
            else if (cbMaLopCoDinh.Text == string.Empty)
            {
                MessageBox.Show("Mã lớp cố định không được để trống");
            }
            else
            {
                if (bll.themLop(lop))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDsLopMonHoc.DataSource = bll.timKiemLop(lop.maLop);
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void CkbTenGV_CheckedChanged(object sender, EventArgs e)
        {
            cbGV.Text = "";
            cbGV.DataSource = bll.layGV(cbKhoa.Text);
            if (ckbTenGV.Checked)
            {
                cbGV.DisplayMember = "hoTen";
            }
            else
            {
                cbGV.DisplayMember = "maGV";
            }
            cbGV.ValueMember = "maGV";
        }

        private void BtnDatLai_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            cbKhoa.Text = "";
            cbGV.Text = "";
            nudKhoaHoc.Value = 1;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            layThongTin();
            if (txtMaLop.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Mã lớp không được trống");
            }
            else if (cbKhoa.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Mã khoa không được trống");
            }
            else if (cbGV.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Giảng viên không được trống");
            }
            else
            {
                if (bll.suaLop(lop))
                {
                    MessageBox.Show("Sửa thành công");
                    dgvDsLopMonHoc.DataSource = bll.timKiemLop(lop.maLop);
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (bll.xoaLop(dgvDsLopMonHoc.Rows[index].Cells["colMaLop"].Value.ToString()))
                    {
                        MessageBox.Show("Xóa thành công");
                        BtnXemTatCa_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa chọn lớp");
            }

        }
        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDsLopMonHoc.DataSource = bll.timKiemLop(txtTimKiem.Text.Trim());
        }

        private void NudKhoaHoc_ValueChanged(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtMaLop.Text = maTuDong();
        }

        private void CbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtMaLop.Text = maTuDong();
        }

        private void BtnXemDsSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (index >= 0)
                {
                    string maLopMonHoc = dgvDsLopMonHoc.Rows[index].Cells[0].Value.ToString();
                    FormDsSinhVienLopMonHoc formDs = new FormDsSinhVienLopMonHoc(maLopMonHoc);
                    formDs.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn");
                }
            }
            catch (Exception)
            {

            }
        }

        private void CkbTenLopCoDinh_CheckedChanged(object sender, EventArgs e)
        {
            cbMaLopCoDinh.Text = "";
            cbMaLopCoDinh.DataSource = bll.layLopCoDinh(cbKhoa.Text);
            if (ckbTenLopCoDinh.Checked)
            {
                cbMaLopCoDinh.DisplayMember = "tenLopCoDinh";
            }
            else
            {
                cbMaLopCoDinh.DisplayMember = "maLopCoDinh";
            }
            cbMaLopCoDinh.ValueMember = "maLopCoDinh";
        }

        private void CkbTenMH_CheckedChanged(object sender, EventArgs e)
        {
            cbMonHoc.Text = "";
            cbMonHoc.DataSource = bll.layMonHoc(cbKhoa.Text);
            if (ckbTenMH.Checked)
            {
                cbMonHoc.DisplayMember = "tenMonHoc";
            }
            else
            {
                cbMonHoc.DisplayMember = "maMonHoc";
            }
            cbMonHoc.ValueMember = "maMonHoc";
        }
    }
}
