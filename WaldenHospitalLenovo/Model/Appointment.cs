using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Common;

namespace WaldenHospitalLenovo.Model
{
  public  class Appointment :NotifyPropertyChanged
  {
      private Patient p;
      private Doctor d;
      private DateTime _from;
      private DateTime _to;
      private DateTime calender;
      public Patient P
      {
          get { return p;}
          set
          {
              p = value;
              OnPropertyChanged(nameof(p));
          }

      }
      public Doctor D
      {
          get { return d; }
          set
          {
              d = value;
              OnPropertyChanged(nameof(D));
          }
      }
      public DateTime TimeFrom
      {
          get { return _from; }
          set
          {
              _from = value;
              OnPropertyChanged(nameof(TimeFrom));
          }
      }
      public DateTime TimeTo
      {
          get { return _to; }
          set
          {
              _to = value;
              OnPropertyChanged(nameof(TimeTo));
          }
      }

        public Appointment()
      {

      }

      //public Appointment(Patient p , Doctor d,  DateTime  from, DateTime to , DateTime calender )
      //{


      //}
      public Appointment(Patient p, Doctor d, DateTime @from, DateTime to, DateTime calender)
      {
          this.p = p;
          this.d = d;
          _from = @from;
          _to = to;
          this.calender = calender;
      }

  }
}
