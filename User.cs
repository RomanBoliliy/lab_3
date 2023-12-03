using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class User
    {

        public int ID { get; set; }

        private string login, password;

        public string Login { 
        get { return login; } set {  login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }




        public User() { }

        public User(string Login, string Password) { 
            this.login = Login;
            this.password = Password;
        }

    }
}
