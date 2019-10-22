using AnimeCatalog.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimeCatalog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TitleListPage : ContentPage
    {
        TableView Menu { get; }
        public TitleListPage()
        {
            InitializeComponent();
            BindingContext = new AnimeListViewModel() { Navigation = Navigation };
            Menu = MenuTable;
            HideMenu(null, null);
        }

        void ShowMenuButtonClicked(object sender, EventArgs e)
        {
            MenuLayout.Children.Clear();
            MenuLayout.Children.Add(Menu);
        }

        private void HideMenu(object sender, EventArgs e)
        {
            Button bt = new Button() { Text = "показать меню" };
            MenuLayout.Children.Clear();
            MenuLayout.Children.Add(bt);
            System.EventHandler showMenuButtonClicked = ShowMenuButtonClicked;
            bt.Clicked += showMenuButtonClicked;
        }
    }
}