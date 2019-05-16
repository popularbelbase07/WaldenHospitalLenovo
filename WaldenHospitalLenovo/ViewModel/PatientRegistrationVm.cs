using System;
using WaldenHospitalLenovo.Catalog;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewPage;

namespace WaldenHospitalLenovo.ViewModel
{
    public class PatientRegistrationVm
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        private PatientRegistration newPatient;

        public PatientRegistration NewPatient
        {
            get { return newPatient; }
            set { newPatient = value; }
        }
        public PatientRegistrationCatalog PatientRegistration { get; set; }
        //public RelayCommand GoPatientIdCard { get; set; }

        public PatientRegistrationVm()
        {
      //  PatientRegistration= PatientRegistrationCatalog.Registration;
       // GoPatientIdCard=new RelayCommand(CreatePatientIdCard);
        }

        public void CreatePatientIdCard()
        {
            Type Idtype = typeof(PatientIdCard);
          //  FrameNavigate.ActivateFrameworkNavigation(Idtype);
        }
    }
}
