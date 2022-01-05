using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Desktop_VP
{
    //Start of Game
    static class Set_State
    {
        #region//Types
        //Int

        //Float
        static private float Speed = 90f;
        static public float speed { get { return Speed; }set { Speed = value; } }

        //Bool
        static private bool Fullscreen;
        static public bool fullscreen { get { return Fullscreen; } set { Fullscreen = value; } }
        static private bool Key_Down = false;
        static public bool key_down {get { return Key_Down; } set { Key_Down = value; } }
        #endregion

        //Create Components
        static public Animation An_3_Frames = new Animation();
        static public Animation An_6_Frames = new Animation();

        //Objects   
        static public Player P1 = new Player(new Vector2(32, 40), new Vector2(0, 0), new Vector2(0, 0), 64);

        //Textures
        static private Texture2D T_Egg, T_Bunny;
        static public Texture2D t_egg { get { return T_Egg; } set { T_Egg = value; } }
        static public Texture2D t_bunny { get { return T_Bunny; } set { T_Bunny = value; } }

        //Rectangles
        static private Rectangle[] Source_Rec = new Rectangle[3];
        static private Rectangle[] Source_Rec_Bunny = new Rectangle[6];
        static public Rectangle[] source_rec { get { return Source_Rec; }set { Source_Rec = value; } }
        static public Rectangle[] source_rec_bunny { get { return Source_Rec_Bunny; } set { Source_Rec_Bunny = value; } }


    }
}
