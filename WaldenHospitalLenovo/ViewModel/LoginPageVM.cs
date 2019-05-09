using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewPage;

namespace WaldenHospitalLenovo.ViewModel
{
    public class LoginPageVm
    {
        public List<Login> ListLogin { get; set; }
        public Login CheckAuthentication { get; set; }

        public LoginPageVm()
        {
            CheckAuthentication = new Login();
            ListLogin = GetLoginFromDb();
        }

        public async void Login()
        {
            foreach (var login in ListLogin)
            {
                if ((login.UserName == CheckAuthentication.UserName) && (login.Password == CheckAuthentication.Password))
                {
                    Type homeType = typeof(HomePage);
                    FrameNavigate.ActiveFrameNavigation(homeType);
                    var success = new MessageDialog("Thankyou for logging in");
                    await success.ShowAsync();
                    break;
                }
                else
                {
                    var failure = new MessageDialog("UserName or Password is Incorrect !!");
                    await failure.ShowAsync();
                    break;
                }
                
            }
            
        }

        public List<Login> GetLoginFromDb()
        {
            return new List<Login>()
            {
             new Login("Khem" , "abc"),
             new Login("Popular" , "abcd"),
             new Login("Ganga" , "abcde")
            };
        }
            


        }
    }

