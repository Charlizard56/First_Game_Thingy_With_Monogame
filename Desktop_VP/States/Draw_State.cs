using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Desktop_VP
{
    static public class Draw_State
    {

        static public void Step_Draw(SpriteBatch S_B, GameTime gametime)
        {
            //Mon
            var m_x = Set_State.P1.Get_X();
            var m_y = Set_State.P1.Get_Y();
            var m_w = Set_State.P1.Get_W();
            var m_h = Set_State.P1.Get_H();

            S_B.Begin();
            //S_B.Draw(Set_State.t_egg, new Rectangle(), Set_State.source_rec[Set_State.An_3_Frames.Animate(Set_State.source_rec, 80,false)], Color.White);
            S_B.Draw(Set_State.t_bunny, new Rectangle(m_x, m_y, m_w - m_x, m_h - m_y), Set_State.source_rec_bunny[Set_State.An_6_Frames.Animate(Set_State.source_rec_bunny, 10,true)], Color.White);
            S_B.End();
        }
        
    }
}
