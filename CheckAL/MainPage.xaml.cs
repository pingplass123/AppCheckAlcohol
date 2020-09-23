using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CheckAL;

namespace CheckAL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());

        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
        }

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
        }
    }
}
