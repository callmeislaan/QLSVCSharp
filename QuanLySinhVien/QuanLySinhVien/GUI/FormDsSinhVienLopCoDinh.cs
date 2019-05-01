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
    public partial class FormDsSinhVienLopCoDinh : Form
    {
        public FormDsSinhVienLopCoDinh(string maLopCoDinh)
        {
            InitializeComponent();
            this.maLopCoDinh = maLopCoDinh;
        }
        DsSVLopCoDinhBLL bll = new DsSVLopCoDinhBLL();
        SVLopCoDinh sv = new SVLopCoDinh();
        string maLopCoDinh;

        private void layThongTin()
        {
            sv.maLopCoDinh = maLopCoDinh;
        }

        private void FormDsSinhVienLopCoDinh_Load(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Danh sách sinh viên lớp: " + maLopCoDinh;
            dgvDsSinhVien.DataSource = bll.layDsSVLopCoDinh(maLopCoDinh);
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDsSinhVien.DataSource = bll.timKiem(txtTimKiem.Text.Trim(), maLopCoDinh);
        }

       
        private void BtnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsSinhVien.DataSource = bll.layDsSVLopCoDinh(maLopCoDinh);
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
