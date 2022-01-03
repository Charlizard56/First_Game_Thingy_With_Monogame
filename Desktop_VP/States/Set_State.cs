using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Desktop_VP
{
    //Start of Game
    static class Set_State
    {
        //Int

        //Bool
        static private bool Fullscreen;
        static public bool fullscreen { get { return Fullscreen; } set { Fullscreen = value; } }

        //Strings
        static private string[] Life_State = new string[6] {"Egg","Baby","Child","Teen","Adult","Dead" };
        static public string[] life_state { get { return Life_State; } set { Life_State = value; } }

        //Get Components
        static public Animation An_3_Frames = new Animation();
        static public Animation An_6_Framse = new Animation();

        //Objects   
        static public Monster mon = new Monster("fred", new Vector2(465, 40), new Vector2(0, 0), new Vector2(0, 0), 64,"Egg");

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
