using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace LuongNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LuongThangNV_BUS nV_BUS = new LuongThangNV_BUS();
        private void btn_show_Click(object sender, EventArgs e)
        {
                       
            if(textBox1.Text.Trim().Length != 0 )
            {
                LuongThangNV lt = new LuongThangNV(textBox1.Text);
                DataTable dt= nV_BUS.Load_1NV_BUS(lt);
                if(dt!= null)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            else load_dl_from(sender, e);
            
        }

        private void load_dl_from(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nV_BUS.Load_BUS();
            this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void set_nam_nu(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void set(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel | *.xlsx | Excel 2012 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }
            using (ExcelPackage p = new ExcelPackage())
            {
                // đặt tên người tạo file
                p.Workbook.Properties.Author = "Nguyễn Mậu Hiếu";

                // đặt tiêu đề cho file
                p.Workbook.Properties.Title = "Báo cáo trả lương tháng";

                //Tạo một sheet để làm việc trên đó
                p.Workbook.Worksheets.Add("Danh_sach_Luong");  //Tên sheet

                // lấy sheet vừa add ra để thao tác
                ExcelWorksheet ws = p.Workbook.Worksheets[1];
                // đặt tên cho sheet
                ws.Name = "Danh_sach_Luong";
                // fontsize mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 11;
                // font family mặc định cho cả sheet
                ws.Cells.Style.Font.Name = "Calibri";

                // Tạo danh sách các column header
                string[] arrColumnHeader = {         
                    "Mã nhân viên",           
                    "Họ tên",
                    "Giới tính",
                    "Ngày sinh", 
                    
                    "Chức vụ",
                    "Lương tháng này"
};
                var countColHeader = arrColumnHeader.Count();

                // merge các column lại từ column 1 đến số column header
                // gán giá trị cho cell vừa merge 
                ws.Cells[1, 1].Value = "Thống kê lương";
                ws.Cells[1, 1, 1, countColHeader].Merge = true;
                // in đậm
                ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;

                int colIndex = 1;  // Cột bắt đầu tính từ 1 trong Excel
                int rowIndex = 2;  // dòng thứ 2 trừ dòng tiêu đề
                                   //tạo các header từ column header đã tạo từ bên trên
                foreach (var item in arrColumnHeader)
                {
                    var cell = ws.Cells[rowIndex, colIndex];

                    //gán giá trị
                    cell.Value = item;
                    colIndex++;
                }
                // Khai báo danh sách sinh viên
                List<LuongThangNV> userList = new List<LuongThangNV>();
                // lấy ra danh sách chuyển sang List từ gridview
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    LuongThangNV ob = new LuongThangNV();
                    ob.maNV = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    ob.hoTen = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    ob.isMale =(bool) Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    ob.ngaySinh = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    ob.chucVu = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    ob.luongThang=    float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                     userList.Add(ob);
                }
                // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                foreach (var item in userList)
                {
                    // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                    colIndex = 1;
                    // rowIndex tương ứng từng dòng dữ liệu
                    rowIndex++;
                    //gán giá trị cho từng cell                      
                    ws.Cells[rowIndex, colIndex++].Value = item.maNV;
                    ws.Cells[rowIndex, colIndex++].Value = item.hoTen;
                    ws.Cells[rowIndex, colIndex++].Value = item.isMale;
                    ws.Cells[rowIndex, colIndex++].Value = item.ngaySinh;
                    ws.Cells[rowIndex, colIndex++].Value = item.chucVu;
                    ws.Cells[rowIndex, colIndex++].Value = item.luongThang;
                }
                //Lưu file lại
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(filePath, bin);
            }
            MessageBox.Show("Xuất excel thành công!");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void In_Report()
        {
            DataTable dt = new DataTable();
            dt = nV_BUS.Load_1NV_BUS(new LuongThangNV(textBox1.Text));
            reportViewer1.ProcessingMode =
            Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Admin\source\repos\LuongNhanVien\LuongNhanVien\ReportLuongThang.rdlc";
            if (dt.Rows.Count > 0)
            {   //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = dt;
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                reportViewer1.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                reportViewer1.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                reportViewer1.RefreshReport();
            }
            else MessageBox.Show("Khong co du lieu");
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
            In_Report();
        }
        private void Chondong(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }
    }
}
