using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFinal
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            {
                if (pnlHeThong.Height == 144)
                {
                    pnlHeThong.Height = 33;

                }
                else
                {
                    pnlHeThong.Height = 144;
                }
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (pnlDanhMuc.Height == 107)
            {
                pnlDanhMuc.Height = 33;

            }
            else
            {
                pnlDanhMuc.Height = 107;
                pnlHeThong.Height = 33;

            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không ?", "Cảnh cáo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {
            Frm_QuanLySinhVien frm_QuanLySinhVien = new Frm_QuanLySinhVien();
            frm_QuanLySinhVien.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.ShowDialog();  
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            Frm_QuanLyTaiKhoan frm_QuanLyTaiKhoan = new Frm_QuanLyTaiKhoan();   
            frm_QuanLyTaiKhoan.ShowDialog();
        }

        private void btnQuanLyLop_Click(object sender, EventArgs e)
        {
            Frm_QuanLyLop frm_QuanLyLop = new Frm_QuanLyLop();
            frm_QuanLyLop.ShowDialog();
        }
    }
}
