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
    public partial class QuanLyVoucher : Form
    {
        public QuanLyVoucher()
        {
            InitializeComponent();
        }

        private void VoucherManagementForm_Load(object sender, EventArgs e)
        {
            // Thiết lập cột cho DataGridView
            SetupDataGridViewColumns();

            // Thêm dữ liệu mẫu
            LoadSampleData();
        }

        private void SetupDataGridViewColumns()
        {
            dgvVouchers.Columns.Clear(); // Xóa cột cũ nếu có
            dgvVouchers.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn { Name = "Code", HeaderText = "Mã" },
                new DataGridViewTextBoxColumn { Name = "VoucherName", HeaderText = "Tên Voucher" },
                new DataGridViewTextBoxColumn { Name = "Type", HeaderText = "Loại" },
                new DataGridViewTextBoxColumn { Name = "Value", HeaderText = "Giá Trị" },
                new DataGridViewTextBoxColumn { Name = "StartDate", HeaderText = "Bắt Đầu" },
                new DataGridViewTextBoxColumn { Name = "EndDate", HeaderText = "Kết Thúc" },
                new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "SL" },
                new DataGridViewTextBoxColumn { Name = "Used", HeaderText = "Dùng" },
                new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "TT" },
                new DataGridViewButtonColumn { Name = "Actions", HeaderText = "Hành Động" }
            });
            dgvVouchers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadSampleData()
        {
            dgvVouchers.Rows.Add("KM10", "Khuyến mãi 10%", "%", "10", "2023-10-26", "2023-11-05", "50", "10", "Còn", "✏️ 🗑️");
            dgvVouchers.Rows.Add("VC20", "Giảm 20K", "VNĐ", "20.000", "2023-10-20", "2023-10-30", "100", "80", "Hết", "✏️ 🗑️");
        }

        private void DgvVouchers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvVouchers.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                string voucherName = dgvVouchers.Rows[e.RowIndex].Cells["VoucherName"].Value.ToString();
                MessageBox.Show($"Hành động cho voucher {voucherName}: ✏️ 🗑️");
            }
        }
    }
}

