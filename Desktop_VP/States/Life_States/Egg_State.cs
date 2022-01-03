using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Desktop_VP
{
    static class Egg_State
    {
        static private float Hatch_Time;
        static Random ran = new Random();
        static float time;

        static public void Set_Egg() {
            time = ran.Next(400, 1200);
        }
        static public void Egg() {
            Debug.WriteLine(time.ToString());
            time--;
        } 

        

    }
}
