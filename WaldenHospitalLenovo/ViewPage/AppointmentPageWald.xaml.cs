using System.Collections.ObjectModel;
using System.Linq;
using WaldenHospitalLenovo.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WaldenHospitalLenovo.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WaldenHospitalLenovo.ViewPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AppointmentPageWald : Page
    {
        public AppointmentVm AppointmentVm { get; set; } = new AppointmentVm();
        //public Patient PatientName { get; set; } = new Patient();
        public AppointmentPageWald()
        {
            this.InitializeComponent();

            //SearchlistBox.ItemsSource = AppointmentVm.SearchPatient;
        }

      
        //private void SrchPat_OnQueryChanged(SearchBox sender, SearchBoxQueryChangedEventArgs args)
        //{

        //    ObservableCollection<Patient2> patientList = AppointmentVm.PatientList();
        //    if (patientList != null)
        //    {
        //        SearchlistBox.ItemsSource =
        //            patientList.Where((a => a.Name.ToUpper().Contains(SearchPatient.QueryText.ToUpper())));

        //    }

        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

      
    }
}
