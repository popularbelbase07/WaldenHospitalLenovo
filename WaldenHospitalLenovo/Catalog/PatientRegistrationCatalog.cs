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
           
            NewPatient = new Patient();
            _patients = Patients;
            _patients = new ObservableCollection<Patient>
            {
                new Patient(1, "John", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71432661"),
                new Patient(2, "Mohammed", "Copenhagen 30 Denmark", "Male", new DateTime(2019, 01, 11), "71302026"),
                new Patient(3, "Jimmy", "Copenhagen 01 Denmark", "Male", new DateTime(2019, 1, 13), "71332606"),
                new Patient(4, "Ganga", "Copenhagen 07 Denmark", "FeMale", new DateTime(2019, 05, 13), "71512660"),
                new Patient(5, "Roney", "Copenhagen 03 Denmark", "Male", new DateTime(2019, 05, 13), "71456626"),
                new Patient(6, "Khem", "Copenhagen 09 Denmark", "Male", new DateTime(2019, 05, 13), "71052696"),
                new Patient(7, "Zuhair", "Copenhagen 14 Denmark", "Male", new DateTime(2019, 05, 13), "71352626")
               
            };
            
        }

        public void StorePatient(Patient _patient)
        {
            
            NewPatient = _patient;
        }


        public List<Patient> Check(string name)
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


        //For Id card


        public Patient GetPatient()
        {

            return NewPatient;
        }


    }

}

