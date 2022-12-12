using Jorge_Rocha_Android_EFP6.Models;
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
    public partial class AskPage : ContentPage
    {
        AskViewModel viewModel;
        public AskPage()
        {
            InitializeComponent();
            this.Title = "Welcome! " + GobalItems.GlobalUser.FirstName + GobalItems.GlobalUser.LastName;
        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            if (txtAskDescription.Text == null || string.IsNullOrEmpty(txtAskDescription.Text.Trim()) ||
                txtImageURL.Text == null || string.IsNullOrEmpty(txtImageURL.Text.Trim()) ||
                txtAskDetail.Text == null || string.IsNullOrEmpty(txtAskDetail.Text.Trim()))
            {
                await DisplayAlert(":)", "Fill all the fields", "Ok");
                return;

            }

            bool R = await viewModel.AddNewAsk(
                txtAskDescription.Text.Trim(),
                3,
                txtImageURL.Text.Trim(),
                txtAskDetail.Text.Trim());

            if (R)
            {
                await DisplayAlert(":)", "Everything is ok", "Ok");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert(":(", "Something went wrong", "Ok");
            }
        }
    }
}