using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaldenHospitalLenovo.Model
{
   public class Login
    {
        //commit

        //Properties
        public string UserName { get; set; }

        public string Password { get; set; }

        //Constructor
        public Login()
        {
            //Default constructor
        }

        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }


        public override string ToString()
        {
            return $"{UserName}-{Password}";
        }
    }
}
