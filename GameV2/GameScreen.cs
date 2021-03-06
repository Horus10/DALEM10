﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Xml.Serialization;

namespace GameV2
{
   public class GameScreen
    {

        protected ContentManager content;
        [XmlIgnore]
        public Type Type;

        public GameScreen()
        {
            Type = this.GetType();
        }

        public virtual void LoadContent()
        {

            content = new ContentManager(
                ScreenManager.Instance.Content.ServiceProvider, "Content"
                );
        }

        public virtual void UnloadContent()
        {
            content.Unload();
        }

        public virtual void Update(GameTime gametime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
