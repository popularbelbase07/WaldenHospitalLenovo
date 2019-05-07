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
                if ((login.UserName == userName) && (login.Password == password))
                {
                    //page navigation
                    Type homeType = typeof(HomePage);
                    FrameNavigate.ActivateFrameNavigation(homeType);
                    //Dialogue message:Pop-Up message
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
            // Catalogue
        public List<Login> GetLoginFromDb()
        {
            return new List<Login>()
            {
                new Login("User1" , "Khem"),
                new Login("User2" , "Popular"),
                new Login("User3" , "Ganga")

            };
        }

    }
}
