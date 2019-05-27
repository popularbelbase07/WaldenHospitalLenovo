using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaldenHospitalLenovo.Catalog;
using WaldenHospitalLenovo.Common;
using WaldenHospitalLenovo.Model;
using WaldenHospitalLenovo.ViewPage;

namespace WaldenHospitalLenovo.ViewModel
{
   public class IdCardVm:NotifyPropertyChanged
   {
       private Patient _card;
       public RelayCommand PrintCommand { get; set; }
       public RelayCommand BackToRegistration { get; set; }
       public PatientRegistrationCatalog Prc { get; set; }
      

        public Patient IdCard
       {
           get { return _card; }
           set
           {
               _card = value;
               OnPropertyChanged(nameof(IdCard));
           }
       }

       public IdCardVm()
       {
           _card=new Patient();
           PrintCommand=new RelayCommand(PrintCard);
           BackToRegistration=new RelayCommand(BackButton);
           Prc = PatientRegistrationCatalog.Instance;
           IdCard =  Prc.GetPatient();

       }

      

       public void PrintCard()
       {

       }

       public void BackButton()
       {
           Type BackType = typeof(RegistrationPageWald);
           FrameNavigate.ActivateFrameworkNavigation(BackType);
       }
   }
}
