using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaldenHospitalLenovo.Handler
{
     public interface IRequestHttpHandler<in T> where T : class
        {
            // Get all Data
            void FetchAllData();
            // Create new resource ( means new data)
            //This is unimplement method
            void Post();


        }
    }

