using System.Collections.Generic;
using System.Drawing;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using monogame_cros_platform.classes;
using monogame_cros_platform.enums;
using Color = Microsoft.Xna.Framework.Color;

namespace monogame_cros_platform
{
    public class AppGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private TileMap map;

        public AppGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            Window.Title = "Proof of concept: Find shape";
        }

        protected override void LoadContent()
        {
            map = new TileMap(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

    
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            map.Draw(gameTime);



            base.Draw(gameTime);
        }
    }
}
