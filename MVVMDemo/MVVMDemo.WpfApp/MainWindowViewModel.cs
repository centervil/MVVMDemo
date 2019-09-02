using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.WpfApp
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private string nowTimeText = "initial";

        public MainWindowViewModel()
        {
        }

        public string NowTimeText
        {
            get
            {
                return nowTimeText;
            }
            set
            {
                nowTimeText = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
