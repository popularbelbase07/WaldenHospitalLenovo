using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaldenHospitalLenovo.Model
{
    public class Patient
    {
        private int _id;
        private string _name;
        private string _address;
        private bool _gender;
        private string _dob;
        private int _phoneNumber;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public string DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }

        public Patient(int id, string name, string address, bool gender, string dob, int phoneNumber)
        {
            _id = id;
            _name = name;
            _address = address;
            _gender = gender;
            _dob = dob;
            _phoneNumber = phoneNumber;
        }

        public Patient()
        {
            
        }

        public override string ToString()
        {
            return
                $"Id:{ID} , Name:{Name} , Address:{Address} , Gender:{Gender},Date Of Birth :{DateOfBirth} ,Phone Number:{PhoneNumber}";
        }
    }
}
