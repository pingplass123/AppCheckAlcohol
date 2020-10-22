using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CheckAL
{
    public partial class CalculateCal : ContentPage
    {
        public CalculateCal()
        {
            InitializeComponent();
            dataWeight();
            dataHeight();

        }

        private void dataHeight()
        {
            var listWeight =new List<string>();
            for(int i = 20; i <= 250; i++)
            {
                string w = i.ToString();
                listWeight.Add(w);
            }

            Weight.ItemsSource = listWeight;
        }

        private void dataWeight()
        {
            var listHeight = new List<string>();
            for(int j = 130; j <= 250; j++)
            {
                string h = j.ToString();
                listHeight.Add(h);
            }

            Height.ItemsSource = listHeight;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
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

        void Height_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

        }

        void Weight_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
        }
    }
}
