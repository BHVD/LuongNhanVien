namespace LuongNhanVien
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LuongThangNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 449);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn_report);
            this.tabPage1.Controls.Add(this.btn_excel);
            this.tabPage1.Controls.Add(this.btn_show);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaNV,
            this.col_HoTenNv,
            this.col_GioiTinh,
            this.col_NgaySinhNV,
            this.col_ChucVu,
            this.col_LuongThangNV});
            this.dataGridView1.Location = new System.Drawing.Point(16, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Chondong);
            // 
            // col_MaNV
            // 
            this.col_MaNV.DataPropertyName = "manv";
            this.col_MaNV.HeaderText = "Mã Nhân Viên";
            this.col_MaNV.MinimumWidth = 6;
            this.col_MaNV.Name = "col_MaNV";
            this.col_MaNV.Width = 125;
            // 
            // col_HoTenNv
            // 
            this.col_HoTenNv.DataPropertyName = "hoten";
            this.col_HoTenNv.HeaderText = "Họ và Tên";
            this.col_HoTenNv.MinimumWidth = 6;
            this.col_HoTenNv.Name = "col_HoTenNv";
            this.col_HoTenNv.Width = 125;
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.DataPropertyName = "gioitinh";
            this.col_GioiTinh.HeaderText = "Giới Tính";
            this.col_GioiTinh.MinimumWidth = 6;
            this.col_GioiTinh.Name = "col_GioiTinh";
            this.col_GioiTinh.Width = 125;
            // 
            // col_NgaySinhNV
            // 
            this.col_NgaySinhNV.DataPropertyName = "ngaysinh";
            this.col_NgaySinhNV.HeaderText = "Ngày Sinh";
            this.col_NgaySinhNV.MinimumWidth = 6;
            this.col_NgaySinhNV.Name = "col_NgaySinhNV";
            this.col_NgaySinhNV.Width = 125;
            // 
            // col_ChucVu
            // 
            this.col_ChucVu.DataPropertyName = "chucvu";
            this.col_ChucVu.HeaderText = "Chức Vụ";
            this.col_ChucVu.MinimumWidth = 6;
            this.col_ChucVu.Name = "col_ChucVu";
            this.col_ChucVu.Width = 125;
            // 
            // col_LuongThangNV
            // 
            this.col_LuongThangNV.DataPropertyName = "luongthang";
            this.col_LuongThangNV.HeaderText = "Lương tháng";
            this.col_LuongThangNV.MinimumWidth = 6;
            this.col_LuongThangNV.Name = "col_LuongThangNV";
            this.col_LuongThangNV.Width = 125;
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(598, 124);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(98, 23);
            this.btn_report.TabIndex = 10;
            this.btn_report.Text = "Tạo Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(311, 124);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(123, 23);
            this.btn_excel.TabIndex = 9;
            this.btn_excel.Text = "Xuất Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(74, 124);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 8;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 22);
            this.textBox1.TabIndex = 6;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(59, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(653, 366);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.load_dl_from);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTenNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LuongThangNV;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
    }
}

