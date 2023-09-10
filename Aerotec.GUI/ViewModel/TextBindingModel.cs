using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerotec.GUI.ViewModel
{
    public class TextBindingModel : INotifyPropertyChanged
    {
        private string _myTextProperty;

        public string Content
        {
            get { return _myTextProperty; }
            set
            {
                if (_myTextProperty != value)
                {
                    _myTextProperty = value;
                    OnPropertyChanged(nameof(Content));
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
