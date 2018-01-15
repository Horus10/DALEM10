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
    class ScreenManager
    {

        private static ScreenManager instance;
        // [XmlIgnore]
        public Vector2 Dimensions { private set; get; }
        // [XmlIgnore]
        public ContentManager Content { private set; get; }
        // XmlManager<GameScreen> xmlGameScreenManager;

        GameScreen currentScreen;
        //[XmlIgnore]
    

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                    // XmlManager<ScreenManager> xml = new XmlManager<ScreenManager>();
                    //instance = xml.Load("Load/ScreenManager.xml");
                }

                return instance;
            }
        }


        public ScreenManager()
        {
            Dimensions = new Vector2(640, 480);
            currentScreen = new SplashScreen();

            // currentScreen = xmlGameScreenManager.Load("Load/SplashScreen.xml");
        }

        public void LoadContent(ContentManager Content)
        {
            this.Content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent();

        }

        public void UnloadContent()
        {
            currentScreen.UnloadContent();

        }

        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);

            

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);

        }

    }
}
