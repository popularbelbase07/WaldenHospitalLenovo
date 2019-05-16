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
            _patients = new ObservableCollection<Patient>();
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

    }

}

