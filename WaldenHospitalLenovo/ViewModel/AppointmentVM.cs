using System;
using System.Collections.ObjectModel;
using WaldenHospitalLenovo.Catalog;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.ViewModel
{
    public class AppointmentVm : NotifyPropertyChanged
    {
         private PatientRegistrationCatalog prc;
         public ObservableCollection<Patient> SearchPatient { get; set; }
         public ObservableCollection<Doctor> SeeDoctor { get; set; }
         public RelayCommand NewRegistration { get; set; }
         public RelayCommand SearchCommand { get; set; }
         public DateTime Calender { get; set; }
        


        public AppointmentVm()
        {
             
             NewRegistration = new RelayCommand(NewRegistrationForm);
             SearchCommand = new RelayCommand(SearchPatientNew);
             prc = PatientRegistrationCatalog.Instance;
            _found = new Patient();

        }

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

        public void NewRegistrationForm()
        {

        }






        
        



    }
}
