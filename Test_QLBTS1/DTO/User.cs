using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        private string user_name,user_matkhau,name;
        public string User_name
        {
            get { return user_name; }
            set { user_name = value; }
        }
        public string User_matkhau
        {
            get { return user_matkhau; }
            set { user_matkhau = value; }
        }
        public string _name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
