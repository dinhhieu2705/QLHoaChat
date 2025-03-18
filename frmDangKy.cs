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
using System.Text.RegularExpressions;

namespace QLHoaChat.Forms 
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không đúng định dạng.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (txtMatKhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtXacNhanMK.Text))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhanMK.Focus();
                return;
            }
            if (!chkDongY.Checked)
            {
                MessageBox.Show("Bạn phải đồng ý với điều khoản!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkDongY.Focus();
                return;
            }

            if (txtMatKhau.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacNhanMK.Focus();
                return;
            }

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ThemTaiKhoan", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ten_dn", txtTenDangNhap.Text);
                    cmd.Parameters.AddWithValue("@mk", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@hinh", DBNull.Value); // Giá trị mặc định NULL cho hình
                    cmd.Parameters.AddWithValue("@vaiTro", "Người dùng");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công! Bạn có thể đăng nhập ngay.", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmDangNhap frm = new frmDangNhap();
                    frm.Show();
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Error code for unique constraint violation
                    {
                        if (ex.Message.Contains("ten_dn"))
                            MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Lỗi đăng ký",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (ex.Message.Contains("email"))
                            MessageBox.Show("Email đã được sử dụng. Vui lòng chọn email khác.", "Lỗi đăng ký",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Lỗi đăng ký: " + ex.Message, "Lỗi đăng ký",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi đăng ký: \n" + ex.Message, "Lỗi đăng ký",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void linkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
        }

        // Hàm kiểm tra định dạng email
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
