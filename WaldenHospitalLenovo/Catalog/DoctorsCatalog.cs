﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.Catalog
{
    public class DoctorsCatalog
   {
        public ObservableCollection<Doctor> Doc { get; set; }

        public DoctorsCatalog()
        {
            Doc = new ObservableCollection<Doctor>();
            Doc = SeeDoctor();
        }

        public ObservableCollection<Doctor> SeeDoctor()
        {
            return new ObservableCollection<Doctor>()
       {
           new Doctor("John","Psychology"),
           new Doctor("Rock","Gynecologist"),
           new Doctor("Martin","Cardiologist"),
           new Doctor("Khem","Neurologist")
       };
        }
        //public List<Doctor> Doc { get; set; }

        //public List<Doctor> SeeDoctor()
        //{
        //    return  new List<Doctor>()
        //    {
        //        new Doctor("John","Psychology"),
        //               new Doctor("Rock","Gynecologist"),
        //               new Doctor("Martin","Cardiologist"),
        //               new Doctor("Khem","Neurologist")
        //    };
        //}

  //      public DoctorsCatalog()
  //{
  //    Doc=new List<Doctor>();
  //    Doc = SeeDoctor();
  //}
    }
}
