namespace QuanLySinhVien.GUI
{
    partial class UcLopMonHoc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDsLopMonHoc = new System.Windows.Forms.DataGridView();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLopCoDinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.nudKhoaHoc = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ckbTenGV = new System.Windows.Forms.CheckBox();
            this.cbGV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.ckbTenMH = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaLopCoDinh = new System.Windows.Forms.ComboBox();
            this.btnXemDsSV = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.ckbTenLopCoDinh = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLopMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý lớp môn học";
            // 
            // dgvDsLopMonHoc
            // 
            this.dgvDsLopMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDsLopMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsLopMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLop,
            this.colMaLopCoDinh,
            this.colMaKhoa,
            this.colKhoaHoc,
            this.colMaGV,
            this.colMaMonHoc});
            this.dgvDsLopMonHoc.Location = new System.Drawing.Point(-3, 287);
            this.dgvDsLopMonHoc.Name = "dgvDsLopMonHoc";
            this.dgvDsLopMonHoc.Size = new System.Drawing.Size(835, 200);
            this.dgvDsLopMonHoc.TabIndex = 3;
            this.dgvDsLopMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDsLopMonHoc_CellClick);
            // 
            // colMaLop
            // 
            this.colMaLop.DataPropertyName = "maLopMonHoc";
            this.colMaLop.HeaderText = "Mã lớp";
            this.colMaLop.Name = "colMaLop";
            // 
            // colMaLopCoDinh
            // 
            this.colMaLopCoDinh.DataPropertyName = "maLopCoDinh";
            this.colMaLopCoDinh.HeaderText = "Mã lớp ưu tiên";
            this.colMaLopCoDinh.Name = "colMaLopCoDinh";
            this.colMaLopCoDinh.Width = 120;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.DataPropertyName = "maKhoa";
            this.colMaKhoa.HeaderText = "Mã khoa";
            this.colMaKhoa.Name = "colMaKhoa";
            // 
            // colKhoaHoc
            // 
            this.colKhoaHoc.DataPropertyName = "khoaHoc";
            this.colKhoaHoc.HeaderText = "Khóa học";
            this.colKhoaHoc.Name = "colKhoaHoc";
            // 
            // colMaGV
            // 
            this.colMaGV.DataPropertyName = "maGV";
            this.colMaGV.HeaderText = "Mã GV";
            this.colMaGV.Name = "colMaGV";
            // 
            // colMaMonHoc
            // 
            this.colMaMonHoc.DataPropertyName = "maMonHoc";
            this.colMaMonHoc.HeaderText = "Mã môn học";
            this.colMaMonHoc.Name = "colMaMonHoc";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(451, 33);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(282, 30);
            this.txtTimKiem.TabIndex = 20;
            this.txtTimKiem.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tìm kiếm";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(114, 69);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(277, 21);
            this.cbKhoa.TabIndex = 38;
            this.cbKhoa.SelectedValueChanged += new System.EventHandler(this.CbKhoa_SelectedValueChanged);
            // 
            // nudKhoaHoc
            // 
            this.nudKhoaHoc.Location = new System.Drawing.Point(114, 95);
            this.nudKhoaHoc.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudKhoaHoc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKhoaHoc.Name = "nudKhoaHoc";
            this.nudKhoaHoc.Size = new System.Drawing.Size(277, 20);
            this.nudKhoaHoc.TabIndex = 39;
            this.nudKhoaHoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKhoaHoc.ValueChanged += new System.EventHandler(this.NudKhoaHoc_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Khóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Khoa";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(114, 43);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(277, 20);
            this.txtMaLop.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Mã lớp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Mã môn học";
            // 
            // ckbTenGV
            // 
            this.ckbTenGV.AutoSize = true;
            this.ckbTenGV.Checked = true;
            this.ckbTenGV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbTenGV.Location = new System.Drawing.Point(32, 178);
            this.ckbTenGV.Name = "ckbTenGV";
            this.ckbTenGV.Size = new System.Drawing.Size(63, 17);
            this.ckbTenGV.TabIndex = 48;
            this.ckbTenGV.Text = "Tên GV";
            this.ckbTenGV.UseVisualStyleBackColor = true;
            this.ckbTenGV.CheckedChanged += new System.EventHandler(this.CkbTenGV_CheckedChanged);
            // 
            // cbGV
            // 
            this.cbGV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGV.FormattingEnabled = true;
            this.cbGV.Location = new System.Drawing.Point(114, 159);
            this.cbGV.Name = "cbGV";
            this.cbGV.Size = new System.Drawing.Size(277, 21);
            this.cbGV.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Mã giảng viên";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMonHoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(114, 197);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(277, 21);
            this.cbMonHoc.TabIndex = 47;
            this.cbMonHoc.SelectedValueChanged += new System.EventHandler(this.CbMonHoc_SelectedValueChanged);
            // 
            // ckbTenMH
            // 
            this.ckbTenMH.AutoSize = true;
            this.ckbTenMH.Checked = true;
            this.ckbTenMH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbTenMH.Location = new System.Drawing.Point(31, 216);
            this.ckbTenMH.Name = "ckbTenMH";
            this.ckbTenMH.Size = new System.Drawing.Size(65, 17);
            this.ckbTenMH.TabIndex = 48;
            this.ckbTenMH.Text = "Tên MH";
            this.ckbTenMH.UseVisualStyleBackColor = true;
            this.ckbTenMH.CheckedChanged += new System.EventHandler(this.CkbTenMH_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Mã lớp ưu tiên";
            // 
            // cbMaLopCoDinh
            // 
            this.cbMaLopCoDinh.FormattingEnabled = true;
            this.cbMaLopCoDinh.Location = new System.Drawing.Point(114, 121);
            this.cbMaLopCoDinh.Name = "cbMaLopCoDinh";
            this.cbMaLopCoDinh.Size = new System.Drawing.Size(277, 21);
            this.cbMaLopCoDinh.TabIndex = 38;
            // 
            // btnXemDsSV
            // 
            this.btnXemDsSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDsSV.Image = global::QuanLySinhVien.Properties.Resources.icons8_view_48;
            this.btnXemDsSV.Location = new System.Drawing.Point(661, 219);
            this.btnXemDsSV.Name = "btnXemDsSV";
            this.btnXemDsSV.Size = new System.Drawing.Size(138, 61);
            this.btnXemDsSV.TabIndex = 24;
            this.btnXemDsSV.Text = "Xem Ds sinh viên";
            this.btnXemDsSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemDsSV.UseVisualStyleBackColor = true;
            this.btnXemDsSV.Click += new System.EventHandler(this.BtnXemDsSV_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLai.Image = global::QuanLySinhVien.Properties.Resources.icons8_synchronize_48;
            this.btnDatLai.Location = new System.Drawing.Point(451, 219);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(138, 61);
            this.btnDatLai.TabIndex = 24;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.BtnDatLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLySinhVien.Properties.Resources.icons8_plus_48;
            this.btnThem.Location = new System.Drawing.Point(451, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 61);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLySinhVien.Properties.Resources.icons8_delete_48;
            this.btnXoa.Location = new System.Drawing.Point(661, 145);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 61);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTatCa.Image = global::QuanLySinhVien.Properties.Resources.icons8_select_all_48;
            this.btnXemTatCa.Location = new System.Drawing.Point(451, 78);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(138, 61);
            this.btnXemTatCa.TabIndex = 22;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.BtnXemTatCa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLySinhVien.Properties.Resources.icons8_wrench_48;
            this.btnSua.Location = new System.Drawing.Point(661, 78);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 61);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::QuanLySinhVien.Properties.Resources.icons8_search_25;
            this.btnTimKiem.Location = new System.Drawing.Point(739, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(60, 30);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // ckbTenLopCoDinh
            // 
            this.ckbTenLopCoDinh.AutoSize = true;
            this.ckbTenLopCoDinh.Checked = true;
            this.ckbTenLopCoDinh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbTenLopCoDinh.Location = new System.Drawing.Point(32, 142);
            this.ckbTenLopCoDinh.Name = "ckbTenLopCoDinh";
            this.ckbTenLopCoDinh.Size = new System.Drawing.Size(80, 17);
            this.ckbTenLopCoDinh.TabIndex = 48;
            this.ckbTenLopCoDinh.Text = "Tên lớp ƯT";
            this.ckbTenLopCoDinh.UseVisualStyleBackColor = true;
            this.ckbTenLopCoDinh.CheckedChanged += new System.EventHandler(this.CkbTenLopCoDinh_CheckedChanged);
            // 
            // UcLopMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckbTenMH);
            this.Controls.Add(this.ckbTenLopCoDinh);
            this.Controls.Add(this.ckbTenGV);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.cbGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbMaLopCoDinh);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.nudKhoaHoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXemDsSV);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDsLopMonHoc);
            this.Controls.Add(this.label1);
            this.Name = "UcLopMonHoc";
            this.Size = new System.Drawing.Size(832, 487);
            this.Load += new System.EventHandler(this.UcLopMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLopMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoaHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDsLopMonHoc;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXemTatCa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.NumericUpDown nudKhoaHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXemDsSV;
        private System.Windows.Forms.CheckBox ckbTenGV;
        private System.Windows.Forms.ComboBox cbGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.CheckBox ckbTenMH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMaLopCoDinh;
        private System.Windows.Forms.CheckBox ckbTenLopCoDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLopCoDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMonHoc;
    }
}
