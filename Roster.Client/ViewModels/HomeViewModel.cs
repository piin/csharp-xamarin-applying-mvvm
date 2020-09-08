using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        #region Public properties
        public event PropertyChangedEventHandler PropertyChanged;
        public Command UpdateApplicationCommand { get; set; }
        public string Title { get; set; } = "Roster App";
        #endregion

        public HomeViewModel()
        {
        }

        #region Private methos
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
