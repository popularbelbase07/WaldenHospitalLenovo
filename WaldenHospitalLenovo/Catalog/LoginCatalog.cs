using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Xml;
using Windows.Data.Json;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Handler;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewPage;
using Windows.UI.Popups;
using Windows.Web.Http;
using Newtonsoft.Json;

namespace WaldenHospitalLenovo.Catalog
{
    public  class LoginCatalog :NotifyPropertyChanged,IRequestHttpHandler<Login>
   {
        private  const string Uri= "http://localhost:55827/api/Logins";
        public async void FetchAllData()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = "";
                    Task task = Task.Run(async () =>
                    {
                        // sends GET request
                        // ReSharper disable once AccessToDisposedClosure
                        response = await client.GetStringAsync(new Uri(Uri));
                    });
                    // Wait
                    task.Wait();
                    // convert Json into Objects
                    if (response != null)
                    {
                       
                       ListLogin = JsonConvert.DeserializeObject<ObservableCollection<Login>>(response);
                        // call on property change Interface
                    }
                }
                catch (Exception ex)
                {
                    //// Display successful message
                    var messageDialog = new MessageDialog(ex.Message);
                    await messageDialog.ShowAsync();
                }
            }
        }

        public void Post()
        {
            throw new NotImplementedException();
        }
        //Instance field
        private ObservableCollection<Login> _listLogin;
        //Property
       public ObservableCollection<Login> ListLogin
       {
           get { return _listLogin; }
           set { _listLogin = value; }
       }
      //Constructor
       public LoginCatalog()
       {
           //_listLogin = GetLoginFromDb();
           FetchAllData();

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
                    var failure = new MessageDialog("User id or password is incorrect !!");
                    await failure.ShowAsync();
                    break;

                }

            }

        }
        //// Fake database for login 
        //public ObservableCollection<Login> GetLoginFromDb()
        //{
        //    return new ObservableCollection<Login>()
        //    {
        //        new Login("User1" , "Khem"),
        //        new Login("User2" , "Popular"),
        //        new Login("User3" , "Ganga")

        //    };
        //}
    }
}
