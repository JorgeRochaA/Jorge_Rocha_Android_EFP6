using Jorge_Rocha_Android_EFP6.ViewModels;
using Jorge_Rocha_Android_EFP6.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Jorge_Rocha_Android_EFP6
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
