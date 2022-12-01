using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSharpFinal
{
    public partial class Frm_QuanLyLop : Form
    {
        List<Lop> lstlop;
        public Frm_QuanLyLop()
        {
          lstlop = new List<Lop>(); 
            InitializeComponent();
        }
        public bool ktraData()
        {
            if (string.IsNullOrEmpty(txtTenlop.Text))
            {
                MessageBox.Show("Chưa nhập Tên Lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenlop.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMalop.Text))
            {
                MessageBox.Show("Chưa nhập Mã Lớp .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMalop.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtThuocKhoa.Text))
            {
                MessageBox.Show("Chưa nhập Khoa .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThuocKhoa.Focus();
                return false;
            }
            return true;
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            this.Close();
        }

        private void Frm_QuanLyLop_Load(object sender, EventArgs e)
        {

        }

        private void Frm_QuanLyLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(ktraData())
            {
                string Tenlop;
                string Thuockhoa;
                int Malop;
                Tenlop = txtTenlop.Text;
                Thuockhoa = txtThuocKhoa.Text;
                Malop=Int32.Parse(txtMalop.Text);
                Lop lop = new Lop(Tenlop,Malop,Thuockhoa);
                lstlop.Add(lop);
                dataGridViewLop.DataSource = null;
                dataGridViewLop.DataSource = lstlop;
                dataGridViewLop.Refresh();
                MessageBox.Show("Thêm thành công!","Thông báo ",MessageBoxButtons.OK);
            }
            

        }
        int index;

        private void dataGridViewLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0) ;
            {
                txtTenlop.Text = lstlop[index].TenLop.ToString();
                txtMalop.Text = lstlop[index].MaLop.ToString();
                txtThuocKhoa.Text = lstlop[index].ThuocKhoa.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(index >=0)
            {
                lstlop[index].TenLop = txtTenlop.Text;
                lstlop[index].MaLop = Int32.Parse(txtMalop.Text);
                lstlop[index].ThuocKhoa = txtThuocKhoa.Text;
                dataGridViewLop.DataSource = null;
                dataGridViewLop.DataSource = lstlop;
                this.dataGridViewLop.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa dòng  này  ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) ;
            lstlop.RemoveAt(index);
            dataGridViewLop.DataSource = null;
            dataGridViewLop.DataSource = lstlop;
            this.dataGridViewLop.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void xoagiaodien()
        {
            txtTenlopp.Text = "";
            txtMalopp.Text = "";

            txtThuocKhoaa.Text= "";
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (radTenlop.Checked==true)
            {
                dataGridViewTimkiem.Rows.Clear();
                for (int i = 0; i < dataGridViewLop.Rows.Count -1 ; i++)
                {
                    if (txtTenlopp.Text == dataGridViewLop[0, i].Value.ToString())
                    {
                        dataGridViewTimkiem.Rows.Add(dataGridViewLop[0, i].Value, dataGridViewLop[1, i].Value, dataGridViewLop[2, i].Value);
                       
                    }
                }

            }
            else if (radMalop.Checked==true)
            {
                dataGridViewTimkiem.Rows.Clear();
                for (int i = 0; i < dataGridViewLop.Rows.Count - 1; i++)
                {
                    if (txtMalopp.Text == dataGridViewLop[2, i].Value.ToString())
                    {
                        dataGridViewTimkiem.Rows.Add(dataGridViewLop[0, i].Value, dataGridViewLop[1, i].Value, dataGridViewLop[2, i].Value);
                       
                    }
                }

            }
            else if (radThuockhoa.Checked==true)
            {
                dataGridViewTimkiem.Rows.Clear();
                for (int i = 0; i < dataGridViewLop.Rows.Count - 1; i++)
                {
                    if (txtThuocKhoaa.Text == dataGridViewLop[3, i].Value.ToString())
                    {
                        dataGridViewTimkiem.Rows.Add(dataGridViewLop[0, i].Value, dataGridViewLop[1, i].Value, dataGridViewLop[2, i].Value);
                        
                    }
                }

                
              
                

            }
            xoagiaodien();

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if(dataGridViewLop.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for(int i=1;i<dataGridViewLop.Columns.Count +1;i++)
                {
                    XcelApp.Cells[1,i] = dataGridViewLop.Columns[i - 1].HeaderText;

                }   
                
                for(int i =0;i < dataGridViewLop.Rows.Count;i++)
                {
                    for(int j =0;j < dataGridViewLop.Columns.Count;j++)
                    {
                        XcelApp.Cells[i + 2, j + 1]= dataGridViewLop.Rows[i].Cells[j].Value.ToString();
                    }    
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible=true;
            }    
        }
    }
    public class Lop
        {
        string tenLop;
        int maLop;
        string thuocKhoa;

        public string ThuocKhoa { get => thuocKhoa; set => thuocKhoa = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int MaLop { get => maLop; set => maLop = value; }

       public Lop()
        {
            TenLop = "";
            MaLop = 0;
            ThuocKhoa = "";
        }
        public Lop(string tenLop, int maLop, string thuocKhoa)
        {
            TenLop = tenLop;
            MaLop = maLop;
            ThuocKhoa = thuocKhoa;
           
        }
    }

   
}
