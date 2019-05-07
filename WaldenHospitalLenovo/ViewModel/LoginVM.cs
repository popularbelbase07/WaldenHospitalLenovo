using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.ViewModel
{
    public class LoginVm
    {
        public List<Login> ListLogin { get; set; }
        public Login CheckAuthentication { get; set; }

        public LoginVm()
        {
            CheckAuthentication = new Login();
            ListLogin = GetLoginFromDb();
        }
    }
}
