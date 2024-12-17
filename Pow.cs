using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

using Microsoft.Xna.Framework;

namespace EasyStart
{
    internal class Pow : Actor
    {
        private float time = 0;
        public override void Update(GameTime gameTime)
        {
            time += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (time > 1)
            {
                World.RemoveActor(this);
            }
            
        }
    }
}
