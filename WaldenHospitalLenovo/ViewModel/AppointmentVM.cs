using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewPage;

namespace WaldenHospitalLenovo.ViewModel
{
   public class AppointmentVm :NotifyPropertyChanged
   {
       
    public ObservableCollection<Patient> SearchPatient { get; set; }
    public ObservableCollection<Doctor> SeeDoctor { get; set; }
    public RelayCommand NewRegistration { get; set; }
    public DateTime Calender { get; set; }
    


        public AppointmentVm()
    {
        SearchPatient = PatientList();
        SeeDoctor = NameOfDoctor();
        NewRegistration=new RelayCommand(NewRegistrationForm);
       
    }
   //For Search Engine
    public ObservableCollection<Patient> PatientList()
    {
        return new ObservableCollection<Patient>()
        {
           // new Patient(1,"John","Copenhagen 25 Denmark","Male",new DateTime(2019,05,13), 71352626),
           // new Patient(2,"Jonny","ChristianHaven","Female",new DateTime(2019,05,13), 717364583)
            new Patient(1 , "John"),
            new Patient(2 , "Johny"),
            new Patient(3 , "ganga"),
            new Patient(4 , "popular"),
            new Patient(5 , "khem"),
            new Patient(6 , "zuhair"),
            new Patient(7 , "samuel"),
            new Patient(8 , "boris"),
        };
       
    }

       


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

        public static void NewRegistrationForm()
        {
            Type registrationType = typeof(RegistrationPageWald);
           FrameNavigate.ActivateFrameworkNavigation(registrationType);
        }

        
    }
}
