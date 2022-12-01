using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.DataLayer
{
    internal class User : IComparable
    {

        private int iD;
        private string taiKhoan;
        private string matKhau;
        private string hoVaTen;
        private bool nhoMatKhau;

        public int ID { get => iD; set => iD = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public bool NhoMatKhau { get => nhoMatKhau; set => nhoMatKhau = value; }


        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", ID, TaiKhoan, MatKhau, HoVaTen, NhoMatKhau.ToString());
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public User(int iD, string taiKhoan, string matKhau, string hoVaTen, bool nhoMatKhau)
        {
            this.iD = 0;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.hoVaTen = hoVaTen;
            this.nhoMatKhau = nhoMatKhau;
        }

    }
}
