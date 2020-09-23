using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CheckAL
{
    public partial class ResultBAC : ContentPage
    {
        private const double V = 0.55;

        public ResultBAC(String gender,String wight,String height,String alcohol,String startTime,String endTime)
        {
            InitializeComponent();

            
            float v2 = Convert.ToInt64(wight);
            float.Parse(height);

            float CalBAC = (float)(500 * 40 * 0.79) / 100;
            float BAC2 = (float)(CalBAC / (V * v2));
            float al = (float)System.Math.Round(BAC2, 2);
            string alinblood = Convert.ToString(al);
            

            //String a = CALBAC(gender, wight, height);

            BAC.Text = "BAC   \t\t\t\t\t\t\t\t\t " + alinblood + " g/kg";
            Level.Text = "Level of BAC \t\t\t\t\t\t " + "Level 5";
            Time_Sober.Text = "Time to sober in";
            Time_behind.Text = "Time to sit behind the wheel";
            

        }

       /* public String CALBAC(String g, String w, String h)
        {
            float v2 = Convert.ToInt64(w);
            float.Parse(h);

            float CalBAC = (float)(500 * 40 * 0.79) / 100;
            float BAC2 = (float)(CalBAC / (V * v2));
            float al = (float)System.Math.Round(BAC2, 2);
            string alinblood = Convert.ToString(al);

            return alinblood;
        }*/

        public String Caltime(String stime,String etime)
        {
            return null;
        }

        public String CalLevelBAC(String bac)
        {
            return null;
        }
    }
}
