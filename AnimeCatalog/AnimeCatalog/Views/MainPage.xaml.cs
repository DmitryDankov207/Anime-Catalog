using System;
using System.ComponentModel;
using Xamarin.Forms;
using AnimeCatalog.Views;
using AnimeCatalog.Models;
using AnimeCatalog.ViewModels;

namespace AnimeCatalog
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        internal AnimeCollection Collection { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Collection = new AnimeCollection ();
            AnimeList.ItemsSource = Collection;
        }

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddAnimePage(null), false);
        }

        internal void AddTitle(AnimeViewModel title)
        {
            if (title != null)
            {
                Collection.Add(title);
            }
            else
                DisplayAlert("error!", "", "Cancel");
        }

        private async void AnimeList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedAnime = e.SelectedItem as AnimeViewModel;
            if(selectedAnime != null)
            {
                AnimeList.SelectedItem = null;
                await Navigation.PushAsync(new AddAnimePage(selectedAnime));
            }
        }

        private void sortTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
