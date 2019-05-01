namespace QuanLySinhVien.GUI
{
    partial class UcLopHoc
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
            this.dgvDsLopHoc = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.nudKhoaHoc = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaLopDau = new System.Windows.Forms.TextBox();
            this.cbGV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbTenGV = new System.Windows.Forms.CheckBox();
            this.btnXemDsSinhVien = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý lớp học cố định";
            // 
            // dgvDsLopHoc
            // 
            this.dgvDsLopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDsLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLop,
            this.colTenLop,
            this.colMaKhoa,
            this.colKhoaHoc,
            this.colMaGV});
            this.dgvDsLopHoc.Location = new System.Drawing.Point(0, 287);
            this.dgvDsLopHoc.Name = "dgvDsLopHoc";
            this.dgvDsLopHoc.Size = new System.Drawing.Size(832, 200);
            this.dgvDsLopHoc.TabIndex = 3;
            this.dgvDsLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDsLopHoc_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(447, 33);
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
            this.label2.Location = new System.Drawing.Point(393, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tìm kiếm";
            // 
            // cbKhoa
            // 
            this.cbKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(113, 129);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(277, 21);
            this.cbKhoa.TabIndex = 38;
            this.cbKhoa.SelectedValueChanged += new System.EventHandler(this.CbKhoa_SelectedValueChanged);
            // 
            // nudKhoaHoc
            // 
            this.nudKhoaHoc.Location = new System.Drawing.Point(113, 155);
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
            this.label5.Location = new System.Drawing.Point(28, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Khóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Khoa";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(113, 103);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(277, 20);
            this.txtTenLop.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tên lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(161, 77);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(229, 20);
            this.txtMaLop.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Mã lớp";
            // 
            // txtMaLopDau
            // 
            this.txtMaLopDau.Location = new System.Drawing.Point(113, 77);
            this.txtMaLopDau.Name = "txtMaLopDau";
            this.txtMaLopDau.ReadOnly = true;
            this.txtMaLopDau.Size = new System.Drawing.Size(42, 20);
            this.txtMaLopDau.TabIndex = 35;
            this.txtMaLopDau.Text = "K01";
            // 
            // cbGV
            // 
            this.cbGV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGV.FormattingEnabled = true;
            this.cbGV.Location = new System.Drawing.Point(113, 181);
            this.cbGV.Name = "cbGV";
            this.cbGV.Size = new System.Drawing.Size(277, 21);
            this.cbGV.TabIndex = 38;
            this.cbGV.SelectedIndexChanged += new System.EventHandler(this.CbKhoa_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Mã giảng viên";
            // 
            // ckbTenGV
            // 
            this.ckbTenGV.AutoSize = true;
            this.ckbTenGV.Location = new System.Drawing.Point(31, 200);
            this.ckbTenGV.Name = "ckbTenGV";
            this.ckbTenGV.Size = new System.Drawing.Size(63, 17);
            this.ckbTenGV.TabIndex = 41;
            this.ckbTenGV.Text = "Tên GV";
            this.ckbTenGV.UseVisualStyleBackColor = true;
            this.ckbTenGV.CheckedChanged += new System.EventHandler(this.CkbTenGV_CheckedChanged);
            // 
            // btnXemDsSinhVien
            // 
            this.btnXemDsSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDsSinhVien.Image = global::QuanLySinhVien.Properties.Resources.icons8_view_48;
            this.btnXemDsSinhVien.Location = new System.Drawing.Point(657, 219);
            this.btnXemDsSinhVien.Name = "btnXemDsSinhVien";
            this.btnXemDsSinhVien.Size = new System.Drawing.Size(138, 61);
            this.btnXemDsSinhVien.TabIndex = 24;
            this.btnXemDsSinhVien.Text = "Xem Ds sinh viên";
            this.btnXemDsSinhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemDsSinhVien.UseVisualStyleBackColor = true;
            this.btnXemDsSinhVien.Click += new System.EventHandler(this.BtnXemDsSinhVien_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLai.Image = global::QuanLySinhVien.Properties.Resources.icons8_synchronize_48;
            this.btnDatLai.Location = new System.Drawing.Point(447, 219);
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
            this.btnThem.Location = new System.Drawing.Point(447, 145);
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
            this.btnXoa.Location = new System.Drawing.Point(657, 145);
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
            this.btnXemTatCa.Location = new System.Drawing.Point(447, 78);
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
            this.btnSua.Location = new System.Drawing.Point(657, 78);
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
            this.btnTimKiem.Location = new System.Drawing.Point(735, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(60, 30);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // colMaLop
            // 
            this.colMaLop.DataPropertyName = "maLopCoDinh";
            this.colMaLop.HeaderText = "Mã lớp";
            this.colMaLop.Name = "colMaLop";
            // 
            // colTenLop
            // 
            this.colTenLop.DataPropertyName = "tenLopCoDinh";
            this.colTenLop.HeaderText = "Tên lớp";
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.Width = 150;
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
            this.colMaGV.HeaderText = "Mã giảng viên";
            this.colMaGV.Name = "colMaGV";
            // 
            // UcLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckbTenGV);
            this.Controls.Add(this.cbGV);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.nudKhoaHoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaLopDau);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXemDsSinhVien);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDsLopHoc);
            this.Controls.Add(this.label1);
            this.Name = "UcLopHoc";
            this.Size = new System.Drawing.Size(832, 487);
            this.Load += new System.EventHandler(this.UcLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoaHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDsLopHoc;
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
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXemDsSinhVien;
        private System.Windows.Forms.TextBox txtMaLopDau;
        private System.Windows.Forms.ComboBox cbGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
    }
}
