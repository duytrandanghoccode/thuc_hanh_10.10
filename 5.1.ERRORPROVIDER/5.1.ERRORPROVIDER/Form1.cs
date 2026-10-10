using System;
using System.Windows.Forms;

namespace Bai5_DangKyTaiKhoan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi bấm nút Đăng Ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Xóa toàn bộ thông báo lỗi cũ trước khi kiểm tra lại
            epCheck.Clear();
            bool isValid = true;

            // 1. Kiểm tra Tên đăng nhập không được trống
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống!");
                isValid = false;
            }

            // 2. Kiểm tra Mật khẩu không được trống
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống!");
                isValid = false;
            }

            // 3. Kiểm tra Xác nhận mật khẩu khớp với Mật khẩu
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                epCheck.SetError(txtConfirmPassword, "Mật khẩu nhập lại không khớp!");
                isValid = false;
            }

            // 4. Kiểm tra độ tuổi phải >= 18
            // Tính toán tuổi chính xác theo ngày tháng
            int age = DateTime.Now.Year - dtpNgaySinh.Value.Year;
            if (DateTime.Now.DayOfYear < dtpNgaySinh.Value.DayOfYear)
            {
                age--; // Nếu chưa đến sinh nhật trong năm nay thì trừ đi 1 tuổi
            }

            if (age < 18)
            {
                epCheck.SetError(dtpNgaySinh, "Bạn phải đủ 18 tuổi trở lên!");
                isValid = false;
            }

            // 5. Kiểm tra Tích chọn điều khoản dịch vụ
            if (!chkDieuKhoan.Checked)
            {
                epCheck.SetError(chkDieuKhoan, "Bạn phải đồng ý với điều khoản dịch vụ!");
                isValid = false;
            }

            // 6. Nếu tất cả điều kiện đều hợp lệ (isValid = true)
            if (isValid)
            {
                MessageBox.Show("Chúc mừng bạn đã đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xử lý sự kiện khi bấm nút Làm Mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu các TextBox
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            // Đặt lại ngày sinh về ngày hiện tại
            dtpNgaySinh.Value = DateTime.Now;

            // Bỏ chọn các CheckBox và RadioButton
            radNam.Checked = false;
            radNu.Checked = false;
            chkDieuKhoan.Checked = false;

            // Xóa cảnh báo lỗi
            epCheck.Clear();

            // Đưa con trỏ chuột về ô đăng nhập
            txtUsername.Focus();
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            radNam.Checked = false;
            radNu.Checked = false;
            chkDieuKhoan.Checked = false;
            epCheck.Clear();
            txtUsername.Focus();
        }
    }
}