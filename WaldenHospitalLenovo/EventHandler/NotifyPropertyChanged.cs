﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WaldenHospitalLenovo.EventHandler
{
    public class NotifyPropertyChanged : INotifyPropertyChanged
     {
         public event PropertyChangedEventHandler PropertyChanged;

        
         protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
         {
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
         }
    }
}
