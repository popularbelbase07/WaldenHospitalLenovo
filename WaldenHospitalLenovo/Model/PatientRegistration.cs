using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Common;

namespace WaldenHospitalLenovo.Model
{
    public class PatientRegistration : NotifyPropertyChanged
    {
        #region Instance feilds
       //............................
       private int _id;
        private string _fullName;
        private string _address;
        private string _gender;
        private DateTimeOffset _dateOfBirth;
        private string _phoneNumber;

        #endregion

        #region Properties
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(ID));
            }
        }

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

        public string Gender {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            } }
        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        #endregion

        #region Constructor

        public PatientRegistration()
        {
            
        }

        public PatientRegistration(int id,string fullName, string address, string gender, DateTimeOffset dateOfBirth, string phoneNumber)
        {
            
            _fullName = fullName;
            _address = address;
            _gender = gender;
            _dateOfBirth = dateOfBirth;
            _phoneNumber = phoneNumber;
        }
        #endregion
    }
      

    }



    

