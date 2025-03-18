using System;
using System.Windows.Forms;

namespace QLHoaChat
{
    public partial class QuanLyThanhToan : Form
    {
        public QuanLyThanhToan()
        {
            InitializeComponent();
        }

        private void PaymentMethodManagementForm_Load(object sender, EventArgs e)
        {
            // Thiết lập cột cho DataGridView
            SetupDataGridViewColumns();

            // Thêm dữ liệu mẫu
            LoadSampleData();
        }

        private void SetupDataGridViewColumns()
        {
            dgvPaymentMethods.Columns.Clear(); // Xóa cột cũ nếu có
            dgvPaymentMethods.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn { Name = "STT", HeaderText = "STT" },
                new DataGridViewTextBoxColumn { Name = "MethodName", HeaderText = "Tên Phương Thức" },
                new DataGridViewTextBoxColumn { Name = "Description", HeaderText = "Mô Tả" },
                new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Trạng Thái" },
                new DataGridViewButtonColumn { Name = "Actions", HeaderText = "Hành Động" }
            });
            dgvPaymentMethods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadSampleData()
        {
            dgvPaymentMethods.Rows.Add("1", "Chuyển khoản", "Thanh toán qua ngân hàng", "Kích hoạt", "✏️ 🚫");
            dgvPaymentMethods.Rows.Add("2", "Tiền mặt", "Thanh toán khi nhận hàng", "Kích hoạt", "✏️ 🚫");
            dgvPaymentMethods.Rows.Add("3", "Thẻ Visa/Master", "Thanh toán qua cổng thanh toán", "Vô hiệu", "✏️ ✅");
        }

        private void DgvPaymentMethods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPaymentMethods.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                string methodName = dgvPaymentMethods.Rows[e.RowIndex].Cells["MethodName"].Value.ToString();
                string status = dgvPaymentMethods.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                string actions = status == "Kích hoạt" ? "✏️ 🚫" : "✏️ ✅";
                MessageBox.Show($"Hành động cho phương thức {methodName}: {actions}");
            }
        }
    }
}