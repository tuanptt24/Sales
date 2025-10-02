using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TraHangUC : UserControl
    {
        public TraHangUC()
        {
            InitializeComponent();
            LoadData(); // gọi hàm nạp dữ liệu

            // Gắn sự kiện cho DataGridView
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadData()
        {
            // Xóa dữ liệu cũ trước khi thêm mới
            dataGridView1.Rows.Clear();

            // Thêm các dòng dữ liệu
            dataGridView1.Rows.Add("RT0001", "Khách trả", "Nguyễn Văn A", "15/06/2023", 1, "850.000 đ", "Lỗi kỹ thuật", "Chi tiết");
            dataGridView1.Rows.Add("RT0002", "Trả NCC", "Công ty TNHH ABC", "16/06/2023", 3, "1.250.000 đ", "Hàng không đúng mẫu", "Chi tiết");
            dataGridView1.Rows.Add("RT0003", "Khách trả", "Trần Thị B", "17/06/2023", 1, "450.000 đ", "Không vừa ý", "Chi tiết");
            dataGridView1.Rows.Add("RT0004", "Khách trả", "Lê Văn C", "18/06/2023", 2, "900.000 đ", "Đổi sản phẩm khác", "Chi tiết");
            dataGridView1.Rows.Add("RT0005", "Trả NCC", "Công ty XYZ", "19/06/2023", 5, "2.500.000 đ", "Hàng bị hư hỏng", "Chi tiết");
        }

        /// <summary>
        /// Sự kiện khi click vào ô trong DataGridView
        /// </summary>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tránh lỗi khi click header
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Nếu click cột "Thao tác" (Column8)
            if (e.ColumnIndex == dataGridView1.Columns["Column8"].Index)
            {
                string maDon = row.Cells["Column1"].Value?.ToString();
                string loai = row.Cells["Column2"].Value?.ToString();
                string doiTuong = row.Cells["Column3"].Value?.ToString();
                string ngay = row.Cells["Column4"].Value?.ToString();
                string soLuong = row.Cells["Column5"].Value?.ToString();
                string soTien = row.Cells["Column6"].Value?.ToString();
                string lyDo = row.Cells["Column7"].Value?.ToString();

                // Hiển thị chi tiết
                MessageBox.Show(
                    $"📌 Thông tin chi tiết:\n\n" +
                    $"Mã đơn: {maDon}\n" +
                    $"Loại: {loai}\n" +
                    $"Đối tượng: {doiTuong}\n" +
                    $"Ngày: {ngay}\n" +
                    $"Số mặt hàng: {soLuong}\n" +
                    $"Số tiền: {soTien}\n" +
                    $"Lý do: {lyDo}",
                    "Chi tiết đơn trả hàng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
