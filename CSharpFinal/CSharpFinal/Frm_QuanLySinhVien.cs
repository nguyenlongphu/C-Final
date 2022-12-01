using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFinal
{
    public partial class Frm_QuanLySinhVien : Form
    {
        List<SinhVien> lstSV;
        
        public Frm_QuanLySinhVien()
        {
            InitializeComponent();
            lstSV = new List<SinhVien>();
        }
        int index;
        /*public void ghiFile(DataGridView gridView)
        {
            FileStream fileStream = new FileStream("SinhVien.txt",FileMode.Create,FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            for(int i=0;i < gridView.Rows.Count - 1 ;i++)
            {
                for(int j=0;j<gridView.Columns.Count;j++)
                {
                    streamWriter.Write(gridView.Rows[i].Cells[j].Value + "|");

                }
                streamWriter.WriteLine();
            }
            streamWriter.Close();
            fileStream.Close();
        }

        public void docFile(DataGridView dataGrid)
        {
            FileStream fileStream = new FileStream("SinhVien.txt",FileMode.Open,FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            string chuoi = reader.ReadLine();
            string masv, tensv, diemsv, lopsv;
            while(chuoi != null)
            {
                string[] mang = chuoi.Split('|');
                masv = mang[0];
                tensv = mang[1];
                diemsv = mang[2];
                lopsv = mang[3];
                dataGrid.Rows.Add(masv, tensv, diemsv, lopsv);
                chuoi = reader.ReadLine();
            }
            reader.Close();
            fileStream.Close();
        }*/

        public bool CheckControl()
        {
            if(string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMaSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiemSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSV.Focus();
                return false;
            }
            return true;
        }

        private void Frm_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            this.dataGridSinhVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            
            
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if(CheckControl())
            {
                int msv;
                string tsv;
                double d;
                string l;
                msv = Int32.Parse(txtMaSV.Text);
                tsv = txtTenSV.Text;
                d = double.Parse(txtDiemSV.Text);
                l = txtLopSV.Text;
                SinhVien sv = new SinhVien(msv, tsv, d, l);
                lstSV.Add(sv);
                dataGridSinhVien.DataSource = null;
                dataGridSinhVien.DataSource = lstSV;
                dataGridSinhVien.Refresh();
                this.dataGridSinhVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        
        private void dataGridSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                txtMaSV.Text = lstSV[index].MaSV.ToString();
                txtTenSV.Text = lstSV[index].TenSV;
                txtDiemSV.Text = lstSV[index].DiemSV.ToString();
                txtLopSV.Text = lstSV[index].LopSV;
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if(index >= 0 )
            {
                lstSV[index].MaSV = Int32.Parse(txtMaSV.Text);
                lstSV[index].TenSV = txtTenSV.Text;
                lstSV[index].DiemSV = double.Parse(txtDiemSV.Text);
                lstSV[index].LopSV = txtLopSV.Text;
                dataGridSinhVien.DataSource = null;
                dataGridSinhVien.DataSource= lstSV;
                this.dataGridSinhVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa hay không ?","Cảnh cáo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                lstSV.RemoveAt(index);
                dataGridSinhVien.DataSource = null;
                dataGridSinhVien.DataSource = lstSV;
                this.dataGridSinhVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnSapXepSV_Click(object sender, EventArgs e)
        {
            lstSV.Sort((a,b) => a.TenSV.CompareTo(b.TenSV));
            dataGridSinhVien.DataSource = null;
            dataGridSinhVien.DataSource = lstSV;
            this.dataGridSinhVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimKiem.Text;
            if(!string.IsNullOrWhiteSpace(value))
            {
                dataGridSinhVien.DataSource = null;
                dataGridSinhVien.DataSource = lstSV;
                this.dataGridSinhVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                List<SinhVien> temp = new List<SinhVien>();
                for (int i = 0; i < dataGridSinhVien.Rows.Count; i++)
                {
                    if (dataGridSinhVien.Rows[i].Cells[1].Value.ToString().ToLower().Contains(value.ToLower()))
                    {
                        temp.Add(lstSV[i]);
                    }
                }

                    dataGridSinhVien.DataSource = null;
                    dataGridSinhVien.DataSource = temp;
                    this.dataGridSinhVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                

            }
            else
            {
                dataGridSinhVien.DataSource = null;
                dataGridSinhVien.DataSource = lstSV;
                this.dataGridSinhVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void Frm_QuanLySinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (dataGridSinhVien.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridSinhVien.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dataGridSinhVien.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridSinhVien.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridSinhVien.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dataGridSinhVien.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }
    }
    class SinhVien
    {
        public int MaSV { set; get; }
        public string TenSV { set; get; }
        public double DiemSV { set; get; }

        public string LopSV { set; get; }

        public SinhVien()
        {
            MaSV = 0;
            TenSV = "Khong co ten";
            DiemSV = 0;
            LopSV = "Chua co lop";
        }

        public SinhVien(int maSV, string tenSV, double diemSV, string lopSV)
        {
            MaSV = maSV;
            TenSV = tenSV;
            DiemSV = diemSV;
            LopSV = lopSV;
        }
    }
        

}
