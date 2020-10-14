using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CheckAL
{
    public partial class ResultBAC : ContentPage
    {
        // ค่าการคำนวนของ เพศชาย เเละ เพศหญิง
        private const double Female = 0.55;
        private const double Male = 0.68;
        public string levelBAC = "";
        // รับค่ามาจากหน้า second เอามาใส่ในตัวแปรตามที่กำหนด เเละกำหนด type
        public ResultBAC(String gender,String wight,String height,String alcohol, TimePicker startTime, TimePicker endTime)
        {
            InitializeComponent();

            // แปลงค่า ที่ส่งมาจาก String เป็น int 
            float IntWeight = Convert.ToInt64(wight);
            float.Parse(height);
            // เเบ่ง เงื่อนไขสำหรับการคำนวนของผู้ชาย เเละ ผู้หญิง 

            if (gender == "Female")

            {
                float CalBAC = (float)(500 * 40 * 0.79) / 100;
                float BAC2 = (float)(CalBAC / (Female * IntWeight));
                float al = (float)System.Math.Round(BAC2, 2);
                string alinblood = Convert.ToString(al);

                double calTimeSober = (al * 100) / 15;
                double calTime = (al * 100) - 50;
                double calTimeBehind = calTime / 15;
                float sober = (float)System.Math.Round(calTimeSober, 2);
                float behind = (float)System.Math.Round(calTimeBehind, 2);

                if (al * 100 <= 50)
                {
                    levelBAC = "Sobriety";
                }

                else if (al * 100 <= 120)
                {
                    levelBAC = "Tipsy";
                }

                else if (al * 100 <= 250)
                {
                    levelBAC = "DrunK";
                }
                else if (al * 100 <= 300)
                {
                    levelBAC = "Blackout";
                }
                else if (al * 100 <= 400)
                {
                    levelBAC = "Stupor";
                }
                else if (al * 100 <= 450)
                {
                    levelBAC = "Coma";
                }
                else if (al * 100 > 450)
                {
                    levelBAC = "Dead";
                }

                BAC.Text = "BAC   \t\t\t\t\t\t\t\t\t " + alinblood + " g/kg";
                Level.Text = "Level of BAC \t\t\t\t\t\t " + levelBAC;
                Time_Sober.Text = "Time to sober in \t\t\t\t\t" + sober + " hm";
                Time_behind.Text = "Time to sit behind the wheel \t\t" + behind + " hm";
                Limit.Text = "Legal Limit in Thailand \t\t\t" + "50mg%";
            }

            else if (gender == "Male")
            {

                float CalBAC = (float)(500 * 40 * 0.79) / 100;
                float BAC2 = (float)(CalBAC / (Male * IntWeight));
                float al = (float)System.Math.Round(BAC2, 2);
                string alinblood = Convert.ToString(al);
                double calTimeSober = (al * 100) / 15;
                double calTime = (al * 100) - 50;
                double calTimeBehind = calTime / 15;
                float sober = (float)System.Math.Round(calTimeSober, 2);
                float behind = (float)System.Math.Round(calTimeBehind, 2);
                // เช็คระดับ al ว่าอยู่ระดับไหน 
                if (al * 100 <= 50)
                {
                    levelBAC = "Sobriety";
                }

                else if (al * 100 <= 120)
                {
                    levelBAC = "Tipsy";
                }

                else if (al * 100 <= 250)
                {
                    levelBAC = "DrunK";
                }
                else if (al * 100 <= 300)
                {
                    levelBAC = "Blackout";
                }
                else if (al * 100 <= 400)
                {
                    levelBAC = "Stupor";
                }
                else if (al * 100 <= 450)
                {
                    levelBAC = "Coma";
                }
                else if (al * 100 > 450)
                {
                    levelBAC = "Dead";
                }



                BAC.Text = "BAC   \t\t\t\t\t\t\t\t\t " + alinblood + " g/kg";
                Level.Text = "Level of BAC \t\t\t\t\t\t " + "Level 5";
                Time_Sober.Text = "Time to sober in \t\t\t\t\t" + sober + " hm";
                Time_behind.Text = "Time to sit behind the wheel \t\t" + behind + " hm";
                Limit.Text = "Legal Limit in Thailand \t\t\t" + "50mg%";
            }
            

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
