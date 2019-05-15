using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Common;


namespace WaldenHospitalLenovo.Model
{
    public class Patient2
    {
       

        # region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        #endregion

        #region Constructor

        public Patient2(int id , string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        public override string ToString()
        {
            return $"{Name} - {Id}";
        }

        
    }
}
