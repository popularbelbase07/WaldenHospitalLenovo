using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Catalog;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewPage;

namespace WaldenHospitalLenovo.ViewModel
{
   public class AppointmentVm :NotifyPropertyChanged
   {
       private PatientRegistrationCatalog prc;
    //public ObservableCollection<Patient2> SearchPatient { get; set; }
    public ObservableCollection<Doctor> SeeDoctor { get; set; }
    public RelayCommand NewRegistration { get; set; }
    public RelayCommand SearchCommand{ get; set; }
    public DateTime Calender { get; set; }
    


     public AppointmentVm()
    {
        //SearchPatient = PatientList();
        SeeDoctor = NameOfDoctor();
        NewRegistration=new RelayCommand(NewRegistrationForm);
        SearchCommand=new RelayCommand(SearchPatient);
        prc = PatientRegistrationCatalog.Instance;
        _found= new Patient();
             
    }

     private string _name;
     public string FullName
     {
         get { return Found.FullName; }
         set
         {
             _name = Found.FullName;
             OnPropertyChanged(nameof(FullName));

         }
     }

     private string _gender;
     public string Gender
     {
         get { return Found.Gender; }
         set
         {
             _gender= Found.Gender;
             OnPropertyChanged(nameof(Gender));

         }

        }

        private Patient _found;
        public Patient Found
        {
            get { return _found; }
        }
        public void SearchPatient()
        {
            _found = prc.CheckPatient(SearchKey);
         

        }



        //public string Name
        //{
        //       get { return }
        //       //set { }
        //}

        //public string Gender
        //{
        //       get { }
        //       //set { }

        //}

        private string _key;

     public string SearchKey
     {
         get { return _key; }
         set { _key = value; }
     }






   //For Search Engine
    public ObservableCollection<Patient2> PatientList()
    {
        return new ObservableCollection<Patient2>()
        {
           // new Patient(1,"John","Copenhagen 25 Denmark","Male",new DateTime(2019,05,13), 71352626),
           // new Patient(2,"Jonny","ChristianHaven","Female",new DateTime(2019,05,13), 717364583)
            new Patient2(1 , "John"),
            new Patient2(2 , "Johny"),
            new Patient2(3 , "ganga"),
            new Patient2(4 , "popular"),
            new Patient2(5 , "khem"),
            new Patient2(6 , "zuhair"),
            new Patient2(7 , "samuel"),
            new Patient2(8 , "boris"),
        };
       
    }

       


        //For Combo box
        public ObservableCollection<Doctor> NameOfDoctor()
    {
        return new ObservableCollection<Doctor>()
        {
            new Doctor(1,"Rajesh","Cardiologist"),
            new Doctor(2,"Randy","Psychologist"),
            new Doctor(3,"Rosy","Gastrologist")
        };
    }

        public static void NewRegistrationForm()
        {
            Type registrationType = typeof(RegistrationPageWald);
           FrameNavigate.ActivateFrameworkNavigation(registrationType);
        }

        
    }
}
