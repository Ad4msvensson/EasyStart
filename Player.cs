using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace EasyStart
{
    internal class Player : Actor
    {
        private float speed = 600f;
        private bool isGameFrozen = false;

        public override void Update(GameTime gameTime)
        {

            if (isGameFrozen)
                return;

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            Vector2 movement = Vector2.Zero;


            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                movement.Y -= 1;
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                movement.Y += 1;
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                movement.X -= 1;
                IsFlippedHorizontally = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                movement.X += 1;
                IsFlippedHorizontally = false;
            }


            if (movement != Vector2.Zero)
                movement.Normalize();

            Position += movement * speed * deltaTime;

            if (IsTouching(typeof(Dragon)))
            {
                Actor dragon = GetOneIntersectingActor(typeof(Dragon));

               
               
                    float x = dragon.X;
                    float y = dragon.Y;
                    World.Add(new Pow(), "pow2", x, y);
                    World.RemoveActor(dragon);
                
               
            }
            if (World.CountActors(typeof(Dragon)) <= 0)
            {
                World.ShowText("Winner Winner Chicken Dinner", 900, 450);
                isGameFrozen = true;
            }
        }
    }
}
