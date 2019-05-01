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
    public partial class UcLopHoc : UserControl
    {
        int index;
        LopCoDinh lop = new LopCoDinh();

        LopCoDinhBLL bll = new LopCoDinhBLL();

        public UcLopHoc()
        {
            InitializeComponent();
        }

        private void layThongTin()
        {
            lop.maLop = txtMaLopDau.Text + txtMaLop.Text.Trim();
            lop.tenLop = txtTenLop.Text.Trim();
            lop.khoaHoc = int.Parse(nudKhoaHoc.Value.ToString());
            lop.maKhoa = cbKhoa.Text;
            lop.maGV = cbGV.Text == string.Empty ? "" : cbGV.SelectedValue.ToString();
        }

        private void DgvDsLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDsLopHoc.Rows[index];
                    cbKhoa.Text = row.Cells["colMaKhoa"].Value.ToString();
                    txtTenLop.Text = row.Cells["colTenLop"].Value.ToString();
                    cbGV.Text = row.Cells["colMaGV"].Value.ToString();
                    nudKhoaHoc.Value = int.Parse(row.Cells["colKhoaHoc"].Value.ToString());
                    txtMaLopDau.Text = row.Cells["colMaLop"].Value.ToString().Substring(0, 3);
                    txtMaLop.Text = row.Cells["colMaLop"].Value.ToString().Substring(3);
                }
                catch (Exception)
                {

                }
            }
        }

        private void UcLopHoc_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = bll.layKhoa();
            cbKhoa.ValueMember = "maKhoa";
            cbKhoa.DisplayMember = "maKhoa";
        }

        private void BtnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsLopHoc.DataSource = bll.xemTatCa();
        }

        private void NudKhoaHoc_ValueChanged(object sender, EventArgs e)
        {
            if (nudKhoaHoc.Value < 10)
            {
                txtMaLopDau.Text = "K0" + nudKhoaHoc.Value;
            }
            else
            {
                txtMaLopDau.Text = "K" + nudKhoaHoc.Value;
            }

        }

        private void CbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            else
            {
                if (bll.themLop(lop))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDsLopHoc.DataSource = bll.timKiemLop(lop.maLop);
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void CkbTenGV_CheckedChanged(object sender, EventArgs e)
        {
            CbKhoa_SelectedValueChanged(sender, e);
        }

        private void BtnDatLai_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtMaLopDau.Text = "K01";
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
                    dgvDsLopHoc.DataSource = bll.timKiemLop(lop.maLop);
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
                DialogResult chon = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo);

                if (chon == DialogResult.Yes)
                {
                    if (bll.xoaLop(dgvDsLopHoc.Rows[index].Cells["colMaLop"].Value.ToString()))
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
            dgvDsLopHoc.DataSource = bll.timKiemLop(txtTimKiem.Text.Trim());
        }

        private void BtnXemDsSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (index >= 0)
                {
                    string maLopCoDinh = dgvDsLopHoc.Rows[index].Cells[0].Value.ToString();
                    FormDsSinhVienLopCoDinh formDs = new FormDsSinhVienLopCoDinh(maLopCoDinh);
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
    }
}
