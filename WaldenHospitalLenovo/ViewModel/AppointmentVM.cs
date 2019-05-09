using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.ViewModel
{
   public class AppointmentVM
    {
        public  Patient PatientList { get; set; }
        public Doctor DoctorCombo { get; set; }
      

        public AppointmentVM()
        {
            PatientList=new Patient();
            DoctorCombo=new Doctor();
        }

    }
}
