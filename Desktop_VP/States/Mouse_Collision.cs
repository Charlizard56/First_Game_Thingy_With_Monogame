using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Microsoft.Xna.Framework.Input;
namespace Desktop_VP
{
    public static class Collision
    {
        static bool click = false;
        public static bool Mouse_Check(int Rec_X,int Rec_Y,int Rec_Width,int Rec_Height)
        {
            if (Mouse.GetState().X > Rec_X && Mouse.GetState().X < Rec_Width && Mouse.GetState().Y > Rec_Y && Mouse.GetState().Y < Rec_Height)
            {
                return true;
            }
            else { return false; }
        }
        public static bool Click() {
            if (!click && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                click = true;
                return true;
            }
            else if (click && Mouse.GetState().LeftButton == ButtonState.Released)
            {
                click = false;
                return false;
            }
            else { return false; }
        }

    }
}
