using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using XMLData;

namespace GameV2
{
    class SplashScreen:GameScreen
    {

        Texture2D image;
        Texture2D swich;
        MyPaths path;
        MyPathArray paths;
        Vector2 position;
        bool isOn;
        //DANIEL ESTA AQUI!!1
        //Esteban es el mejor 
       //Pacheco lo logro
       //No soy misael ;P

        public override void LoadContent()
        {
            base.LoadContent();
            content = new ContentManager(ScreenManager.Instance.Content.ServiceProvider, "Content");

            path =content.Load<MyPaths>("Paths");
            path.Path = "rabbit";

            swich = content.Load<Texture2D>("wolf");
           
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
            //Aqui esta
            if (Keyboard.GetState().IsKeyDown(Keys.Q))
            {
                isOn = true;
            }            

            base.Update(gametime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (isOn == false)
                spriteBatch.Draw(image, Vector2.Zero, Color.White);
            else
                spriteBatch.Draw(swich, Vector2.Zero, Color.White);
        }
    }
}
