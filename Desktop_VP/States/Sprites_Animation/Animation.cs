using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace Desktop_VP
{
    static class Animation
    {
        static private float Time;
        static private int Frame;

        static public int Animate(Rectangle[] Source,float Time_R) {
            var length = Source.Length - 1;
            Time--;
            //Debug.WriteLine(Time);
            //Debug.WriteLine(Frame);
            if (Time <= 0 && Frame < length) { Time = Time_R; return Frame++; }
            else if (Time <= 0 && Frame == length) { Time = Time_R; Frame = 0;return Frame; }
            else { return Frame; }
            
        }

        static public void Set_Time(float _Time) {
            Time = _Time;
        }
    }
}
