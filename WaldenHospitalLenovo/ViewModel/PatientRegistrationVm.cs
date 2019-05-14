using System;
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
        private PatientRegistration newPatient;

        public PatientRegistration NewPatient
        {
            get { return newPatient; }
            set { newPatient = value; }
        }
        public PatientRegistrationCatalog PatientRegistration { get; set; }
        public RelayCommand GoPatientIdCard { get; set; }

        public PatientRegistrationVm()
        {
        PatientRegistration= PatientRegistrationCatalog.Registration;
        GoPatientIdCard=new RelayCommand(CreatePatientIdCard);
        }

        public void CreatePatientIdCard()
        {
            Type Idtype = typeof(PatientIdCard);
            FrameNavigate.ActivateFrameworkNavigation(Idtype);
        }
    }
}
