using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Channels;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WaldenHospitalLenovo.Catalog;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewPage;

namespace WaldenHospitalLenovo.ViewModel
{
    public class AppointmentVm : NotifyPropertyChanged
    {
        private ObservableCollection<Patient> _patients;
        private string _displayChosenText = "Find Existing Patient";
        
        private PatientRegistrationCatalog prc;
        public ObservableCollection<Patient> SearchPatient
        {
            get { return SearchCatalog.SearchPatient(); }
        }
        public RelayCommand NewRegistration { get; set; }
        public RelayCommand SearchCommand { get; set; }
        public RelayCommand SuggessionSelectPatientQuerySubmitted { get; set; }
        public string SearchListBox { get; set; }
        public string Search { get; set; }
        public RelayCommand Logout { get; set; }
        public List<Doctor> DoctorName { get; set; }

        public ObservableCollection<Patient> Patients
        {
            get => _patients;
            set
            {
                _patients = value;

                OnPropertyChanged(nameof(_patients));
            }
        }

        public string DisplayChosenText
        {
            get => _displayChosenText;
            set
            {
                _displayChosenText = value;
                OnPropertyChanged(nameof(DisplayChosenText));
            }
        }


        public ObservableCollection<Doctor> Doctors
        {
            get { return new ObservableCollection<Doctor>(dc.SeeDoctor()); }
        }

        private DoctorsCatalog dc;

        public AppointmentVm()
        {
            SuggessionSelectPatientQuerySubmitted = new RelayCommand(GoSearching);
            NewRegistration = new RelayCommand(NewRegistrationForm);
            //SearchCommand = new RelayCommand(SearchPatientNew);
            prc = PatientRegistrationCatalog.Instance;
            Patient = new Patient();
            //SearchPatient = prc.Patients;
            Logout = new RelayCommand(NavigatePage);
            DoctorName = new List<Doctor>();
            dc = new DoctorsCatalog();
            Patients = new ObservableCollection<Patient>();
            _patients = SearchCatalog.SearchPatient();
            prc= new PatientRegistrationCatalog();
            _from= new TimeSpan();
            _selectedPatient= new Patient();

           


        }

        private Patient _selectedPatient;

        public Patient SelectedPatient
        {
            get { return _selectedPatient; }
            set
            {
                _selectedPatient = value;
                OnPropertyChanged(nameof(SearchPatient));
            }
        }
        public Patient Patient { get; set; }

        //private string _searchkey;

        //public string SearchKey
        //{
        //    get { return _searchkey;}
        //    set
        //    {
        //        _searchkey = value;
        //        OnPropertyChanged(nameof(SearchKey));

        //    }
        //}

        

        private TimeSpan _from;
        public TimeSpan From
        {
            get { return _from; }
            set
            {
                _from = value;
                OnPropertyChanged(nameof(From));
            }
        }


        private List<Patient>  _found;
        public List<Patient> Found
        {
            get { return _found; }
            set
            {
                _found = value; 
                OnPropertyChanged(nameof(Found));
            }
        }

        //public void SearchPatientNew()
        //{
        //   Found= prc.check(SearchKey);


        //}

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

       

        // ICommand ..................................
        public ICommand SuggessionSelectPatientQuerySubmitted1 => new RelayCommandArgs<AutoSuggestBoxQuerySubmittedEventArgs>(SuggessionSelectPatientQuerySubmittedDelegateMethod);
        private void SuggessionSelectPatientQuerySubmittedDelegateMethod(AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                string id = ((Patient)(args.ChosenSuggestion)).ID.ToString();
                string name = ((Patient)(args.ChosenSuggestion)).FullName.ToString();
                // when we select patient from suggestbox it display id and name on textbox
                DisplayChosenText = id + "-" + name;
            }
            else
            {
                // always refresh the Patient List
                RefreshPatientList();
                // when you press enter or side find bar then see the filter results
                var filterData = _patients.Where(a => (a.FullName ?? "").ToLower().Contains(args.QueryText.ToLower()));
                ObservableCollection<Patient> filterList = new ObservableCollection<Patient>();
                filterList.Clear();
                foreach (var item in filterData)
                {
                    filterList.Add(item);
                }
                _patients = filterList;

            }
           
        }
        public void RefreshPatientList()
        {
            _patients = SearchCatalog.SearchPatient();
        }
    }


}

  
        



    

