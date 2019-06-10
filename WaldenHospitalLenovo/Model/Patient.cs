using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Common;


namespace WaldenHospitalLenovo.Model
{
    public class Patient : NotifyPropertyChanged
    {
        #region Instance feilds

        //Instance Field
        private int _id;
        private string _fullName;
        private string _address;
        private string _gender;
        private DateTime _dateOfBirth;
        private string _phoneNumber;

        #endregion

        #region Properties


        public int ID
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        public string Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        #endregion

        #region Constructor

        public Patient()
        {

        }

        public Patient(int id, string fullName)
        {
            _id = id;
            _fullName = fullName;

        }

        public Patient(int id, string fullName, string address, string gender, DateTime dateOfBirth, string phoneNumber)
        {
            _id = id;
            _fullName = fullName;
            _address = address;
            _gender = gender;
            _dateOfBirth = dateOfBirth;
            _phoneNumber = phoneNumber;
        }

        #endregion

        public override string ToString()
        {
            return $"{_id}-{FullName}";
        }
    }
}
