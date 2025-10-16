namespace QLHocVu_THL
{
    partial class QuanLyHocKy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TB_dulieu = new System.Windows.Forms.TextBox();
            this.btn_ThemHK = new System.Windows.Forms.Button();
            this.btn_xoahk = new System.Windows.Forms.Button();
            this.btn_tatcahk = new System.Windows.Forms.Button();
            this.btn_suahk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // TB_dulieu
            // 
            this.TB_dulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_dulieu.Location = new System.Drawing.Point(183, 12);
            this.TB_dulieu.Multiline = true;
            this.TB_dulieu.Name = "TB_dulieu";
            this.TB_dulieu.Size = new System.Drawing.Size(428, 47);
            this.TB_dulieu.TabIndex = 1;
            // 
            // btn_ThemHK
            // 
            this.btn_ThemHK.Location = new System.Drawing.Point(66, 77);
            this.btn_ThemHK.Name = "btn_ThemHK";
            this.btn_ThemHK.Size = new System.Drawing.Size(117, 23);
            this.btn_ThemHK.TabIndex = 2;
            this.btn_ThemHK.Text = "Thêm Học Kỳ";
            this.btn_ThemHK.UseVisualStyleBackColor = true;
            // 
            // btn_xoahk
            // 
            this.btn_xoahk.Location = new System.Drawing.Point(246, 77);
            this.btn_xoahk.Name = "btn_xoahk";
            this.btn_xoahk.Size = new System.Drawing.Size(117, 23);
            this.btn_xoahk.TabIndex = 2;
            this.btn_xoahk.Text = "Xóa Học Kỳ";
            this.btn_xoahk.UseVisualStyleBackColor = true;
            // 
            // btn_tatcahk
            // 
            this.btn_tatcahk.Location = new System.Drawing.Point(426, 77);
            this.btn_tatcahk.Name = "btn_tatcahk";
            this.btn_tatcahk.Size = new System.Drawing.Size(117, 23);
            this.btn_tatcahk.TabIndex = 2;
            this.btn_tatcahk.Text = "Tất cả học kỳ";
            this.btn_tatcahk.UseVisualStyleBackColor = true;
            this.btn_tatcahk.Click += new System.EventHandler(this.btn_tatcahk_Click);
            // 
            // btn_suahk
            // 
            this.btn_suahk.Location = new System.Drawing.Point(606, 77);
            this.btn_suahk.Name = "btn_suahk";
            this.btn_suahk.Size = new System.Drawing.Size(117, 23);
            this.btn_suahk.TabIndex = 2;
            this.btn_suahk.Text = "Sửa Học Kỳ";
            this.btn_suahk.UseVisualStyleBackColor = true;
            this.btn_suahk.Click += new System.EventHandler(this.btn_tatcahk_Click);
            // 
            // QuanLyHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_suahk);
            this.Controls.Add(this.btn_tatcahk);
            this.Controls.Add(this.btn_xoahk);
            this.Controls.Add(this.btn_ThemHK);
            this.Controls.Add(this.TB_dulieu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLyHocKy";
            this.Text = "QuanLyHocKy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TB_dulieu;
        private System.Windows.Forms.Button btn_ThemHK;
        private System.Windows.Forms.Button btn_xoahk;
        private System.Windows.Forms.Button btn_tatcahk;
        private System.Windows.Forms.Button btn_suahk;
    }
}