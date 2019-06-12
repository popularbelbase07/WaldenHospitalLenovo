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
        // Create these properties for Display ListView
        private string _id  ;

        public string Id 
        {
            get => _id ;
            set
            {
;                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _name  ;
        public string Name
        {
            get => _name;
            set
            {
                 _name = value;
                 OnPropertyChanged(nameof(Name));
            }
        }

        private string _doctorName;

        public string DoctorName
        {
            get => _doctorName;
            set
            {
                _doctorName = value;
                OnPropertyChanged(nameof(DoctorName));
            }
        }
        private string _doctorSpecification;

        public string DoctorSpecification
        {
            get => _doctorSpecification;
            set
            {
                _doctorSpecification = value;
                OnPropertyChanged(nameof(DoctorSpecification));
            }
        }

      

        private Doctor _comboBoxSelectedItem;

        public Doctor ComboBoxSelectedItem
        {
            get { return _comboBoxSelectedItem; }
            set
            {
                _comboBoxSelectedItem = value;
                OnPropertyChanged(nameof(ComboBoxSelectedItem));
                DoctorName = ComboBoxSelectedItem.Name;
                DoctorSpecification = ComboBoxSelectedItem.Specification;
            }
        }
        
        public DateTime _SelectedDateTime;

        public DateTime SelectedDateTime
        {
            get => _SelectedDateTime;
            set
            {
                _SelectedDateTime = value;
                _SelectedDateTime = SelectedDateTime.Date;
                OnPropertyChanged(nameof(SelectedDateTime));
            }
        }
        public TimeSpan _SelectedTimefromSpan;

        public TimeSpan SelectedTimeFromSpan
        {
            get { return _SelectedTimefromSpan; }
            set
            {
                _SelectedTimefromSpan = value;
                OnPropertyChanged(nameof(SelectedTimeFromSpan));
            }
        }

        private TimeSpan _selectedToTime;
        public TimeSpan SelectedTimeToSpan
        {
            get { return _selectedToTime; }
            set
            {
                _selectedToTime = value;
                OnPropertyChanged(nameof(SelectedTimeFromSpan));
            }
        }

        //For Search engine
        private ObservableCollection<Patient> _patients;
        private string _displayChosenText = "Patient Info";
        private PatientRegistrationCatalog prc;
        public ObservableCollection<Patient> SearchPatient
        {
            //get => SearchCatalog.SearchPatient();
            get { return PatientRegistrationCatalog.Instance.Patients;}
            set { }
        }
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
        //For ComboBox Doctor
        private DoctorsCatalog dc;
         //public ObservableCollection<Doctor> DoctorName { get; set; }
        public ObservableCollection<Doctor> Doctors
        {
            get { return new ObservableCollection<Doctor>(dc.SeeDoctor()); }
        }

        public RelayCommand NewRegistration { get; set; }
        public RelayCommand AppointmentCommand { get; set; }
        public RelayCommand SearchCommand { get; set; }
        public ICommand SuggessionSelectPatientQuerySubmitted { get; set; }
        
        //public string SearchListBox { get; set; }
        //public string Search { get; set; }
        public RelayCommand Logout { get; set; }
        private DateTimeOffset _calender;

        public DateTimeOffset Calender
        {
            get { return _calender;}
            set
            {
                _calender = value;
                OnPropertyChanged(nameof(Calender));
            }
        }

        private TimeSpan _fromHour;
        public TimeSpan FromTime
        {
            get { return _fromHour;}
            set
            {
                _fromHour = value;
                OnPropertyChanged(nameof(FromTime));
            }
        }

        private TimeSpan _toTime;

        public TimeSpan ToTime
        {
            get { return _toTime;}
            set
            {
                _toTime = value;
                OnPropertyChanged(nameof(ToTime));
            }
        }


      

        

        public AppointmentVm()
        {
            //Patient = new Patient();
            prc = new PatientRegistrationCatalog();
            prc = PatientRegistrationCatalog.Instance;
            SearchPatient = prc.Patients;
            //DoctorName = new ObservableCollection<Doctor>();
            dc = new DoctorsCatalog();
            var Doctors = dc.SeeDoctor();
            
            SuggessionSelectPatientQuerySubmitted = new RelayCommandArgs<AutoSuggestBoxQuerySubmittedEventArgs>(GoSearching);
            NewRegistration = new RelayCommand(NewRegistrationForm);
            AppointmentCommand= new RelayCommand(MakeAppointment);
            //SearchCommand = new RelayCommand(SearchPatientNew);
             Logout = new RelayCommand(NavigatePage);
            Patients = new ObservableCollection<Patient>();
                 
            _from= new TimeSpan();
            _selectedPatient= new Patient();
           DateTime dt = DateTime.Now;
           Calender = new DateTimeOffset(dt.Year , dt.Month , dt.Day , dt.Hour , dt.Minute , dt.Second, new TimeSpan());
           FromTime = new TimeSpan(dt.Day , dt.Hour, dt.Minute);
           ToTime = new TimeSpan(dt.Day, dt.Hour, dt.Minute);
           AC=new AppointmentCatalog();
         

        }

        private void ComboSelectedItem(SelectionChangedEventArgs obj)
        {
           
            throw new NotImplementedException();
        }

        public void MakeAppointment()
        {
            AC.CheckAppointment();
           

        }

        public AppointmentCatalog AC;

        private Patient _selectedPatient;

        public Patient SelectedPatient
        {
            get { return _selectedPatient; }
            set
            {
                _selectedPatient = value;
                OnPropertyChanged(nameof(SelectedPatient));
            }
        }
      

        private string _searchkey;

        public string SearchKey
        {
            get { return _searchkey;}
            set
            {
                _searchkey = value;
                OnPropertyChanged(nameof(SearchKey));

            }
        }

        
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


        //private List<Patient>  _found;
        ////public List<Patient> Found
        ////{
        ////    get { return _found; }
        ////    set
        ////    {
        ////        _found = value; 
        ////        OnPropertyChanged(nameof(Found));
        ////    }
        ////}

        ////public void SearchPatientNew()
        ////{
        ////   Found= prc.check(SearchKey);


        ////}

        public void NewRegistrationForm()
        {
            Type registrationType = typeof(RegistrationPageWald);
            FrameNavigate.ActivateFrameworkNavigation(registrationType);

        }

        //public Patient Patient { get; set; }

        //public void GoSearching()
        //{
        //   SearchPatient?.Where(a => a.FullName.ToUpper().Contains(Patient.FullName.ToUpper()));
          
        //}

        public void NavigatePage()
        {
            Type logouttype = typeof(MainPageWald);
            FrameNavigate.ActivateFrameworkNavigation(logouttype);
        }

      // ICommand ..................................
        //public ICommand SuggessionSelectPatientQuerySubmitted1 => new RelayCommandArgs<AutoSuggestBoxQuerySubmittedEventArgs>(GoSearching);
        private void GoSearching(AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                string id = ((Patient)(args.ChosenSuggestion)).ID.ToString();
                string name = ((Patient)(args.ChosenSuggestion)).FullName.ToString();
                // when we select patient from suggestbox it display id and name on textbox
                DisplayChosenText = id + "-" + name;
                Id = id;
                Name = name;
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
            _patients = PatientRegistrationCatalog.Instance.Patients;
        }

        private void ComboSelectedItem(object sender , SelectionChangedEventArgs args)
        {
            
            // Get the instance of ComboBox
            ComboBox comboBox = sender as ComboBox;

            // Get the ComboBox selected item text
            string selectedItems = comboBox?.SelectedItem?.ToString();




        }



    }
        

}

  
        



    

