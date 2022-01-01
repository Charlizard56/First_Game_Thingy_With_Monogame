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
        
        private Texture2D T_Egg;
        private Rectangle[] Source_Rec = new Rectangle[3];       
        private Sprite_Slice S_Slice = new Sprite_Slice();
        
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            //Slice
            for (int i = 0; i < Source_Rec.Length; i++) {
                Source_Rec[i] = S_Slice.Slice(Source_Rec[i]);
            }
            
            //Set Animation Time
            Animation.Set_Time(100);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            T_Egg = Content.Load<Texture2D>("blue_egg_big_sheet");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            Updates.Step(gameTime);
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            var m_x = Set_State.mon.Get_X();
            var m_y = Set_State.mon.Get_Y();
            var m_w = Set_State.mon.Get_W(); 
            var m_h = Set_State.mon.Get_H();

            _spriteBatch.Begin(); 
            _spriteBatch.Draw(T_Egg, new Rectangle(m_x,m_y,m_w-m_x,m_h-m_y), Source_Rec[Animation.Animate(Source_Rec,80)], Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
