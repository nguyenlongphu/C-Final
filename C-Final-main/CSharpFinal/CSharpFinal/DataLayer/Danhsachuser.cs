using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.DataLayer
{
    internal class Danhsachuser
    {
        //Thao tác thông qua các thuộc tính user thông qua instance .Dùng instance để hạn chế nhiều lỗi 
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
            users.Add(new User(1, "admin", "admin", "Nguyen Minh Phuc", true));
            users.Add(new User(2, "user01", "1234", "Nguyen Hoang Hiep", true));
            users.Add(new User(3, "user02", "1234", "Nguyen Long Phu", false));
            users.Add(new User(4, "user03", "12345", "Mai Truong Duy", false));
            users.Add(new User(5, "user04", "11112", "Ho Manh Dong", true));
            users.Add(new User(6, "user05", "123", "Nguyen Hoang Anh", true));


        }

    }
}
