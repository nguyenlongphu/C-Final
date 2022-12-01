using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpFinal.DataLayer;
using DevComponents.DotNetBar.Controls;

namespace CSharpFinal
{
    public partial class Frm_QuanLyTaiKhoan : Form
    {
        public Frm_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        public bool isExit = true;
        int index = -1;

        void LoadUser()
        {
            dgvUsers.DataSource = null;

            dgvUsers.DataSource = Danhsachuser.Instance.Users;
            dgvUsers.Refresh();
        }
        private void Frm_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadUser();
            dgvUsers.Columns[0].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
            dgvUsers.Columns[1].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
        }

        private void bar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            bool nhoMatKhau = false;
            switch (ckbNhoMatKhau.Checked)
            {
                case true: nhoMatKhau = true; break;
                case false: nhoMatKhau = false; break;
            }
            Danhsachuser.Instance.Users.Add(new User (taiKhoan, matKhau, nhoMatKhau));
            LoadUser();
            this.dgvUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsers.Columns[0].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
            dgvUsers.Columns[1].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
                return;

            txtTaiKhoan.Text = dgvUsers.Rows[index].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvUsers.Rows[index].Cells[1].Value.ToString();
            switch (Danhsachuser.Instance.Users[index].NhoMatKhau)
            {
                case true: ckbNhoMatKhau.Checked = true; break;
                case false: ckbNhoMatKhau.Checked = false; break;
            }
            dgvUsers.Columns[0].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
            dgvUsers.Columns[1].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn tài khoản để sửa");
                return;
            }
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            bool nhoMatKhau = false;
            switch (ckbNhoMatKhau.Checked)
            {
                case true: nhoMatKhau = true; break;
                case false: nhoMatKhau = false; break;
            }
            Danhsachuser.Instance.Users[index].TaiKhoan = taiKhoan;
            Danhsachuser.Instance.Users[index].MatKhau = matKhau;
            Danhsachuser.Instance.Users[index].NhoMatKhau = nhoMatKhau;
            LoadUser();
            this.dgvUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsers.Columns[0].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
            dgvUsers.Columns[1].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn tài khoản để xóa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
                return;
            }
            if(MessageBox.Show("Bạn có muốn xóa tài khoản này không ","Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.Cancel)
            {
                Danhsachuser.Instance.Users.RemoveAt(index);
                MessageBox.Show("Bạn đã xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            else
            {
                LoadUser();
            }
            
            LoadUser();
            this.dgvUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsers.Columns[0].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
            dgvUsers.Columns[1].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUser();
            this.dgvUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsers.Columns[0].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
            dgvUsers.Columns[1].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
        }

        private void FrmQLTK_Closing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    e.Cancel = true;
            }

        }        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(isExit)
                Application.Exit();
        }
    }
}
