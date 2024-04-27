using InspectorDTP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace InspectorDTP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}