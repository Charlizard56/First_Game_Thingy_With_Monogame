using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
namespace Desktop_VP
{
    class Monster
    {
        private string Name, Life_State;
        public string name { get { return Name; } set { Name = value; } }
        public string life_state { get{ return Life_State; }set{ Life_State = value; } }
        private Vector2 Monster_Vector2;
        private Vector2 Monster_W, Monster_H;
        private int Sprite_Size;

        public Monster(string _Name,Vector2 _Monster_Vector2,Vector2 _Monster_W,Vector2 _Monster_H,int _Sprite_Size,string _Life_State) 
        {
            Name = _Name;
            Monster_Vector2 = _Monster_Vector2;
            Monster_W = _Monster_W;
            Monster_H = _Monster_H;
            Sprite_Size = _Sprite_Size;
            Life_State = _Life_State;

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
