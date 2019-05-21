using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.Catalog
{
   public  class AppointmentCatalog
   {
       private List<Appointment> myAppointments;

       public AppointmentCatalog()
       {
           myAppointments= new List<Appointment>();
           Appointment ap= new Appointment();
           // we are here
       }

       //public void addAppointment( , , , , , )
       //{
       //     Appointment ap= new Appointment(, , , , , );
       //    myAppointments.Add(ap);
       //}

   }
}
