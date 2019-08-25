using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp
{
    [XamlCompilation(XamlCompilationOptions.Skip)]

    public partial class ExercisePage : ContentPage
    {
        UInt16 number = 0;

        public ExercisePage()
        {
            InitializeComponent();
            slider.Value = 16;
            label.Text = "It is a long established fact that a reader will be distracted by the readable content of a page.";
            if (Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(20, 20, 20, 20);
            } else if (Device.RuntimePlatform == Device.Android)
            {
                Padding = new Thickness(20, 30, 20, 20);
            }
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            switch (number) {
                case 0: number++; label.Text = "Contrary to popular belief, Lorem Ipsum is not simply random text."; break;
                case 1: number++; label.Text = "There are many variations of passages of Lorem Ipsum available."; break;
                case 2: number++; label.Text = "It has roots in a piece of classical Latin literature from 45 BC."; break;
                case 3: number = 0; label.Text = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested."; break;
                default: break;
            }
        }
    }
}
