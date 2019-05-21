using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.Catalog
{
   public static class SearchCatalog
   {
       private static ObservableCollection<Patient> _searchPatients;

       //public static ObservableCollection<Patient> SearchPatients { get; set; }


       public static ObservableCollection<Patient> SearchPatient()
       {
           _searchPatients = new ObservableCollection<Patient>()
           {
               new Patient(100, "zuhair"),

               new Patient(200, "khem"),

               new Patient(300, "dady"),

               new Patient(400, "popular"),

               new Patient(600, "ganga"),

               new Patient(500, "mizaroa"),

               new Patient(700, "boris")

           };
           for (int i = 0; i < 20; i++)
           {
             _searchPatients.Add(new Patient(i, "Patient:"+i));  
           }

           return _searchPatients;
       }

   }
}
