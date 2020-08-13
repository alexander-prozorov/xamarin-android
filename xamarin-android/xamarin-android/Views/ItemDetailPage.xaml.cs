using System.ComponentModel;
using Xamarin.Forms;
using xamarin_android.ViewModels;

namespace xamarin_android.Views
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