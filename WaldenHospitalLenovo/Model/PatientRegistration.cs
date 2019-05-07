using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.EventHandler;

namespace WaldenHospitalLenovo.Model
{
    public class PatientRegistration : NotifyPropertyChanged
    {
        #region Instance feilds

        private string _fullName;
        private string _address;
        private bool _gender;
        private DateTimeOffset _dateOfBirth;

        #endregion

        #region Properties

        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
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
    }
      

    }



    

