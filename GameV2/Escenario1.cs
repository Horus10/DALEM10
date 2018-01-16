using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameV2
{
    class Escenario1:GameScreen
    {
        Texture2D slime;
        //SpriteBatch spriteBatch;
        //private object spriteBatch;

        public Escenario1()
        {
            
        }

        public override void LoadContent()
        {
            content = new ContentManager(ScreenManager.Instance.Content.ServiceProvider, "Content");
            slime = content.Load<Texture2D>("Slime");


            base.LoadContent();
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gametime)
        {
            base.Update(gametime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Begin();
            spriteBatch.Draw(slime, Vector2.Zero, Color.White);
            //spriteBatch.End();
           //base.Draw(spriteBatch);
        }


    }
}
