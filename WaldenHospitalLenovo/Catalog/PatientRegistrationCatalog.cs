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
     
        private PatientRegistrationCatalog()
        {
            //_patients = PatientList();
            _patients = new ObservableCollection<Patient>
            {
                new Patient(1, "John", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"),
                new Patient(1, "Jedy", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"),
                new Patient(1, "Jimmy", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"),
                new Patient(1, "ganga", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"),
                new Patient(1, "poular", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"),
                new Patient(1, "khem", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626"),
                new Patient(1, "zuhair", "Copenhagen 25 Denmark", "Male", new DateTime(2019, 05, 13), "71352626")
            };

        }
        private static PatientRegistrationCatalog _instance;

        public static PatientRegistrationCatalog Instance => _instance ?? (_instance = new PatientRegistrationCatalog());

        private ObservableCollection<Patient> _patients;

        public ObservableCollection<Patient> Patients
        {
            get => _patients;
            set => _patients = value;
        }

    }

}

