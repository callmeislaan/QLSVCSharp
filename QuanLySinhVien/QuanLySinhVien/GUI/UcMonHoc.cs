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
    public partial class UcMonHoc : UserControl
    {
        MonHocBLL bll = new MonHocBLL();
        MonHoc mon = new MonHoc();
        int index;

        public UcMonHoc()
        {
            InitializeComponent();
        }

        private void layThongTin()
        {
            mon.maMon = txtMaMon.Text.Trim();
            mon.tenMon = txtTenMon.Text.Trim();
            mon.soTinChiLT = int.Parse(nudSoTCLT.Value.ToString());
            mon.soTinChiTH = int.Parse(nudSoTCTH.Value.ToString());
            mon.maKhoa = cbMaKhoa.Text;
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void BtnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsMonHoc.DataSource = bll.xemTatCa();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            layThongTin();
            if (mon.maMon == string.Empty)
            {
                MessageBox.Show("Mã môn không được trống");
            }
            else if (mon.tenMon == string.Empty)
            {
                MessageBox.Show("Tên môn không được trống");
            }
            else if (mon.soTinChiLT == 0 && mon.soTinChiTH == 0)
            {
                MessageBox.Show("Chưa có số tín chỉ");
            }
            else
            {
                if (bll.themMonHoc(mon))
                {
                    MessageBox.Show("Thành công");
                    dgvDsMonHoc.DataSource = bll.timKiemMonHoc(txtMaMon.Text);
                    BtnDatLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        private void BtnDatLai_Click(object sender, EventArgs e)
        {
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            nudSoTCLT.Value = 0;
            nudSoTCTH.Value = 0;
            cbMaKhoa.Text = "";
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            layThongTin();
            if (mon.maMon == string.Empty)
            {
                MessageBox.Show("Mã môn không được trống");
            }
            else if (mon.tenMon == string.Empty)
            {
                MessageBox.Show("Tên môn không được trống");
            }
            else if (mon.soTinChiLT == 0 && mon.soTinChiTH == 0)
            {
                MessageBox.Show("Chưa có số tín chỉ");
            }
            else
            {
                if (bll.suaMonHoc(mon))
                {
                    MessageBox.Show("Thành công");
                    dgvDsMonHoc.DataSource = bll.timKiemMonHoc(txtMaMon.Text);
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult chon = MessageBox.Show("Bạn có chắc muốn xóa: " + txtTenMon.Text, "Thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (bll.xoaMonHoc(txtMaMon.Text.Trim()))
                    {
                        MessageBox.Show("Thành công");
                        BtnXemTatCa_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa chọn");
            }
        }

        private void DgvDsMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDsMonHoc.Rows[index];
                    txtMaMon.Text = row.Cells["colMaMon"].Value.ToString();
                    txtTenMon.Text = row.Cells["colTenMon"].Value.ToString();
                    nudSoTCLT.Text = row.Cells["colSoTCLT"].Value.ToString();
                    nudSoTCTH.Text = row.Cells["colSoTCTH"].Value.ToString();
                    cbMaKhoa.Text = row.Cells["colMaKhoa"].Value.ToString();
                }
                catch (Exception)
                {

                }
            }
        }

        private void UcMonHoc_Load(object sender, EventArgs e)
        {
            cbMaKhoa.DataSource = bll.layKhoa();
            cbMaKhoa.DisplayMember = "maKhoa";
            cbMaKhoa.ValueMember = "tenKhoa";
        }
    }
}
