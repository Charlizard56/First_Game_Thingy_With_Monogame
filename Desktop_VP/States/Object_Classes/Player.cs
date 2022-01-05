using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
namespace Desktop_VP
{
    class Player
    {
        private Vector2 Monster_Vector2;
        private Vector2 Monster_W, Monster_H;
        private int Sprite_Size;
        public int sprite_size { get { return Sprite_Size; } set { Sprite_Size = value; } }

        public Player(Vector2 _Monster_Vector2,Vector2 _Monster_W,Vector2 _Monster_H,int _Sprite_Size) 
        {
            Monster_Vector2 = _Monster_Vector2;
            Monster_W = _Monster_W;
            Monster_H = _Monster_H;
            Sprite_Size = _Sprite_Size;

            Set_Collsion_Box();
        }

        /// <summary>
        /// <para>Create collision box</para>
        /// </summary>
        public void Set_Collsion_Box() {
            Monster_W = new Vector2(Monster_Vector2.X + Sprite_Size, Monster_Vector2.Y);
            Monster_H = new Vector2(Monster_Vector2.X, Monster_Vector2.Y + Sprite_Size);
        }
        public int Get_X()
        {
            return (int)Monster_Vector2.X;
        }
        public int Get_Y()
        {
            return (int)Monster_Vector2.Y;
        }
        

        public void Set_X(float Speed, float Delta)
        {
            Monster_Vector2.X += Speed * Delta;
            Monster_W = new Vector2(Monster_Vector2.X + Sprite_Size, Monster_Vector2.Y);
        }
        public void Set_Y(float Speed,float Delta)
        {
            Monster_Vector2.Y += Speed * Delta;
            Monster_H = new Vector2(Monster_Vector2.X, Monster_Vector2.Y + Sprite_Size);
        }

        public int Get_W()
        {
            return (int)Monster_W.X;
        }
        public int Get_H()
        {
            return (int)Monster_H.Y;
        }
    }
}
