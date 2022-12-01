using CSharpFinal.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFinal
{
    public partial class Frm_DangNhap : Form
    {
        List<User> users = Danhsachuser.Instance.Users;
        bool thoat = true;
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    if (Kiemtradangnhap(txtTaiKhoan.Text, txtMatKhau.Text))
                    {
                        Frm_Main f_main = new Frm_Main();
                        f_main.ShowDialog();
                        thoat = true;
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTaiKhoan.ResetText();
                        txtMatKhau.Text = string.Empty;
                        //Quay lại chỗ tải khoản
                        txtTaiKhoan.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                    //Quay lại chỗ mật khẩu 
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                //Quay lại chỗ tải khoản
            }

        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chương trình sẽ được thoát.\n Hãy xác định việc này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                thoat = true;
                Application.Exit();
            }
        }

        bool Kiemtradangnhap(string taiKhoan, string matKhau)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (taiKhoan == users[i].TaiKhoan && matKhau == users[i].MatKhau)
                {
                    return true;
                }



            }
            return false;

        }
    }
    }

