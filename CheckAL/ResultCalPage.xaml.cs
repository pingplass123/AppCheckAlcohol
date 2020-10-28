using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CheckAL
{
    public partial class ResultCalPage : ContentPage
    {
        public double numCal = 0.0;
        public double numTime = 0.0;
        public ResultCalPage(string WeightCal,string Cal,String al)
        {
            
            InitializeComponent();
            
            double WeightNum = Convert.ToDouble(WeightCal);
            double CalNum = Convert.ToDouble(Cal);
            Calculate(WeightNum,Calnum,al);
            
            timeburn(WeightNum);
            float timeToBurn = (float)System.Math.Round(numTime, 2);
           

            calo.Text = "Calories = " + numCal;
            time.Text = "Time to burn out Cal = " + timeToBurn + " m/hr";
            
   
        }
         public void Calculate(double w, double c, string type)
        {
            

                double calorie;

                if (type == "Beer")
                {
                    calorie = c * 0.423; // เบียร์ 350 กรัม เท่ากับ 148 กิโลแคลลอรี่
                    numCal = calorie;
                    
                }
                else if (type == "Vodka" || type == "Wisky")
                {

                    calorie = c * 3; //วอดก้า 30 มิลลิลิตร เท่ากับ 90 กิโลแคลลอรี่
                    numCal = calorie;
                }

                else if (type == "Wine")
                {

                    calorie = c * 0.64; //ไวน์ 750 มิลลิลิตร เท่ากับ 480 กิโลแคลลอรี่
                    numCal = calorie;
                }

                else if (type == "Rum")
                {

                    calorie = c * 2.311; // รัม 100 มิลลิลิตร เท่ากับ 231.1
                   numCal = calorie;

                }
                else if (type == "Soju")
                {

                    calorie = c * 1.44; // 375 ml == 540 kcal
                    numCal = calorie;
                }
                else
                {
                    calorie = c * 2; // blend 1 ml == 2 kcal, Hong Thong 1 ml == 2 kcal
                    numCal = calorie;
                }
           
        }
        public void timeburn(double weightCal) 
        {
            double timeCal = 0.0;

            if (weightCal <= 57)
            {
                timeCal = (10 / 495) * numCal;
                numTime = timeCal;

            }
            else if (weightCal <= 70)
            {

                timeCal = (10.0 / 614) * numCal;
                numTime = timeCal;


            }
            else if (weightCal <= 84)
            {
                timeCal = (10.0 / 733) * numCal;
                numTime = timeCal;

            }
        }
        
    }
}
