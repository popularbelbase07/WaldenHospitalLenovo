using System.Collections.ObjectModel;
using WaldenHospitalLenovo.Catalog;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.ViewModel
{
    public class LoginVm
    {
        //Instance field
        private LoginCatalog lc;
        //Property
        public ObservableCollection<Login> ListLogin { get; set; }
        public RelayCommand LoginCommand { get; set; }

        //Constructor
        public LoginVm()
        {
            ListLogin = new ObservableCollection<Login>();
            lc= new LoginCatalog();
           
            LoginCommand= new RelayCommand(ToLogin);

        }
     
        private string _username;
        private string _password;

        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

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
