using Microsoft.Xna.Framework;

namespace Desktop_VP
{
    static class Sprite_Slice
    {
        static private int Total_Sprites, Width, Height, Size_x, Size_y;
        
        /// <summary>
        /// <para>Creates Rec values and stores it in an array</para>
        /// </summary>
        static private void Math_Slice()
        {
            if(Width < Size_x * Total_Sprites)
            {
                Width += Size_x;
            }
            else
            {Width = 0; Height += Size_y; }
        }

        static public void Set(int _width, int _height,int _size_x,int _size_y,int _times)
        {
            Width = _width;
            Height = _height;
            Size_x = _size_x;
            Size_y = _size_y;
            Total_Sprites = _times;
        }

        /// <summary>
        /// <para>Creates Rec to store in arrays</para>
        /// </summary>
        /// <param name="Source"></param>
        /// <returns>Rectangle(Width,Height,X,Y)</returns>
        static public Rectangle Slice(Rectangle Source)
        {
            Math_Slice();
            return new Rectangle(Width, Height, Size_x, Size_y);
        }





    }
}
