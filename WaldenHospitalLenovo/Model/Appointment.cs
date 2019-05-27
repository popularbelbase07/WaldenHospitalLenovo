using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using WaldenHospitalLenovo.Common;

namespace WaldenHospitalLenovo.Model
{
  public  class Appointment :NotifyPropertyChanged
  {
      private int _patientId;
      private int _doctorId;
      private DateTime _from;
      private DateTime _to;
      private DateTime _calender;
      public int  PatientId
      {
          get => _patientId;
          set
          {
              _patientId = value;
              OnPropertyChanged(nameof(PatientId));
          }

      }
      public int DoctorId
      {
          get { return _doctorId; }
          set
          {
              _doctorId = value;
              OnPropertyChanged(nameof(DoctorId));
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
      public DateTime CalenderDate
      {
          get { return _calender; }
          set
          {
              _calender = value;
              OnPropertyChanged(nameof(CalenderDate));
          }
      }

        public Appointment()
      {
           //a
      }

        public Appointment(int patientId, int doctorId, DateTime @from, DateTime to, DateTime calender)
        {
            _patientId = patientId;
            _doctorId = doctorId;
            _from = @from;
            _to = to;
            _calender = calender;
        }
  }
}
