using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace EasyStart
{
    internal class MyWorld : World
    {
        private Random random;


        public MyWorld() : base(1800, 900)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "skys";
            random = new Random();

            Add(new Player(), "yoshi5", 100, 100);
            Initialize();

        }

        public void Initialize()
        {
            for (int i = 0; i < 7; i++)  
            {

                   float x = random.Next(100, Width - 100);  // Random X position within screen bounds
                   float y = random.Next(100, Height - 100);  // Random Y position within screen bounds
                
                Add(new Dragon(),"dragon1", x, y);
                Pow pow = new Pow();
                Add(pow, "pow2", 700, 700);
                RemoveActor(pow);
            }

        }
    }
}

