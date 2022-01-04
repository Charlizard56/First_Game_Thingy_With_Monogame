using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
namespace Desktop_VP
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            //Slice
            Sprite_Slice.Set(-60, 0, 60, 64, Set_State.source_rec.Length);
            for (int i = 0; i < Set_State.source_rec.Length; i++) {
                Set_State.source_rec[i] = Sprite_Slice.Slice(Set_State.source_rec[i]); 
            }
            Sprite_Slice.Set(-34, 0, 34, 44, Set_State.source_rec_bunny.Length);
            for (int b = 0; b < Set_State.source_rec_bunny.Length; b++) {
                Set_State.source_rec_bunny[b] = Sprite_Slice.Slice(Set_State.source_rec_bunny[b]);
            }

            //Set Animation
            Set_State.An_3_Frames.time = 80;
            Set_State.An_6_Framse.time = 8;

        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Set_State.t_egg = Content.Load<Texture2D>("blue_egg_big_sheet");
            Set_State.t_bunny = Content.Load<Texture2D>("Idle (34x44)");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            Update_State.Step(gameTime,_graphics);
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.PowderBlue);

            Draw_State.Step_Draw(_spriteBatch,gameTime);

            base.Draw(gameTime);
        }
    }
}
