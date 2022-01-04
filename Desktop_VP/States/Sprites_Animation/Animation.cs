using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace Desktop_VP
{
    class Animation
    {
        private float Time;
        public float time { get { return Time; } set { Time = value; } }
        private int Frame;
        private bool Back;

        /// <summary>
        /// <para>Flips thorugh Rect array</para>
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="Time_R"></param>
        /// <returns>Frame</returns>
        public int Animate(Rectangle[] Source,float _Time_R,bool _Loop) {
            try
            {
                Time--;
                if (Time <= 0)
                {
                    An(Source, _Time_R, _Loop);
                }               
            }            
            catch {
                Debug.WriteLine("Failed to Animate");
            }
            return Frame;
        }

        public void An(Rectangle[] Source,float Time_R,bool _Loop)
        {
            //To prevent array Overload
            var length = Source.Length; 
            

            //If not at the end of array...
            ////Add Frame
            if (Frame < length && !Back) { Time = Time_R;  Frame++; }
            //Subrtact Frame
            else if (Frame > 0 && Back) { Time = Time_R;  Frame--; }

            if (Frame == length - 1 && _Loop || Frame == 0 && _Loop)
            {
                if (Back) { Back = false; }
                else { Back = true; }
            }
            else if(Frame == length  && !_Loop) { Frame = 0; }
        }
    }
}
