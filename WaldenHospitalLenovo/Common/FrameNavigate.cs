using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace WaldenHospitalLenovo.Common
{
     public class FrameNavigate
    {
        public static void ActiveFrameNavigation(Type type)
        {
            var frame = (Frame) Window.Current.Content;
            frame.Navigate(type);
            Window.Current.Content = frame;
            Window.Current.Activate();
        }
    }
}
