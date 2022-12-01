using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.DataLayer
{
    internal class User : IComparable
    {

private string taiKhoan;

public string TaiKhoan
{
    get { return taiKhoan; }
    set { taiKhoan = value; }
}
private string matKhau;

public string MatKhau
{
    get { return matKhau; }
    set { matKhau = value; }
}

private bool nhoMatKhau;

public bool NhoMatKhau
{
    get { return nhoMatKhau; }
    set { nhoMatKhau = value; }
}




        public override string ToString()
        {
            return string.Format("{0},{1},{2}", TaiKhoan, MatKhau, NhoMatKhau.ToString());
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public User( string taiKhoan, string matKhau, bool nhoMatKhau)
        {
            
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            
            this.nhoMatKhau = nhoMatKhau;
        }
    }
}
