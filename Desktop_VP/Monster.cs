using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
namespace Desktop_VP
{
    class Monster
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private Vector2 Monster_Vector2;
        private Vector2 Monster_W, Monster_H;
        private int Sprite_Size;

        public Monster(string _Name,Vector2 _Monster_Vector2,Vector2 _Monster_W,Vector2 _Monster_H,int _Sprite_Size) 
        {
            name = _Name;
            Monster_Vector2 = _Monster_Vector2;
            Monster_W = _Monster_W;
            Monster_H = _Monster_H;
            Sprite_Size = _Sprite_Size;

            Set_Collsion_Box();
        }

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
