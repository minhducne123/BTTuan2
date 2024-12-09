using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra số nguyên tố
        private bool LaSoNguyenTo(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        // Sự kiện khi nhấn nút "Liệt kê"
        private void btnLietKe_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                int n;
                if (!int.TryParse(txtN.Text, out n) || n <= 1)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương lớn hơn 1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Danh sách số nguyên tố và tổng các số nguyên tố
                List<int> soNguyenTo = new List<int>();
                int tong = 0;

                // Duyệt từ 2 đến n-1
                for (int i = 2; i < n; i++)
                {
                    if (LaSoNguyenTo(i))
                    {
                        soNguyenTo.Add(i);
                        tong += i;
                    }
                }

                // Hiển thị danh sách số nguyên tố và tổng
                txtDanhSach.Text = string.Join(", ", soNguyenTo);
                txtTongCong.Text = tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi nhấn nút "Bỏ qua"
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtDanhSach.Clear();
            txtTongCong.Clear();
        }

        // Sự kiện khi nhấn nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện không sử dụng
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
