using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewPage;

namespace WaldenHospitalLenovo.ViewModel
{
    public class LoginVm
    {
        public List<Login> ListLogin { get; set; }
       
        public LoginVm()
        {
            ListLogin = GetLoginFromDb();

        }
        public async void LoginPage(string userName , string password)
        {
            foreach (var login in ListLogin)
            {

                if ((login.UserName == userName ) && (login.Password == password))
                {
                    Type homeType = typeof(HomePage);
                    FrameNavigate.ActivateFrameNavigation(homeType);
                    var success = new MessageDialog("Thank you for logging ");
                    await success.ShowAsync();
                    break;
                }
                else
                {
                    var failure = new MessageDialog("User id or password is inCorrect !!");
                    await failure.ShowAsync();
                    break;

                }



            }

        }

        public List<Login> GetLoginFromDb()
        {
            return new List<Login>()
            {
                new Login("User1" , "abc"),
                new Login("User2" , "xyz"),
                new Login("User3" , "123"),

            };
        }

    }
}
