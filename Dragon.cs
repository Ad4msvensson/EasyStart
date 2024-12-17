using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;


namespace EasyStart
{
    internal class Dragon : Actor
    {
        private static Random random = new Random();
        private float time = 20;
        float xSpeed = 2f;
        float ySpeed = 2f;


        public override void Update(GameTime gametime)
        {
            // slump 
            // en riktning 1 - 2 sek slump
            // sedan byt riktning
            time -= 1;
            if (time < 0)
            {
                time = random.Next(10, 20);

                xSpeed = random.Next(-2, 3); // -2, -1, 0, 1, or 2
      
                ySpeed = random.Next(-2, 3);

            }

            X += xSpeed;

            Y += ySpeed;


            
        }


       
    }
}

