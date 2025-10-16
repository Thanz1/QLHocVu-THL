namespace QLHocVu_THL
{
    partial class FormTaoLopHoc
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
            this.S = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.dgvLopDaTao = new System.Windows.Forms.DataGridView();
            this.btnTaoLop = new System.Windows.Forms.Button();
            this.btnChonGV = new System.Windows.Forms.Button();
            this.btnSetWindow = new System.Windows.Forms.Button();
            this.btnQuanLyMonHoc = new System.Windows.Forms.Button();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblWindowInfo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnChonHK = new System.Windows.Forms.Button();
            this.btnChonPhong = new System.Windows.Forms.Button();
            this.btnLoadLop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopDaTao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(12, 9);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(141, 29);
            this.S.TabIndex = 5;
            this.S.Text = "Tạo lớp học";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(169, 46);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 20);
            this.txtMaLop.TabIndex = 6;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(169, 86);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(100, 20);
            this.txtTenLop.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã Môn Học";
            // 
            // txtMaHK
            // 
            this.txtMaHK.Location = new System.Drawing.Point(169, 274);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.ReadOnly = true;
            this.txtMaHK.Size = new System.Drawing.Size(100, 20);
            this.txtMaHK.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ngày bắt đầu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Ngày Kết thúc";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(169, 239);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(100, 20);
            this.txtMaGV.TabIndex = 29;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(169, 309);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhong.TabIndex = 28;
            // 
            // dgvLopDaTao
            // 
            this.dgvLopDaTao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopDaTao.Location = new System.Drawing.Point(17, 369);
            this.dgvLopDaTao.Name = "dgvLopDaTao";
            this.dgvLopDaTao.Size = new System.Drawing.Size(814, 190);
            this.dgvLopDaTao.TabIndex = 30;
            this.dgvLopDaTao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopDaTao_CellClick);
            // 
            // btnTaoLop
            // 
            this.btnTaoLop.Location = new System.Drawing.Point(537, 312);
            this.btnTaoLop.Name = "btnTaoLop";
            this.btnTaoLop.Size = new System.Drawing.Size(72, 32);
            this.btnTaoLop.TabIndex = 31;
            this.btnTaoLop.Text = "Tạo lớp";
            this.btnTaoLop.UseVisualStyleBackColor = true;
            this.btnTaoLop.Click += new System.EventHandler(this.btnTaoLop_Click);
            // 
            // btnChonGV
            // 
            this.btnChonGV.Location = new System.Drawing.Point(297, 233);
            this.btnChonGV.Name = "btnChonGV";
            this.btnChonGV.Size = new System.Drawing.Size(90, 32);
            this.btnChonGV.TabIndex = 32;
            this.btnChonGV.Text = "Chọn Giáo Viên";
            this.btnChonGV.UseVisualStyleBackColor = true;
            this.btnChonGV.Click += new System.EventHandler(this.btnChonGV_Click);
            // 
            // btnSetWindow
            // 
            this.btnSetWindow.Location = new System.Drawing.Point(397, 172);
            this.btnSetWindow.Name = "btnSetWindow";
            this.btnSetWindow.Size = new System.Drawing.Size(108, 32);
            this.btnSetWindow.TabIndex = 33;
            this.btnSetWindow.Text = "Mở Đăng Ký";
            this.btnSetWindow.UseVisualStyleBackColor = true;
            this.btnSetWindow.Click += new System.EventHandler(this.btnSetWindow_Click);
            // 
            // btnQuanLyMonHoc
            // 
            this.btnQuanLyMonHoc.Location = new System.Drawing.Point(313, 117);
            this.btnQuanLyMonHoc.Name = "btnQuanLyMonHoc";
            this.btnQuanLyMonHoc.Size = new System.Drawing.Size(102, 32);
            this.btnQuanLyMonHoc.TabIndex = 31;
            this.btnQuanLyMonHoc.Text = "Quản lý môn học";
            this.btnQuanLyMonHoc.UseVisualStyleBackColor = true;
            this.btnQuanLyMonHoc.Click += new System.EventHandler(this.btnQuanLyMonHoc_Click);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(169, 124);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cboMonHoc.TabIndex = 34;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(365, 71);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 20);
            this.numSoLuong.TabIndex = 35;
            this.numSoLuong.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(169, 166);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 36;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(169, 200);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 37;
            // 
            // lblWindowInfo
            // 
            this.lblWindowInfo.AutoSize = true;
            this.lblWindowInfo.Location = new System.Drawing.Point(511, 182);
            this.lblWindowInfo.Name = "lblWindowInfo";
            this.lblWindowInfo.Size = new System.Drawing.Size(98, 13);
            this.lblWindowInfo.TabIndex = 38;
            this.lblWindowInfo.Text = "Trạng thái thời gian";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(310, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Số lượng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(78, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Mã Giáo Viên";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(78, 278);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Mã Học Kỳ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(79, 313);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Mã Phòng";
            // 
            // btnChonHK
            // 
            this.btnChonHK.Location = new System.Drawing.Point(297, 268);
            this.btnChonHK.Name = "btnChonHK";
            this.btnChonHK.Size = new System.Drawing.Size(90, 32);
            this.btnChonHK.TabIndex = 32;
            this.btnChonHK.Text = "Chọn Học Kỳ";
            this.btnChonHK.UseVisualStyleBackColor = true;
            this.btnChonHK.Click += new System.EventHandler(this.btnChonHK_Click);
            // 
            // btnChonPhong
            // 
            this.btnChonPhong.Location = new System.Drawing.Point(297, 303);
            this.btnChonPhong.Name = "btnChonPhong";
            this.btnChonPhong.Size = new System.Drawing.Size(90, 32);
            this.btnChonPhong.TabIndex = 32;
            this.btnChonPhong.Text = "Chọn Phòng";
            this.btnChonPhong.UseVisualStyleBackColor = true;
            this.btnChonPhong.Click += new System.EventHandler(this.btnChonPhong_Click);
            // 
            // btnLoadLop
            // 
            this.btnLoadLop.Location = new System.Drawing.Point(459, 313);
            this.btnLoadLop.Name = "btnLoadLop";
            this.btnLoadLop.Size = new System.Drawing.Size(72, 32);
            this.btnLoadLop.TabIndex = 31;
            this.btnLoadLop.Text = "Lớp đã tạo";
            this.btnLoadLop.UseVisualStyleBackColor = true;
            this.btnLoadLop.Click += new System.EventHandler(this.btnLoadLop_Click);
            // 
            // FormTaoLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 582);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblWindowInfo);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.btnSetWindow);
            this.Controls.Add(this.btnChonPhong);
            this.Controls.Add(this.btnChonHK);
            this.Controls.Add(this.btnChonGV);
            this.Controls.Add(this.btnQuanLyMonHoc);
            this.Controls.Add(this.btnLoadLop);
            this.Controls.Add(this.btnTaoLop);
            this.Controls.Add(this.dgvLopDaTao);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMaHK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.S);
            this.Name = "FormTaoLopHoc";
            this.Text = "FormTaoLopHoc";
            this.Load += new System.EventHandler(this.FormTaoLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopDaTao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label S;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.DataGridView dgvLopDaTao;
        private System.Windows.Forms.Button btnTaoLop;
        private System.Windows.Forms.Button btnChonGV;
        private System.Windows.Forms.Button btnSetWindow;
        private System.Windows.Forms.Button btnQuanLyMonHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblWindowInfo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnChonHK;
        private System.Windows.Forms.Button btnChonPhong;
        private System.Windows.Forms.Button btnLoadLop;
    }
}