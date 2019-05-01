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
    public partial class UcKhoa : UserControl
    {
        Khoa khoa = new Khoa();
        KhoaBLL bll = new KhoaBLL();
        int index;

        public UcKhoa()
        {
            InitializeComponent();
        }

        private void layThongTinKhoa()
        {
            khoa.maKhoa = txtMaKhoa.Text.Trim();
            khoa.tenKhoa = txtTenKhoa.Text.Trim();
            khoa.truongKhoa = txtTruongKhoa.Text.Trim();
        }

        private void BtnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsKhoa.DataSource = bll.xemTatCa();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            layThongTinKhoa();
            if (khoa.maKhoa == string.Empty)
            {
                MessageBox.Show("Mã khoa không được trống");
            }
            else if (khoa.tenKhoa == string.Empty)
            {
                MessageBox.Show("Tên khoa không được trống");
            }
            else if (khoa.truongKhoa == string.Empty)
            {
                MessageBox.Show("Trưởng khoa không được trống");
            }
            else
            {
                if (bll.themKhoa(khoa))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDsKhoa.DataSource = bll.timKiemKhoa(khoa.maKhoa);
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDsKhoa.DataSource = bll.timKiemKhoa(txtTimKiem.Text.Trim());
        }

        private void BtnDatLai_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtTruongKhoa.Text = "";
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            layThongTinKhoa();
            if (khoa.maKhoa == string.Empty)
            {
                MessageBox.Show("Mã khoa không được trống");
            }
            else if (khoa.tenKhoa == string.Empty)
            {
                MessageBox.Show("Tên khoa không được trống");
            }
            else if (khoa.truongKhoa == string.Empty)
            {
                MessageBox.Show("Trưởng khoa không được trống");
            }
            else
            {
                if (bll.suaKhoa(khoa))
                {
                    MessageBox.Show("Sửa thành công");
                    dgvDsKhoa.DataSource = bll.timKiemKhoa(khoa.maKhoa);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
        }

        private void DgvDsKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    txtMaKhoa.Text = dgvDsKhoa.Rows[index].Cells["colMaKhoa"].Value.ToString();
                    txtTenKhoa.Text = dgvDsKhoa.Rows[index].Cells["colTenKhoa"].Value.ToString();
                    txtTruongKhoa.Text = dgvDsKhoa.Rows[index].Cells["colTruongKhoa"].Value.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn chưa chọn khoa");
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc xóa khoa: " + txtTenKhoa.Text, "Thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                if (bll.xoaKhoa(txtMaKhoa.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    BtnXemTatCa_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");

            }
        }
    }
}
