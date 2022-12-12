using Jorge_Rocha_Android_EFP6.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Jorge_Rocha_Android_EFP6.Views
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