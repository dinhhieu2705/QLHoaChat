using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLHoaChat.Models; 

namespace QLHoaChat.Forms
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Lỗi đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Lỗi đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT vaiTro FROM tk
                                   WHERE ten_dn = @ten_dn
                                   AND mk = @mk
                                   AND trangThai = N'Hoạt động'";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ten_dn", txtTenDangNhap.Text);
                    cmd.Parameters.AddWithValue("@mk", txtMatKhau.Text);

                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        Form frmTrangChu;

                        if (result.ToString() == "Quản trị viên")
                            frmTrangChu = new frmQuanTri(); // Giả sử bạn có form frmQuanTri
                        else
                            frmTrangChu = new frmNguoiDung(); // Giả sử bạn có form frmNguoiDung

                        frmTrangChu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: \n" + ex.Message, "Lỗi đăng nhập",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.Show();
            this.Hide();
        }
    }
}
