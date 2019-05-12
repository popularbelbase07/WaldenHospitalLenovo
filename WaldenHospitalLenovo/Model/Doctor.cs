using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaldenHospitalLenovo.Model
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Specification { get; set; }

        public Doctor(int id, string name, string specification)
        {
            Id = id;
            Name = name;
            Specification = specification;
          
        }

        public override string ToString()
        {
            return $"{Id}-{Name}-{Specification}";
        }
    }
}
