using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        #region Public properties

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand UpdateApplicationCommand { get; set; }
        public string Title {
            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    NotifyPropertyChanged();
                }                
            }
        }

        #endregion

        #region Private properties

        private string _title;

        #endregion

        #region Public methods

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(OnUpdateApplicationCommand);
        }
        #endregion

        #region Private methods

        private void OnUpdateApplicationCommand()
        {
            Title = "Roster App (v2.0)";
        }

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
