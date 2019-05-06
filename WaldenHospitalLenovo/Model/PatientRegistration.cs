﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Event_Handler;

namespace WaldenHospitalLenovo.Model
{
   public class PatientRegistration : NotifyPropertyChanged
   {
        #region Instance Field

        private string _fullname;
       private string _address;
       private bool _gender;
       private DateTimeOffset _dateOfBirth;
        #endregion
        #region Properties
 
        public string FullName
        {
            get { return _fullname;}
            set
            {
                _fullname = value;
              OnPropertyChanged(nameof(FullName)); 
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        public bool Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        public DateTimeOffset DateOfBirth { get; set; }

        #endregion
        #region Constructor

        public PatientRegistration()
        {
            
        }
        #endregion

        public override string ToString()
        {
            return $"FullName : {FullName},Address :{Address} ,Gender :{Gender},Date Of Birth :{DateOfBirth}";
        }
        


   }
}
