using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CheckAL
{
    public partial class ResultCalPage : ContentPage
    {
        public ResultCalPage(string HeightCal,string WeightCal,string Cal)
        {
            InitializeComponent();
            double HeightNum = Convert.ToDouble(HeightCal);
            double WeightNum = Convert.ToDouble(WeightCal);
            double CalNum = Convert.ToDouble(Cal);
            

            if (WeightNum <= 57)
            {

            }

            else if(WeightNum <= 70)
            {

            }

            else if(WeightNum <= 84)
            {

            }

            calo.Text = "Calories = " + Cal;
            time.Text = "Time to burn out Cal = 10 hr";
        }
    }
}
