using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Annotations;
using WaldenHospitalLenovo.Event_Handler;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.ViewModel
{
   public class PatientRegistrationVm : NotifyPropertyChanged
    {
        public PatientRegistration AddPatient { get; set; }

        public PatientRegistrationVm()
        {
            AddPatient = new PatientRegistration();

        }
       
    }
}
