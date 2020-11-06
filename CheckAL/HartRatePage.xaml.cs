using System;
using System.Collections.Generic;
using Xamarin.Essentials;

using Xamarin.Forms;

namespace CheckAL
{
    public partial class HartRatePage : ContentPage
    {
        public HartRatePage()
        {
            
            InitializeComponent();
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                // Turn On
                await Flashlight.TurnOnAsync();

            }
            catch (Exception)
            {

            }

        }

        private async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            try
            {
                // Turn On
                await Flashlight.TurnOffAsync();

            }
            catch (Exception)
            {


            }


        }
    }
}