using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtHeSoA.Text);
                double b = Convert.ToDouble(txtHeSoB.Text);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        txtKetQua.Text = "Phuong Trinh vo nghiem";
                        txtNghiem.Clear();
                    }
                }
                else
                {
                    double nghiem = -b / a;
                    txtKetQua.Text = "Phuong trinh co 1 nghiem.";
                    txtNghiem.Text = nghiem.ToString();
                }
                }
                catch (Exception ex)
            {

                MessageBox.Show("Lỗi nhập dữ liệu! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHeSoA.Clear();
            txtHeSoB.Clear();
            txtKetQua.Clear();
            txtNghiem.Clear();
            txtHeSoA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

