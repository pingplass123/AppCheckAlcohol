using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CheckAL
{
    public partial class SecondPage : ContentPage
    {
        public String gen;
        public String alcoholType;
        
        public SecondPage()
        {
            InitializeComponent();
            dataPicker();
            dataPickerAl();
            dataWeight();

        }
        private void dataWeifht()
        {
        
        }
        private void dataPickerAl()
        {
            var listAl = new List<string>();
            listAl.Add("Beer");
            listAl.Add("Vodka");
            listAl.Add("Wine");
            listAl.Add("Rum");
            listAl.Add("Bend 285");
            listAl.Add("Hong thong");
            listAl.Add("Soju");
            listAl.Add("Wisky");
            Alcohol.ItemsSource = listAl;
         }
        private void Alcohol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var alcoholTypeData = Alcohol.SelectedItem as string;
            alcoholType = alcoholTypeData;
        }
        private void dataPicker()
        {
            var listData = new List<string>();
            listData.Add("Male");
            listData.Add("Female");
            
            Gender.ItemsSource = listData;
        }
        
        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            var genderType = Gender.SelectedItem as string;
            gen = genderType;
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Gender.Text == "" || wight.Text == "" || Hight.Text == "" || Alcohol == null){

                bool answer = await DisplayAlert("Warning!", "Please complete all information.", "Yes","No");
                
            }
            

            else{
                await Navigation.PushAsync(new ResultBAC(gen,wight.Text, Hight.Text, AlcoholType,StartTime,EndTime));
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
