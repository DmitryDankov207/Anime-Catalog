using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AnimeCatalog.ViewModels;
using System.IO;
using AnimeCatalog.Shared;

namespace AnimeCatalog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAnimePage : ContentPage
    {
        public AnimeViewModel ViewModel { get; private set; }

        public AddAnimePage(AnimeViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }

        /*async void SaveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            if (edited == false)
            {
                NavigationPage navPage = (NavigationPage)Application.Current.MainPage;
                IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
                MainPage homePage
                    = navStack[navPage.Navigation.NavigationStack.Count - 1] as MainPage;

                if (homePage != null)
                {
                    homePage.AddTitle(Anime);
                }
            }
        }*/

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ViewModel.Types.Contains(picker.Items[picker.SelectedIndex]))
                ViewModel.Types.Add(picker.Items[picker.SelectedIndex]);
        }

        private void TypesView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ViewModel.Types.Remove(e.SelectedItem.ToString());
        }

        private void seriesEntry_Completed(object sender, EventArgs e)
        {
            ViewModel.Series.Add(seriesEntry.Text);
            seriesEntry.Text = null;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ViewModel.Series.Remove(e.SelectedItem.ToString());
        }

        async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        {
            Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            if (stream != null)
            {
                AnimeImage.Source = ImageSource.FromStream(() => stream);
            }
        }

    }
}