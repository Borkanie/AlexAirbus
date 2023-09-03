using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerotec.GUI.ViewModel
{
    public class MyDataModel : INotifyPropertyChanged
    {
        private string _myTextProperty;

        public string MyTextProperty
        {
            get { return _myTextProperty; }
            set
            {
                if (_myTextProperty != value)
                {
                    _myTextProperty = value;
                    OnPropertyChanged(nameof(MyTextProperty));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
