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
        public AskPage()
        {
            InitializeComponent();
            this.Title = "Welcome! " + GobalItems.GlobalUser.FirstName + GobalItems.GlobalUser.LastName;
        }
    }
}