using QuanLySinhVien.BLL;
using QuanLySinhVien.Class;
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
    public partial class FormDsSinhVienLopMonHoc : Form
    {
        DsSVLopMonHocBLL bll = new DsSVLopMonHocBLL();
        SVLopMonHoc sv = new SVLopMonHoc();
        string maLopMonHoc, maKhoa;
        int index;

        public FormDsSinhVienLopMonHoc(string maLopMonHoc)
        {
            InitializeComponent();
            this.maLopMonHoc = maLopMonHoc;
        }

        private void layThongTin()
        {
            sv.maSV = cbMaSV.Text;
            sv.maLopMonHoc = maLopMonHoc;
            sv.diemLT = float.Parse(txtDiemLT.Text.ToString());
            sv.diemTH = float.Parse(txtDiemTH.Text.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDsSinhVienLopMonHoc_Load(object sender, EventArgs e)
        {
            lblTen.Text = "Danh sách sinh viên lớp: " + maLopMonHoc;
            dgvDsSinhVien.DataSource = bll.layDsSVLopMonHoc(maLopMonHoc);
            cbMaSV.DataSource = bll.layDsSinhVien();
            cbMaSV.DisplayMember = "maSV";
            cbMaSV.ValueMember = "maSV";
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDsSinhVien.DataSource = bll.timKiem(txtTimKiem.Text);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            layThongTin();
            if (cbMaSV.Text == string.Empty)
            {
                MessageBox.Show("Mã sinh viên không được trống");
            }
            else
            {
                if (bll.them(sv))
                {
                    MessageBox.Show("Thành công");
                    dgvDsSinhVien.DataSource = bll.timKiem(sv.maSV);
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            layThongTin();
            if (cbMaSV.Text == string.Empty)
            {
                MessageBox.Show("Mã sinh viên không được trống");
            }
            else
            {
                if (bll.sua(sv))
                {
                    MessageBox.Show("Thành công");
                    dgvDsSinhVien.DataSource = bll.timKiem(sv.maSV);
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên");
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có chắc xóa", "Thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (bll.xoa(cbMaSV.Text, maLopMonHoc))
                    {
                        MessageBox.Show("Thành công");
                        dgvDsSinhVien.DataSource = bll.xemTatCa(maLopMonHoc);
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
        }

        private void BtnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsSinhVien.DataSource = bll.layDsSVLopMonHoc(maLopMonHoc);
        }

        private void DgvDsSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDsSinhVien.Rows[index];
                    cbMaSV.Text = row.Cells["colMaSV"].Value.ToString();
                    txtDiemLT.Text = row.Cells["colDiemLT"].Value.ToString();
                    txtDiemTH.Text = row.Cells["colDiemTH"].Value.ToString();
                }
                catch (Exception)
                {

                }
            }
        }

    }
}
