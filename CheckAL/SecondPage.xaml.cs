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
            if (Gender.Text == "" || wight.Text == "" || Hight.Text == "" || Alcohol.Text == ""){

                bool answer = await DisplayAlert("Warning!", "Please complete all information.", "Yes","No");
                
            }
            

            else{
                await Navigation.PushAsync(new ResultBAC(Gender.Text, wight.Text, Hight.Text, Alcohol.Text));
            }
            
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }

       



    }
}
