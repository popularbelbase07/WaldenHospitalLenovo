using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace WaldenHospitalLenovo.Common
{
    class FrameNavigate
    {
        
        public static void ActivateFrameworkNavigation( Type type)
        {
            var frame = (Frame) Window.Current.Content;
            frame.Navigate(type);
            Window.Current.Content = frame;
            Window.Current.Activate();





        }
    }
}

