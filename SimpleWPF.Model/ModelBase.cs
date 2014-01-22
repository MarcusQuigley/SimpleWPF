using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SimpleWPF.Model
{
    public class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected void OnPropertyChanged(string propertyName)
        {
            if (TypeDescriptor.GetProperties(this.GetType())[propertyName] == null)
                throw new InvalidOperationException
                    (string.Format("{0} is not a valid property", propertyName));

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
