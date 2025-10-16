namespace QLHocVu_THL
{
    partial class FormDangKyMon
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
            this.btnHuyDangKy = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.dgvLopConCho = new System.Windows.Forms.DataGridView();
            this.S = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDaDangKy = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWindowInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopConCho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.Location = new System.Drawing.Point(582, 368);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(102, 38);
            this.btnHuyDangKy.TabIndex = 1;
            this.btnHuyDangKy.Text = "Hủy đăng ký";
            this.btnHuyDangKy.UseVisualStyleBackColor = true;
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(379, 369);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(102, 37);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // dgvLopConCho
            // 
            this.dgvLopConCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopConCho.Location = new System.Drawing.Point(17, 86);
            this.dgvLopConCho.Name = "dgvLopConCho";
            this.dgvLopConCho.Size = new System.Drawing.Size(1050, 262);
            this.dgvLopConCho.TabIndex = 3;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(12, 9);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(197, 29);
            this.S.TabIndex = 4;
            this.S.Text = "Đăng ký môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doanh sách  môn học mở cho đăng ký";
            // 
            // dgvDaDangKy
            // 
            this.dgvDaDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaDangKy.Location = new System.Drawing.Point(17, 440);
            this.dgvDaDangKy.Name = "dgvDaDangKy";
            this.dgvDaDangKy.Size = new System.Drawing.Size(1041, 213);
            this.dgvDaDangKy.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doanh sách môn học đã đăng ký";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(969, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Xuất phiếu đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(126, 377);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(179, 20);
            this.txtMaSV.TabIndex = 9;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã Sinh Viên";
            // 
            // lblWindowInfo
            // 
            this.lblWindowInfo.AutoSize = true;
            this.lblWindowInfo.Location = new System.Drawing.Point(284, 413);
            this.lblWindowInfo.Name = "lblWindowInfo";
            this.lblWindowInfo.Size = new System.Drawing.Size(59, 13);
            this.lblWindowInfo.TabIndex = 11;
            this.lblWindowInfo.Text = "Trạng Thái";
            // 
            // FormDangKyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 676);
            this.Controls.Add(this.lblWindowInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDaDangKy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.S);
            this.Controls.Add(this.dgvLopConCho);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnHuyDangKy);
            this.Name = "FormDangKyMon";
            this.Text = "FormDangKyMon";
            this.Load += new System.EventHandler(this.FormDangKyMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopConCho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHuyDangKy;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DataGridView dgvLopConCho;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDaDangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWindowInfo;
    }
}