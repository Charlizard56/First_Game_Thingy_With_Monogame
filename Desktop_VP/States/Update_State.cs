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
        static public void Step(GameTime gametime,GraphicsDeviceManager _graphics) {
            var delta = (float)gametime.ElapsedGameTime.TotalSeconds;

            //Screen
            if (Keyboard.GetState().IsKeyDown(Keys.F1) && !Set_State.fullscreen) { Set_State.fullscreen = true; _graphics.ToggleFullScreen(); }
            else if (Keyboard.GetState().IsKeyUp(Keys.F1) && Set_State.fullscreen){ Set_State.fullscreen = false; }

            //Mouse
            if (Collision.Mouse_Check(Set_State.mon.Get_X(),Set_State.mon.Get_Y(), Set_State.mon.Get_W(),Set_State.mon.Get_H())) {
                Debug.WriteLine("True"); 
            }
            //else { Debug.WriteLine("False"); }
        }
        
}
}
