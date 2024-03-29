﻿using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using WaldenHospitalLenovo.Catalog;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewModel;

namespace WaldenHospitalLenovo.ViewModel
{
    public class LoginVm
    {
        //Instance field
        private string _username;
        private string _password;
        private LoginCatalog lc;
      
        //Property

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

        public ObservableCollection<Login> ListLogin { get; set; }
        public RelayCommand LoginCommand { get; set; }
       
        //Constructor

        public LoginVm()
        {
            ListLogin = new ObservableCollection<Login>();
            lc= new LoginCatalog();
           //Passing method is delegate type
            LoginCommand= new RelayCommand(ToLogin);
          }
     
        public void ToLogin( )
        {
          
            lc.CheckLogin(_username,_password);

        }

      


    }
}
