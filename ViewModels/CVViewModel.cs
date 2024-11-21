using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CVApp.Models;

namespace CVApp.ViewModels
{
    public class CVViewModel : INotifyPropertyChanged
    {
        private CVModel _cv;

        public CVModel CV
        {
            get => _cv;
            set
            {
                _cv = value;
                OnPropertyChanged();
            }
        }

        public CVViewModel()
        {
            CV = new CVModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
