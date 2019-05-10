using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Event_Handler;

namespace WaldenHospitalLenovo.Model
{
    public class Patient :NotifyPropertyChanged
    {
        #region Instance Field
        private int _id;
        private string _name;
        private string _address;
        private bool _gender;
        private string _dob;
        private int _phoneNumber;
        #endregion

        # region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public string DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        #endregion

        #region Constructor

        public Patient(int id, string name, string address, bool gender, string dateOfBirth, int phoneNumber)
        {
            ID = id;
            Name = name;
            Address = address;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }

        public Patient()
        {
            //Default Constructor
            
        }
        #endregion

        public override string ToString()
        {
            return
                $"Id:{ID} , Name:{Name} , Address:{Address} , Gender:{Gender},Date Of Birth :{DateOfBirth} ,Phone Number:{PhoneNumber}";
        }
    }
}
