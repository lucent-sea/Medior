﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace Medior.BaseTypes
{
    public abstract class ViewModelBase : ObservableObject
    {
        public void InvokePropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    }
}