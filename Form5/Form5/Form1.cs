using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTu.Text, out int tu) && int.TryParse(txtDen.Text, out int den))
            {
                if (tu > den)
                {
                    MessageBox.Show("Giá trị 'Từ' phải nhỏ hơn hoặc bằng giá trị 'Đến'", "Lỗi nhập liệu");
                    return;
                }
                int tong = 0;
                for (int i = tu; i <= den; i++)
                {
                    tong += i;
                }
                txtKetqua.Text = tong.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi nhập liệu");
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTu.Clear();
            txtDen.Clear();
            txtKetqua.Clear();

           
            txtTu.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
