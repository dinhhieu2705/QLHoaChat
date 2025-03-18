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
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }
        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            // Thiết lập cột cho DataGridView
            SetupDataGridViewColumns();

            // Thêm dữ liệu mẫu
            LoadSampleData();
        }

        private void SetupDataGridViewColumns()
        {
            dgvProducts.Columns.Clear(); // Xóa cột cũ nếu có
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn { Name = "STT", HeaderText = "STT" },
                new DataGridViewImageColumn { Name = "Image", HeaderText = "Ảnh", ImageLayout = DataGridViewImageCellLayout.Zoom },
                new DataGridViewTextBoxColumn { Name = "ProductCode", HeaderText = "Mã SP" },
                new DataGridViewTextBoxColumn { Name = "ProductName", HeaderText = "Tên Sản Phẩm" },
                new DataGridViewTextBoxColumn { Name = "Category", HeaderText = "Danh Mục" },
                new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Giá Bán" },
                new DataGridViewTextBoxColumn { Name = "Stock", HeaderText = "Tồn Kho" },
                new DataGridViewButtonColumn { Name = "Actions", HeaderText = "Hành Động" }
            });
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadSampleData()
        {
            dgvProducts.Rows.Add("1", null, "SP001", "Axit Sunfuric 98%", "CN", "120.000", "50", "👀 ✏️ 🗑️");
            dgvProducts.Rows.Add("2", null, "SP002", "NaOH vảy", "CN", "80.000", "120", "👀 ✏️ 🗑️");
            dgvProducts.Rows.Add("3", null, "SP003", "Ethanol 99%", "TN", "250.000", "30", "👀 ✏️ 🗑️");
        }

        private void DgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProducts.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                string productName = dgvProducts.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                MessageBox.Show($"Hành động cho sản phẩm {productName}: 👀 ✏️ 🗑️");
            }
        }
    }
}

