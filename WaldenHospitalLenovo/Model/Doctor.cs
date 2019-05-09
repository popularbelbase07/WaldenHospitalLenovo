﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaldenHospitalLenovo.Model
{
    public class Doctor
    {
        private int _id;
        private string _name;
        private string _specification;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }

        public Doctor(int id, string name, string specification)
        {
            _id = id;
            _name = name;
            _specification = specification;
        }

        public Doctor()
        {

        }

        public override string ToString()
        {
            return $"Id:{Id} , Name:{Name} , Specification :{Specification}";
        }
    }
}
