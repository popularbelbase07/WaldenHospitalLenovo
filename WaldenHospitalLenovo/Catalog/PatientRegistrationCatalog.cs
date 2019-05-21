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
        //private Patient patientRegistrationInstance;

        //// declare the object instance of class PatientRegistrationCatalog

        //public static PatientRegistrationCatalog Registration { get; set; }

        //public PatientRegistrationCatalog()
        //{
        //    //Create Object instance for business class(Model)
        //    patientRegistrationInstance = new Patient();
        //}
        //bcvbb

        ////This Registration property check first if Registration is not null
        ////if Registration is null create an object instance otherWise return the current Registration
        //public static PatientRegistrationCatalog GetPatientRegistration()
        //{
        //    if (Registration == null)
        //    {
        //        return new PatientRegistrationCatalog();
        //    }

        //    return Registration;

        //}

        ////public void SetRegistration(Patient registration)
        ////{
        ////    patientRegistrationInstance = registration;
        ////}

        ////public string GetFullName()
        ////{
        ////    return patientRegistrationInstance.FullName;
        ////}

        ////public string GetAddress()
        ////{
        ////    return patientRegistrationInstance.Address;
        ////}

        ////public string GetGender()
        ////{
        ////    return patientRegistrationInstance.Gender;
        ////}

        ////public DateTime GetDateOfBirth()
        ////{
        ////    return patientRegistrationInstance.DateOfBirth;
        ////}

        

        private PatientRegistrationCatalog()
        {
            //_patients = PatientList();
          _patients= new ObservableCollection<Patient>();
          _patients.Add(new Patient(1, "John", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"));
        }
        private static PatientRegistrationCatalog _instance;

        public static PatientRegistrationCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PatientRegistrationCatalog();
                    return _instance;
                }

                return _instance;
            }
        }

        private ObservableCollection<Patient> _patients;

        public ObservableCollection<Patient> Patients
        {
            get { return _patients; }
            set { _patients = value; }
        }


        //public ObservableCollection<Patient> PatientList()
        //{
        //     return new ObservableCollection<Patient>()
        //        {
        //             new Patient(1,"John","Copenhagen 25 Denmark","Male",new DateTime(2019,05,13), "71352626"),
        //             new Patient(2,"Jonny","ChristianHaven","Female",new DateTime(2019,05,13), "717364583"),
                              
        //        };

        //}

        public void AddPatient(Patient p)
        {
            _patients.Add(p);
        }

        public Patient CheckPatient(string name)
        {
           Patient patient= new Patient();
           
            foreach (var p in _patients)
            {
                if (p.FullName == name)
                {
                    patient = p;
                    return patient;
                }            
            }
            return patient;
        }



    }

}

