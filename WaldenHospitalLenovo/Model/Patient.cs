using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaldenHospitalLenovo.Model
{
    public class Patient
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int DateOfBirth { get; set; }
        public int PhonNumber { get; set; }

        public Patient(string name, string address, string gender, int dateOfBirth, int phonNumber)
        {
            Name = name;
            Address = address;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PhonNumber = phonNumber;
        }

        public override string ToString()
        {
            return $"{Name}-{Address}-{Gender}-{DateOfBirth}-{PhonNumber}";
        }
    }
}
