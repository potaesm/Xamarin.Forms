using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp
{
    //[XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;
            /*if (Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(0, 21, 0, 0);
            }*/
        }
    }
}
