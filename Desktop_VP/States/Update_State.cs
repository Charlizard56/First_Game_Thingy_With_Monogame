using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
namespace Desktop_VP
{

    static class Update_State
    {
        static public void Step(GameTime gametime, GraphicsDeviceManager _graphics)
        {
            var delta = (float)gametime.ElapsedGameTime.TotalSeconds;
            var Key = Keyboard.GetState();

            //Screen
            if (Key.IsKeyDown(Keys.F1) && !Set_State.fullscreen) { Set_State.fullscreen = true; _graphics.ToggleFullScreen(); }
            else if (Key.IsKeyUp(Keys.F1) && Set_State.fullscreen) { Set_State.fullscreen = false; }

            //Mouse
            if (Collision.Mouse_Check(Set_State.P1.Get_X(), Set_State.P1.Get_Y(), Set_State.P1.Get_W(), Set_State.P1.Get_H()))
            {
                Debug.WriteLine("True");
            }
            
            
            //Player Movement
            if (Key.IsKeyDown(Keys.S) && Key.IsKeyUp(Keys.W)){
                if(Set_State.P1.Get_H() < _graphics.PreferredBackBufferHeight - 4)
                {
                    Set_State.P1.Set_Y(Set_State.speed, delta);
                }               
            }
            if (Key.IsKeyDown(Keys.W) && Key.IsKeyUp(Keys.S))
            {
                if (Set_State.P1.Get_H() > 0 + Set_State.P1.sprite_size)
                {
                    Set_State.P1.Set_Y(-Set_State.speed, delta);
                }
            }

        }
    }
}
