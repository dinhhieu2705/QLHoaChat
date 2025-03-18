using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHoaChat
{
    public partial class QuanLyDonHang : Form
    {
        public QuanLyDonHang()
        {
            InitializeComponent();
        }

        private void QuanLyDonHang_Load(object sender, EventArgs e)
        {
            // Thiết lập cột cho DataGridView
            SetupDataGridViewColumns();

            // Thêm dữ liệu mẫu
            LoadSampleData();
        }

        private void SetupDataGridViewColumns()
        {
            dgvOrders.Columns.Clear(); // Xóa cột cũ nếu có
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn { Name = "OrderCode", HeaderText = "Mã ĐH" },
                new DataGridViewTextBoxColumn { Name = "OrderDate", HeaderText = "Ngày Đặt" },
                new DataGridViewTextBoxColumn { Name = "Customer", HeaderText = "Khách Hàng" },
                new DataGridViewTextBoxColumn { Name = "TotalAmount", HeaderText = "Tổng Tiền" },
                new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Trạng Thái" },
                new DataGridViewButtonColumn { Name = "Actions", HeaderText = "Hành Động" }
            });
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadSampleData()
        {
            dgvOrders.Rows.Add("DH00125", "2023-10-27", "Nguyễn A", "340.000", "Mới", "👀 [Cập nhật v] 🖨️");
            dgvOrders.Rows.Add("DH00124", "2023-10-26", "Trần B", "120.000", "Đang xử lý", "👀 [Cập nhật v] 🖨️");
            dgvOrders.Rows.Add("DH00123", "2023-10-25", "Lê C", "250.000", "Hoàn thành", "👀 🖨️");
        }

        private void DgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOrders.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                string orderCode = dgvOrders.Rows[e.RowIndex].Cells["OrderCode"].Value.ToString();
                string status = dgvOrders.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                string actions = status == "Hoàn thành" ? "👀 🖨️" : "👀 [Cập nhật v] 🖨️";
                MessageBox.Show($"Hành động cho đơn hàng {orderCode}: {actions}");
            }
        }
    }
}
