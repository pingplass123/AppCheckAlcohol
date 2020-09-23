using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CheckAL
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
     
        }
    

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ResultBAC(Gender.Text,wight.Text,Hight.Text,Alcohol.Text,StartTime.Text,EndTime.Text));
        }


    }
}
