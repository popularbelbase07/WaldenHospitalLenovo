using System;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml;
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
         public RelayCommand SuggessionSelectPatientQuerySubmitted { get; set; }
         public DateTime Calender { get; set; }
         public string SearchListBox { get; set; }
         public string Search { get; set; }
        


        public AppointmentVm()
        {
             SuggessionSelectPatientQuerySubmitted = new RelayCommand(GoSearching);    
             NewRegistration = new RelayCommand(NewRegistrationForm);
             SearchCommand = new RelayCommand(SearchPatientNew);
             prc = PatientRegistrationCatalog.Instance;
             Patient = new Patient();
             SearchPatient = prc.Patients;

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

        }

        public void GoSearching()
        {
            SearchPatient?.Where(a => a.FullName.ToUpper().Contains(Patient.FullName.ToUpper()));
        }






        
        



    }
}
