using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewPage;
using Windows.UI.Popups;

namespace WaldenHospitalLenovo.Catalog
{
   public  class LoginCatalog
   {

       private List<Login> _listLogin;

       public List<Login> ListLogin
       {
           get { return _listLogin; }
       }

       public LoginCatalog()
       {
           _listLogin = GetLoginFromDb().ToList();

       }
       public async void CheckLogin(string userName, string password)
        {
            foreach (var login in ListLogin)
            {
             
                if ((login.UserName == userName) && (login.Password == password))
                {
                    //page navigation
                    Type loginType = typeof(AppointmentPageWald);
                    FrameNavigate.ActivateFrameworkNavigation(loginType);
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
        // Fake database for login 
        public ObservableCollection<Login> GetLoginFromDb()
        {
            return new ObservableCollection<Login>()
            {
                new Login("User1" , "Khem"),
                new Login("User2" , "Popular"),
                new Login("User3" , "Ganga")

            };
        }
    }
}
