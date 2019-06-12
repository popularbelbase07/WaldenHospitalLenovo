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
        public PatientRegistrationCatalog Prc { get; set; }
        public RelayCommand NewRegistration { get; set; }
        public RelayCommand GoBackCommand { get; set; }

        public Patient NewPatient { get; set; }

        public PatientRegistrationVm()
        {
            NewPatient = new Patient();
            Prc = PatientRegistrationCatalog.Instance;
            NewRegistration =new RelayCommand(CreatePatientIdCard);
            GoBackCommand = new RelayCommand(GoBack);
        }

        public void CreatePatientIdCard()
        {
            try
            {
                Patient newPatient = new Patient(NewPatient.ID, NewPatient.FullName, NewPatient.Address, NewPatient.Gender, NewPatient.DateOfBirth, NewPatient.PhoneNumber);
                Prc.Patients?.Add(newPatient);
                Prc.StorePatient(newPatient);

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
            Type type = typeof(AppointmentPageWald);
            FrameNavigate.ActivateFrameworkNavigation(type);
        }
    }
}
