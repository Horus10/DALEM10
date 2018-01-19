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
    class SplashScreen : GameScreen
    {

        Texture2D image;
        Texture2D swich;
        MyPaths path;
        MyPathArray paths;
        Vector2 position;
        bool isOn,isChange,isOff;
        GameScreen Escenario1;
        SpriteFont font;
        //DANIEL ESTA AQUI!!1
        //Esteban es el mejor 
        //Pacheco lo logro

        public override void LoadContent()
        {
            base.LoadContent();
            content = new ContentManager(ScreenManager.Instance.Content.ServiceProvider, "Content");
            font= font = content.Load<SpriteFont>("Arial"); 
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
            }else if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                isOn = false;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && isOff == false)
            {
                UnloadContent();
                Escenario1 = new Escenario1();
                Escenario1.LoadContent();
                isChange = true;
                isOff = true;
            }

            if (isOff)
            {
                Escenario1.Update(gametime);
            }

            base.Update(gametime);
          
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (isOn == false)
            {
                spriteBatch.Draw(image, Vector2.Zero, Color.White);
                spriteBatch.DrawString(font, "Conejo", new Vector2(100, 100), Color.White);
            }
            else
            {
                spriteBatch.Draw(swich, Vector2.Zero, Color.White);
                spriteBatch.DrawString(font, "Lobo", new Vector2(100, 100), Color.White);
            }
            //spriteBatch.End();

            //spriteBatch.Begin();
            if (isChange)
            {
                Escenario1.Draw(spriteBatch);
            }
            //spriteBatch.End();
        }
    }
}
