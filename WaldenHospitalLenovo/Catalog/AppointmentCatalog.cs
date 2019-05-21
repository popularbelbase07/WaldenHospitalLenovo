using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.Catalog
{
   public  class AppointmentCatalog
   {
       //private List<Appointment> myAppointments;

       //public AppointmentCatalog()
       //{
       //    myAppointments= new List<Appointment>();
       //    Appointment ap= new Appointment();
       //    // we are here
       //}

       ////public void addAppointment( , , , , , )
       ////{
       ////     Appointment ap= new Appointment(, , , , , );
       //    myAppointments.Add(ap);
       //}
       private ObservableCollection<Appointment> myAppointments;
       public ObservableCollection<Appointment> GetAppointment
       {
           get { return myAppointments;}
           set { myAppointments = value; }
       }

       private static AppointmentCatalog _instance;

       public static AppointmentCatalog Instance => _instance ?? (new AppointmentCatalog());

       public AppointmentCatalog()
       {
         myAppointments=new ObservableCollection<Appointment>()
         {
             //new Appointment(1,2,(DateTime.Now,DateTime.Now.Hour ,new DateTime(2019/05/22)))
           //aa
         };
       }


   }
}
