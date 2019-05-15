using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.Catalog
{
    public class DoctorCatalog
    {

        private ObservableCollection<Doctor> _doctors;
        public DoctorCatalog()
        {
            _doctors = new ObservableCollection<Doctor>();
            _doctors.Add(new Doctor(1, "jOHN", "FYSITERAPEUT"));
            _doctors.Add(new Doctor(2, "Ole", "kinesiterapeut"));
            _doctors.Add(new Doctor(3, "Jack", "Heart specialist"));
            _doctors.Add(new Doctor(4, "mohammed", "Back specialist"));

        }
      
        public ObservableCollection<Doctor> Doctors
        {
            get { return _doctors; }
            set { _doctors = value; }
        }
    }
}
