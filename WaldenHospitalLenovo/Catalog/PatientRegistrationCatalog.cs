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
        //Using singleton
        private static PatientRegistrationCatalog _instance;

        public static PatientRegistrationCatalog Instance => _instance ?? (_instance = new PatientRegistrationCatalog());
            //Class reference of model class
        private ObservableCollection<Patient> _patients;

        public ObservableCollection<Patient> Patients
        {
            get => _patients;
            set => _patients = value;
        }

        public Patient NewPatient { get; set; }

        public PatientRegistrationCatalog()
        {
            //_patients = PatientList();
            NewPatient = new Patient();
            _patients = Patients;
            _patients = new ObservableCollection<Patient>
            {
                new Patient(1, "John", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"),
                new Patient(2, "John", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"),
                new Patient(3, "Jimmy", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"),
                new Patient(4, "ganga", "Copenhagen 25 Denmark", "FeMale", new DateTime(2019, 05, 13), "71352626"),
                new Patient(5, "John", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"),
                new Patient(6, "khem", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"),
                new Patient(7, "zuhair", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626")
            };

        }

        public Patient StorePatient(Patient patient)
        {
            patient = new Patient();
            return patient;
        }

        public Patient GetPatient()
        {
          //_patients.Add();
          return NewPatient;
        }

        public List<Patient> check(string name)
        {
           
            List<Patient> mylist= new List<Patient>().ToList();

            if (_patients != null)
            {
                foreach (var p in _patients)
                {
                    if ((p.FullName).Equals(name))
                    {
                       mylist.Add(p);
                    }

                   
                }

                return mylist;
            }
            return mylist;
        }
       
     
    }

}

