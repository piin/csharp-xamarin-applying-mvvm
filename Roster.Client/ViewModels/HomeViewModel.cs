using System.Collections.ObjectModel;
using System.ComponentModel;
using Roster.Client.Models;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private string _title = "Roster App";
        private readonly string[] _names = new string[] { "Delores Feil", "Ann Zboncak", "Jaime Lesch" };
        private readonly string[] _companies = new string[] { "Legros Group", "Ledner - Ferry", "Herzog and Sons" };

        public event PropertyChangedEventHandler PropertyChanged;
        public Command UpdateApplicationCommand { get; }
        public ObservableCollection<Person> People { get; set; }
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(UpdateApplicationCommandExecute);
            MockPeople();
        }

        private void UpdateApplicationCommandExecute()
        {
            Title = "Roster App (v2.0)";
        }

        private void MockPeople()
        {
            People = new ObservableCollection<Person>();
            for (int i = 0; i < _names.Length; i++)
            {
                var person = new Person
                {
                    Name = _names[i],
                    Company = _companies[i]
                };
                People.Add(person);
            }
        }
    }
}
