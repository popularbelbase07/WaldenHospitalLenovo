using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Event_Handler;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.ViewModel
{
   public class AppointmentVM :NotifyPropertyChanged
    {
    public ObservableCollection<Patient> SearchPatient { get; set; }
    public ObservableCollection<Doctor> SeeDoctor { get; set; }

    public AppointmentVM()
    {
        SearchPatient = PatientList();
        SeeDoctor = NameOfDoctor();
    }
   //For Search Engine
    public ObservableCollection<Patient> PatientList()
    {
        return new ObservableCollection<Patient>()
        {
            //new Patient(1,"John","Copenhagen 25 Denmark","Male","1990-12-20",71352626),
            //new Patient(2,"Jhon","ChristianHaven","Female","1992-12-12",238273949)
            
        };
       
    }

    //public async void CheckCondition(int id, string name)
    //{
    //    foreach (var Check in SearchPatient)
    //    {

    //        if ((Check.ID=id) && (Check.Name = name))
    //        {
    //            
    //        }
    //    }
    //}
        
  
//For Combo box
    public ObservableCollection<Doctor> NameOfDoctor()
    {
        return new ObservableCollection<Doctor>()
        {
            new Doctor(1,"Rajesh","Cardiologist"),
            new Doctor(2,"Randy","Psychologist"),
            new Doctor(3,"Rosy","Gastrologist")
        };
    }

        
    }
}
