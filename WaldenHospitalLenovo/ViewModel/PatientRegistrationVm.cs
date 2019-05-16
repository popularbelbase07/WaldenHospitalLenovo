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
        public string PhoneNumber { get; set; }

        public PatientRegistration NewPatient { get; set; }

        public PatientRegistrationCatalog Prc { get; set; }
        public RelayCommand NewRegistration { get; set; }
        public RelayCommand GoBackCommand { get; set; }

        public PatientRegistrationVm()
        {
            NewPatient = new PatientRegistration();
            Prc = PatientRegistrationCatalog.Instance;
            NewRegistration =new RelayCommand(CreatePatientIdCard);
            GoBackCommand = new RelayCommand(GoBack);
        }

        public void CreatePatientIdCard()
        {
            try
            {
                Prc.Patients?.Add(new Patient(NewPatient.FullName, NewPatient.Address, NewPatient.Gender, NewPatient.DateOfBirth, NewPatient.PhoneNumber.ToString()));
                Type type = typeof(PatientIdCard);
                FrameNavigate.ActivateFrameworkNavigation(type);

            }
            catch (Exception e)
            {
                throw  new Exception();
            }

        }

        public void GoBack()
        {
            Type type = typeof(PatientIdCard);
            FrameNavigate.ActivateFrameworkNavigation(type);
        }
    }
}
