using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Channels;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using WaldenHospitalLenovo.Catalog;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewPage;

namespace WaldenHospitalLenovo.ViewModel
{
    public class AppointmentVm : NotifyPropertyChanged
    {
         private PatientRegistrationCatalog prc;
         public ObservableCollection<Patient> SearchPatient { get; set; }
         public ObservableCollection<Doctor> SeeDoctor { get; set; }
         public RelayCommand NewRegistration { get; set; }
         public RelayCommand SearchCommand { get; set; }
         public RelayCommand SuggessionSelectPatientQuerySubmitted { get; set; }
         public string SearchListBox { get; set; }
         public string Search { get; set; }
         public  RelayCommand Logout { get; set; }
         public DateTime Calender { get; set; }
         public DateTime Time { get; set; }
        
        


        public AppointmentVm()
        {
             SuggessionSelectPatientQuerySubmitted = new RelayCommand(GoSearching);    
             NewRegistration = new RelayCommand(NewRegistrationForm);
             SearchCommand = new RelayCommand(SearchPatientNew);
             prc = PatientRegistrationCatalog.Instance;
             Patient = new Patient();
             SearchPatient = prc.Patients;
             Logout=new RelayCommand(NavigatePage);      
             Calender = new DateTime();



        }

        public Patient Patient { get; set; }

        private string _name;
        public string FullName
        {
            get => Found.FullName;
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
                _gender = Found.Gender;
                OnPropertyChanged(nameof(Gender));

            }

        }

        private Patient _found;
        public Patient Found => _found;

        public void SearchPatientNew()
        {
            //_found = prc.CheckPatient(SearchKey);


        }

        public void NewRegistrationForm()
        {
            Type registrationType = typeof(RegistrationPageWald);
            FrameNavigate.ActivateFrameworkNavigation(registrationType);

        }

        public void GoSearching()
        {
            SearchPatient?.Where(a => a.FullName.ToUpper().Contains(Patient.FullName.ToUpper()));
        }

        public void NavigatePage()
        {
            Type logouttype = typeof(MainPageWald);
            FrameNavigate.ActivateFrameworkNavigation(logouttype);
        }

        //public void DateCheck(DateTime datetime)
        //{
        //    if (datetime==(DateTime.Now))
        //    {
        //        datetime=new DateTime();
        //    }
        //    else
        //    {
             
        //        var date = new MessageDialog("You must be choose after this Hour !!");
        //        date.ShowAsync();
        //    }
          
        }






        
        



    }

