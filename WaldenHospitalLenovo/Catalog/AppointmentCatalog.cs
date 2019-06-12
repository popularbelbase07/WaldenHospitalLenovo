 using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using WaldenHospitalLenovo.Model;
 using WaldenHospitalLenovo.ViewModel;

 namespace WaldenHospitalLenovo.Catalog
{
    public class AppointmentCatalog
    {
        public ObservableCollection<Appointment> Appoint { get; set; }

        public AppointmentCatalog()
        {
            Appoint = new ObservableCollection<Appointment>();


        }

        public ObservableCollection<Appointment> GetAppointment()
        {
            return new ObservableCollection<Appointment>()
            {
                new Appointment()
                {
                    DoctorId = 1223, PatientId = 234, TimeFrom = new DateTime(), TimeTo = new DateTime().AddDays(1),
                    CalenderDate = DateTime.Now
                }
            };
        }

        public  void BookAppointment()
        {
            Appointment newAppointment = new Appointment();
            newAppointment.PatientId.ToString();
            newAppointment.DoctorId.ToString();
            newAppointment.CalenderDate.ToLocalTime();
            newAppointment.TimeTo.Hour.ToString();


        }



        public async void CheckAppointment()
        {
            var success = new MessageDialog(" Congratulation Booking Conformed !!");
            await success.ShowAsync();
        }
    }
}
