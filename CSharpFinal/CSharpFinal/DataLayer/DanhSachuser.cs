using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.DataLayer
{
    internal class Danhsachuser
    {
         private static Danhsachuser instance;
        List<User> users;

        public static Danhsachuser Instance
        {
            get
            {
                if (instance == null)
                    instance = new Danhsachuser();
                return instance;

            }
            set => instance = value;
        }

        public List<User> Users { get => users; set => users = value; }

        //Hàm khởi tạo danh sách user 
        Danhsachuser()

        {
            users = new List<User>();
            users.Add(new User( "admin", "admin",  true));
            users.Add(new User( "user01", "1234",  true));
            users.Add(new User( "user02", "1234",  false));
            users.Add(new User("user03", "12345", false));
            users.Add(new User( "user04", "11112", true));
            users.Add(new User( "user05", "123", true));
        }
    }
}
