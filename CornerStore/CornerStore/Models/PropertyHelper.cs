using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CornerStore.Models
{
    public class PropertyHelper : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
