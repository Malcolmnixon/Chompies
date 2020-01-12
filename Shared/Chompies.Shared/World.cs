using System;
using System.Collections.Generic;

namespace Chompies.Shared
{
    /// <summary>
    /// World class
    /// </summary>
    public class World
    {
        /// <summary>
        /// List of scenery elements
        /// </summary>
        public List<Scenery> Scenery { get; set; } = new List<Scenery>();

        /// <summary>
        /// List of actors
        /// </summary>
        public List<Actor> Actors { get; set; } = new List<Actor>();

        /// <summary>
        /// List of players
        /// </summary>
        public List<string> Players { get; set; } = new List<string>();

        public void Populate(
            int width,
            int length,
            int zombies)
        {
            // Verify geometry
            if (width <= 8 || length <= 8)
                throw new ArgumentException("Bad scene geometry");

            // Pick random number generator
            var rand = new Random();

            // Clear the scenery
            Scenery.Clear();

            // Generate scene
            var sceneItems = (width * length + 9) / 10;
            for (var i = 0; i < sceneItems; ++i)
            {
                var x = rand.Next(-width, width);
                var y = rand.Next(-length, length);
                var o = (float) (rand.NextDouble() * Math.PI * 2);
                var type = rand.Next(2);

                Scenery.Add(new Scenery
                {
                    Id = Guid.NewGuid(),
                    Position = new Vec(x, y),
                    Orientation = o,
                    Model = type == 0 ? "Tree" : "Rock"
                });
            }

            // Generate zombies
            for (var i = 0; i < zombies; ++i)
            {
                var x = rand.Next(-width, width);
                var y = rand.Next(-length, length);
                var o = (float)(rand.NextDouble() * Math.PI * 2);

                Actors.Add(new Zombie
                {
                    Id = Guid.NewGuid(),
                    Position = new Vec(x, y),
                    Orientation = o
                });
            }
        }
    }
}
