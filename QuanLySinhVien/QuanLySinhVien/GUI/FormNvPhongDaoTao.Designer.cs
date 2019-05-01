namespace QuanLySinhVien.GUI
{
    partial class FormNvPhongDaoTao
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnQLSinhVien = new System.Windows.Forms.Button();
            this.btnQLGiangVien = new System.Windows.Forms.Button();
            this.btnQLLopHoc = new System.Windows.Forms.Button();
            this.btnQLLopMonHoc = new System.Windows.Forms.Button();
            this.btnQLKhoa = new System.Windows.Forms.Button();
            this.btnQLMonHoc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miTen = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tlpMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMenu
            // 
            this.tlpMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tlpMenu.ColumnCount = 1;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMenu.Controls.Add(this.btnQLSinhVien, 0, 0);
            this.tlpMenu.Controls.Add(this.btnQLGiangVien, 0, 1);
            this.tlpMenu.Controls.Add(this.btnQLLopHoc, 0, 2);
            this.tlpMenu.Controls.Add(this.btnQLLopMonHoc, 0, 3);
            this.tlpMenu.Controls.Add(this.btnQLKhoa, 0, 5);
            this.tlpMenu.Controls.Add(this.btnQLMonHoc, 0, 4);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpMenu.Location = new System.Drawing.Point(0, 24);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 6;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.Size = new System.Drawing.Size(125, 487);
            this.tlpMenu.TabIndex = 0;
            // 
            // btnQLSinhVien
            // 
            this.btnQLSinhVien.AutoSize = true;
            this.btnQLSinhVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnQLSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSinhVien.Image = global::QuanLySinhVien.Properties.Resources.icons8_student_male_48;
            this.btnQLSinhVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLSinhVien.Location = new System.Drawing.Point(3, 3);
            this.btnQLSinhVien.Name = "btnQLSinhVien";
            this.btnQLSinhVien.Size = new System.Drawing.Size(118, 72);
            this.btnQLSinhVien.TabIndex = 0;
            this.btnQLSinhVien.Text = "Quản lý sinh viên";
            this.btnQLSinhVien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLSinhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLSinhVien.UseCompatibleTextRendering = true;
            this.btnQLSinhVien.UseVisualStyleBackColor = false;
            this.btnQLSinhVien.Click += new System.EventHandler(this.BtnQLSinhVien_Click);
            // 
            // btnQLGiangVien
            // 
            this.btnQLGiangVien.AutoSize = true;
            this.btnQLGiangVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnQLGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLGiangVien.Image = global::QuanLySinhVien.Properties.Resources.icons8_school_director_48;
            this.btnQLGiangVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLGiangVien.Location = new System.Drawing.Point(3, 84);
            this.btnQLGiangVien.Name = "btnQLGiangVien";
            this.btnQLGiangVien.Size = new System.Drawing.Size(118, 72);
            this.btnQLGiangVien.TabIndex = 1;
            this.btnQLGiangVien.Text = "Quản lý Giảng viên";
            this.btnQLGiangVien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLGiangVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLGiangVien.UseCompatibleTextRendering = true;
            this.btnQLGiangVien.UseVisualStyleBackColor = false;
            this.btnQLGiangVien.Click += new System.EventHandler(this.BtnQLGiangVien_Click);
            // 
            // btnQLLopHoc
            // 
            this.btnQLLopHoc.AutoSize = true;
            this.btnQLLopHoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnQLLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLopHoc.Image = global::QuanLySinhVien.Properties.Resources.icons8_class_48;
            this.btnQLLopHoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLLopHoc.Location = new System.Drawing.Point(3, 165);
            this.btnQLLopHoc.Name = "btnQLLopHoc";
            this.btnQLLopHoc.Size = new System.Drawing.Size(118, 72);
            this.btnQLLopHoc.TabIndex = 2;
            this.btnQLLopHoc.Text = "Quản lý lớp cố định";
            this.btnQLLopHoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLLopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLLopHoc.UseCompatibleTextRendering = true;
            this.btnQLLopHoc.UseVisualStyleBackColor = false;
            this.btnQLLopHoc.Click += new System.EventHandler(this.BtnQLLopHoc_Click);
            // 
            // btnQLLopMonHoc
            // 
            this.btnQLLopMonHoc.AutoSize = true;
            this.btnQLLopMonHoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnQLLopMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLopMonHoc.Image = global::QuanLySinhVien.Properties.Resources.icons8_classroom_48;
            this.btnQLLopMonHoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLLopMonHoc.Location = new System.Drawing.Point(3, 246);
            this.btnQLLopMonHoc.Name = "btnQLLopMonHoc";
            this.btnQLLopMonHoc.Size = new System.Drawing.Size(118, 72);
            this.btnQLLopMonHoc.TabIndex = 3;
            this.btnQLLopMonHoc.Text = "Quản lý lớp môn học";
            this.btnQLLopMonHoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLLopMonHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLLopMonHoc.UseCompatibleTextRendering = true;
            this.btnQLLopMonHoc.UseVisualStyleBackColor = false;
            this.btnQLLopMonHoc.Click += new System.EventHandler(this.BtnQLLopMonHoc_Click);
            // 
            // btnQLKhoa
            // 
            this.btnQLKhoa.AutoSize = true;
            this.btnQLKhoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnQLKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKhoa.Image = global::QuanLySinhVien.Properties.Resources.icons8_university_48;
            this.btnQLKhoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLKhoa.Location = new System.Drawing.Point(3, 408);
            this.btnQLKhoa.Name = "btnQLKhoa";
            this.btnQLKhoa.Size = new System.Drawing.Size(118, 72);
            this.btnQLKhoa.TabIndex = 5;
            this.btnQLKhoa.Text = "Quản lý khoa";
            this.btnQLKhoa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLKhoa.UseCompatibleTextRendering = true;
            this.btnQLKhoa.UseVisualStyleBackColor = false;
            this.btnQLKhoa.Click += new System.EventHandler(this.BtnQLKhoa_Click);
            // 
            // btnQLMonHoc
            // 
            this.btnQLMonHoc.AutoSize = true;
            this.btnQLMonHoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnQLMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMonHoc.Image = global::QuanLySinhVien.Properties.Resources.icons8_elective_48;
            this.btnQLMonHoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLMonHoc.Location = new System.Drawing.Point(3, 327);
            this.btnQLMonHoc.Name = "btnQLMonHoc";
            this.btnQLMonHoc.Size = new System.Drawing.Size(118, 72);
            this.btnQLMonHoc.TabIndex = 4;
            this.btnQLMonHoc.Text = "Quản lý môn học";
            this.btnQLMonHoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLMonHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLMonHoc.UseCompatibleTextRendering = true;
            this.btnQLMonHoc.UseVisualStyleBackColor = false;
            this.btnQLMonHoc.Click += new System.EventHandler(this.BtnQLMonHoc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTen});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miTen
            // 
            this.miTen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.miTen.Name = "miTen";
            this.miTen.Size = new System.Drawing.Size(133, 20);
            this.miTen.Text = "Hoàng Trường Phước";
            // 
            // xemThôngTinCáNhânToolStripMenuItem
            // 
            this.xemThôngTinCáNhânToolStripMenuItem.Name = "xemThôngTinCáNhânToolStripMenuItem";
            this.xemThôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xemThôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMain.BackgroundImage = global::QuanLySinhVien.Properties.Resources.haui3;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(125, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(832, 487);
            this.pnlMain.TabIndex = 1;
            // 
            // FormNvPhongDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(957, 511);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tlpMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormNvPhongDaoTao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNvPhongDaoTao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNvPhongDaoTao_FormClosing);
            this.Load += new System.EventHandler(this.FormNvPhongDaoTao_Load);
            this.tlpMenu.ResumeLayout(false);
            this.tlpMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLMonHoc;
        private System.Windows.Forms.Button btnQLKhoa;
        private System.Windows.Forms.Button btnQLLopMonHoc;
        private System.Windows.Forms.Button btnQLLopHoc;
        private System.Windows.Forms.Button btnQLGiangVien;
        private System.Windows.Forms.Button btnQLSinhVien;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miTen;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}