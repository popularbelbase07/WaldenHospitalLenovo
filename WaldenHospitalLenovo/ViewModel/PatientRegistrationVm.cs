 using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.ViewModel
{
    public class PatientRegistrationVm
    {
        public ObservableCollection<Patient2> AddNewPatient { get; set; }

        public PatientRegistrationVm()
        {
            AddNewPatient = NewPatients();

        }

        public ObservableCollection<Patient2> NewPatients()
        {
            return new ObservableCollection<Patient2>()
            {
                new Patient2()

            };
        }
    }
}
