using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaldenHospitalLenovo.Model
{
     public class Patient
     {
         public int Id { get; set; }
         public string Name { get; set; }
         public string Address { get; set; }
         public string Gender { get; set; }
         public string DateOfBirth { get; set; }
         public string PhonNumber { get; set; }

         public Patient(int id, string name)
         {
             Id = id;
             Name = Name;
         }

         public override string ToString()
         {
             return $"{Id}-{Name}";
         }
     }
}
//Patients