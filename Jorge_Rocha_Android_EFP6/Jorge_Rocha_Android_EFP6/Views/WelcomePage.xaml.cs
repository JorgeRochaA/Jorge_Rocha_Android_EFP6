using Jorge_Rocha_Android_EFP6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jorge_Rocha_Android_EFP6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        UserViewModel userVM;
        public WelcomePage()
        {
            InitializeComponent();
            this.BindingContext = userVM = new UserViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            int userId = 3;

            try
            {
                GobalItems.GlobalUser = await userVM.getUserData(userId);

                await Navigation.PushAsync(new AskPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
                return;
            }

        }
    }
}