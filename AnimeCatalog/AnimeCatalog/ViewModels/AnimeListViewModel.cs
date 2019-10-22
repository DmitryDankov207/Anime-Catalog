using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using AnimeCatalog.Shared;
using AnimeCatalog.Views;
using System;
using System.Linq;

namespace AnimeCatalog.ViewModels
{
    public class AnimeListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<AnimeViewModel> Titles { get; set; }

        public INavigation Navigation { get; set; }

        public ICommand CreateTitleCommand { protected set; get; }

        public ICommand DeleteTitleCommand { protected set; get; }

        public ICommand SaveTitleCommand { protected set; get; }

        public ICommand BackCommand { protected set; get; }

        public ICommand SortCommand { protected set; get; }

        AnimeViewModel _selectedTitle;

        public AnimeListViewModel()
        {
            Titles = new ObservableCollection<AnimeViewModel>();
            CreateTitleCommand = new Command(CreateTitle);
            DeleteTitleCommand = new Command(DeleteTitle);
            SaveTitleCommand = new Command(SaveTitle);
            BackCommand = new Command(Back);
            SortCommand = new Command(Sort);
        }

        public AnimeViewModel SelectedTitle
        {
            get => _selectedTitle;
            set
            {
                if(_selectedTitle != value)
                {
                    AnimeViewModel anime = value;
                    _selectedTitle = null;
                    OnPropertyChanged("SelectedTitle");
                    Navigation.PushAsync(new AddAnimePage(anime), false);
                }
            }
        }

        private void CreateTitle(object anime = null)
        {
            Navigation.PushAsync(new AddAnimePage(anime as AnimeViewModel ??
                new AnimeViewModel() { ListViewModel = this }), false);
        }

        private void DeleteTitle(object titleObject)
        {
            if (titleObject is AnimeViewModel title)
                Titles.Remove(title);
            Back();
        }

        private void Back()
        {
            Navigation.PopAsync(false);
        }

        private void SaveTitle(object titleObject)
        {
            if (titleObject is AnimeViewModel title && !Titles.Contains(title))
                Titles.Add(title);
            Back();
        }

        private void Sort()
        {

        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
