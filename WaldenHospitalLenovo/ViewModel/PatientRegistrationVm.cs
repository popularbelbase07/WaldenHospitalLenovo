using System;
using System.Collections.ObjectModel;
using WaldenHospitalLenovo.Catalog;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewPage;

namespace WaldenHospitalLenovo.ViewModel
{
    public class PatientRegistrationVm
    {
        //public ObservableCollection<PatientRegistration> AddNewPatient { get; set; }

        //public PatientRegistrationVm()
        //{
        //    AddNewPatient = NewPatients();

        //}

        //public ObservableCollection<PatientRegistration> NewPatients()
        //{
        //    return new ObservableCollection<PatientRegistration>()
        //    {
        //        new PatientRegistration()

        //    };
        //}
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        private Patient newPatient;
        public Patient NewPatient
        {
            get { return newPatient; }
            set { newPatient = value; }
        }

        public PatientRegistrationCatalog pc;
     public ObservableCollection<Patient> Listpatient { get; set; }
        public RelayCommand CreatePatientCommand { get; set; }

        public PatientRegistrationVm()
        {
            Listpatient=new ObservableCollection<Patient>();
            CreatePatientCommand=new RelayCommand(CreatePatient);
            pc=PatientRegistrationCatalog.Instance;
        }

      //  public PatientRegistrationVm()
      //  {
      //PatientList=PatientRegistrationCatalog
      //  CreatePatientCommand = new RelayCommand(CreatePatient);
      //  }


        public void CreatePatient()
        {
            Patient p = new Patient(Id, Name, Address, Gender, DateOfBirth, PhoneNumber);

            pc.AddPatient(p);
            //Type Idtype = typeof(PatientIdCard);
            //FrameNavigate.ActivateFrameworkNavigation(Idtype);
        }
    }
}
