using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Common;

namespace WaldenHospitalLenovo.Model
{
    public class Doctor :NotifyPropertyChanged
    {
        #region Instance Field
       
        //private string _name;
        //private string _specification;
        #endregion

        //#region Properties
        //public string Name
        //{
        //    get { return _name;}
        //    set
        //    {
        //        _name = value; 
        //        OnPropertyChanged(nameof(Name));
        //    }

        //}

        //public string Specification
        //{
        //    get { return _specification; }
        //    set
        //    {
        //        _specification = value;
        //        OnPropertyChanged(nameof(Specification));
        //    }
        //}

        //#endregion

        //#region Constructor

        //public Doctor( string name, string specification)
        //{
           
        //    _name = name;
        //    _specification = specification;
         
        //    OnPropertyChanged(nameof(Name));
        //    OnPropertyChanged(nameof(Specification));
        //}

        //public Doctor()
        //{
            
        //}
        //#endregion

        //public override string ToString()
        //{
        //    return $"{_name}-{_specification}";
        //}
        public string Name { get; set; }
        public string Specification { get; set; }

        public Doctor(string name, string specification)
        {
            Name = name;
            Specification = specification;
        }

        public Doctor()
        {
            
        }

        public override string ToString()
        {
            return $"{Name} - {Specification}";
        }
    }
}
