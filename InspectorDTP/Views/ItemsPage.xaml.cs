using InspectorDTP.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace InspectorDTP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;
        private int id;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            LvDTP.ItemsSource = await App.Database.GetDTPAsync();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}
