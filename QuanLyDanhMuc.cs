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
    public partial class QuanLyDanhMuc : Form
    {
        public QuanLyDanhMuc()
        {
            InitializeComponent();
        }
        private void DgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCategories.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                string categoryName = dgvCategories.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
                MessageBox.Show($"Hành động cho danh mục {categoryName}: ✏️ 🗑️");
            }
        }
        private void QuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            // Có thể thêm logic khởi tạo nếu cần
        }
    }
}
