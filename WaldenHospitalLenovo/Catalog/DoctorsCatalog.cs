using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Web.Http;
using Newtonsoft.Json;
using WaldenHospitalLenovo.Handler;
using WaldenHospitalLenovo.Model;

namespace WaldenHospitalLenovo.Catalog
{
    public class DoctorsCatalog :IRequestHttpHandler<Doctor>
   {
      
       private ObservableCollection<Doctor> _doc;

       public ObservableCollection<Doctor> Doc
       {
           get { return _doc; }
           set { _doc = value; }
       }

        private const string Uri = "Http://localhost:55827/api/Doctors";
        public async void FetchAllData()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = "";
                    Task task = Task.Run(async () =>
                    {
                        // sends GET request
                        // ReSharper disable once AccessToDisposedClosure
                        response = await client.GetStringAsync(new Uri(Uri));
                    });
                    // Wait
                    task.Wait();
                    // convert Json into Objects
                    if (response != null)
                    {

                        Doc = JsonConvert.DeserializeObject<ObservableCollection<Doctor>>(response);
                        // call on property change Interface
                    }
                }
                catch (Exception ex)
                {
                    //// Display successful message
                    var messageDialog = new MessageDialog(ex.Message);
                    await messageDialog.ShowAsync();
                }
            }
        }

        public DoctorsCatalog()
        {
            Doc = new ObservableCollection<Doctor>();
            _doc = SeeDoctor();

            FetchAllData();
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

     
        public void Post()
        {
            throw new NotImplementedException();
        }
   }
}
