using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Chompies.Shared.Tests
{
    [TestClass]
    public class SerializeActors
    {
        [TestMethod]
        public void SerializeDeserialize()
        {
            var world = new World();
            world.Populate(20, 20, 8);

            // The players are Bob and Joe
            world.Players = new List<string> { "Bob", "Joe" };

            // Bob takes over a zombie
            world.Actors[0].Player = "Bob";

            // Joe joins as a new hero
            world.Actors.Add(new Hero { Id = Guid.NewGuid(), Position = new Vec(10, 10), Orientation = 1.2f, Velocity = new Vec(-1, -1), Player = "Joe" });

            var text = JsonConvert.SerializeObject(
                world.Actors,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            var actors2 = JsonConvert.DeserializeObject<List<Actor>>(
                text,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            Assert.AreEqual(world.Actors.Count, actors2.Count);
            Assert.AreEqual(1, actors2.Count(a => a.Player == "Bob"));
            Assert.AreEqual(1, actors2.Count(a => a.Player == "Joe"));
        }
    }
}
