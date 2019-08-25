using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyApp
{
    public partial class NotificationPage : ContentPage
    {
        public NotificationPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Title", "Hello World", "OK");
        }
    }
}
