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
        public ObservableCollection<PatientRegistration> AddNewPatient { get; set; }

        public PatientRegistrationVm()
        {
            AddNewPatient = NewPatients();

        }

        public ObservableCollection<PatientRegistration> NewPatients()
        {
            return new ObservableCollection<PatientRegistration>()
            {
                new PatientRegistration()

            };
        }
    }
}
