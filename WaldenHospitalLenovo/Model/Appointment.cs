using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaldenHospitalLenovo.Model
{
  public  class Appointment
  {
      private Patient p;
      private Doctor d;
      private DateTime _from;
      private DateTime _to;
      private DateTime calender;

        public Appointment() { }

      public Appointment(Patient p , Doctor d,  DateTime  from, DateTime to , DateTime calender )
      {


      }

  }
}
