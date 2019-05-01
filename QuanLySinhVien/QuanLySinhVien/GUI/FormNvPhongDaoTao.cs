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
    public partial class FormNvPhongDaoTao : Form
    {
        string maNV;
        public FormNvPhongDaoTao(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private void chuyenDoi(UserControl uc)
        {
            pnlMain.BackgroundImage = null;
            pnlMain.Controls.Clear();
            uc.Anchor = AnchorStyles.Top;
            uc.Anchor = AnchorStyles.Left;
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormNvPhongDaoTao_Load(object sender, EventArgs e)
        {
            //DataTable dt = new NVPhongDaoTaoBLL().layNV(maNV);
            //miTen.Text = dt.Rows[1][0].ToString();
        }

        private void BtnQLSinhVien_Click(object sender, EventArgs e)
        {
            UcSinhVien ucSinhVien = new UcSinhVien();
            chuyenDoi(ucSinhVien);
        }

        private void BtnQLGiangVien_Click(object sender, EventArgs e)
        {
            UcGiangVien ucGiangVien = new UcGiangVien();
            chuyenDoi(ucGiangVien);
        }

        private void BtnQLLopHoc_Click(object sender, EventArgs e)
        {
            UcLopHoc ucLopHoc = new UcLopHoc();
            chuyenDoi(ucLopHoc);
        }

        private void BtnQLLopMonHoc_Click(object sender, EventArgs e)
        {
            UcLopMonHoc ucLopMonHoc = new UcLopMonHoc();
            chuyenDoi(ucLopMonHoc);
        }

        private void BtnQLKhoa_Click(object sender, EventArgs e)
        {
            UcKhoa ucKhoa = new UcKhoa();
            chuyenDoi(ucKhoa);
        }

        private void BtnQLMonHoc_Click(object sender, EventArgs e)
        {
            UcMonHoc ucMonHoc = new UcMonHoc();
            chuyenDoi(ucMonHoc);
        }

        private void FormNvPhongDaoTao_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
