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
        Texture2D slime, actualSlime;
        Vector2 slimePosition;
        public int FrameCounter, SwitchFrame;
        public Vector2 CurrentFrame, AmountOfFrames;
        public int FrameWidth
        {
            get
            {
                return slime.Width / (int) AmountOfFrames.X;
            }
        }

        public int FrameHeight
        {
            get
            {
                return slime.Height / (int)AmountOfFrames.Y;
            }
        }
        //SpriteBatch spriteBatch;
        //private object spriteBatch;

        public Escenario1()
        {

            AmountOfFrames = new Vector2(4,8);
            CurrentFrame = new Vector2(1,0);
            SwitchFrame = 100;
            FrameCounter = 0;

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
            Vector2 Movement = Vector2.Zero;

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Movement.X += 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Movement.X -= 2;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                Movement.Y -= 2;

            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                Movement.Y += 2;
            }


            if (slimePosition.X > ScreenManager.Instance.Dimensions.X - slime.Width)
            {
                slimePosition.X -= 2;
            }
            if (slimePosition.X < 0)
            {
                slimePosition.X += 2;
            }
             if (slimePosition.Y < 0)
            {
                slimePosition.Y += 2;
            }
            if (slimePosition.Y > ScreenManager.Instance.Dimensions.Y - slime.Height)
            {
                slimePosition.Y -= 2;
            }


            slimePosition += Movement;

            FrameCounter = 0;
            CurrentFrame.X++;


            base.Update(gametime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Begin();
            spriteBatch.Draw(actualSlime, slimePosition, Color.White);
            //spriteBatch.End();
           //base.Draw(spriteBatch);
        }


    }
}
