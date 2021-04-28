using System;
using System.ComponentModel;

namespace PlantManager.ViewModels.Shared
{
    public class BaseViewModel: INotifyPropertyChanged
    {
        public BaseViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
