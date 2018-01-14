using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using XMLData;

namespace GameV2
{
    class SplashScreen:GameScreen
    {

        Texture2D image;
        MyPaths path;
        MyPathArray paths;
        Vector2 position;
        //public string path;

        public override void LoadContent()
        {
            base.LoadContent();
            content = new ContentManager(ScreenManager.Instance.Content.ServiceProvider, "Content");

            path =content.Load<MyPaths>("Paths");
            path.Path = "deer";
           
            // paths = content.Load<MyPathArray("Paths");
            // Console.WriteLine(path.Path);
            image = content.Load<Texture2D>(path.Path);

            Console.WriteLine(path.Path);
           
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
            spriteBatch.Draw(image,Vector2.Zero, Color.White);

        }
    }
}
