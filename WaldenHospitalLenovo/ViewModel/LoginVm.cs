using System.Collections.ObjectModel;
using WaldenHospitalLenovo.Catalog;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.ViewModel
{
    public class LoginVm
    {
        public ObservableCollection<Login> ListLogin { get; set; }
       
        private LoginCatalog lc;
       
        public LoginVm()
        {
            ListLogin = new ObservableCollection<Login>();
            lc= new LoginCatalog();
           
            LoginCommand= new RelayCommand(ToLogin);

        }
        public RelayCommand LoginCommand { get; set; }
        private string _username;

        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;

        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }

        public void ToLogin( )
        {
          
            lc.CheckLogin(_username,_password);

        }



    }
}
