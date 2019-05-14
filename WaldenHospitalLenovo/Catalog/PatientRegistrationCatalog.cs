using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.Catalog
{
    public class PatientRegistrationCatalog
    {
        private PatientRegistration patientRegistrationInstance;

        // declare the object instance of class PatientRegistrationCatalog

        public static PatientRegistrationCatalog Registration { get; set; }

        public PatientRegistrationCatalog()
        {
            //Create Object instance for business class(Model)
            patientRegistrationInstance = new PatientRegistration();
        }

        //This Registration property check first if Registration is not null
        //if Registration is null create an object instance otherWise return the current Registration
        public static PatientRegistrationCatalog GetPatientRegistration()
        {
            if (Registration == null)
            {
                return new PatientRegistrationCatalog();
            }

            return Registration;

        }

        public void SetRegistration(PatientRegistration registration)
        {
            patientRegistrationInstance = registration;
        }

        public string GetFullName()
        {
            return patientRegistrationInstance.FullName;
        }

        public string GetAddress()
        {
            return patientRegistrationInstance.Address;
        }

        public bool GetGender()
        {
            return patientRegistrationInstance.Gender;
        }

        public DateTime GetDateOfBirth()
        {
            return patientRegistrationInstance.DateOfBirth.DateTime;
        }
        //List for patient
        
        //public static ObservableCollection<PatientRegistration> PatientRegistrationList()
        //{
        //    return new ObservableCollection<PatientRegistration>()
        //    {
        //        new PatientRegistration("Raj Smith","Copenhagen Denmark" );
        //    };
        //}

    }

}

