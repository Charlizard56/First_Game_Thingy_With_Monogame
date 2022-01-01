using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Desktop_VP
{
    class Sprite_Slice
    {
        public int Times = 5;
        public int width = -60;
        public int Height = 0;
        public int Size_x  = 60;
        public int Size_y  = 64;

        public void Math_Slice()
        {
            if(width < Size_x * 4)
            {
                width += Size_x;
            }
            else
            {width = 0; Height += Size_y; }
        }
        public Rectangle Slice(Rectangle Source)
        {
            Math_Slice();
            return new Rectangle(width, Height, Size_x, Size_y);
        }



    }
}
