using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Chompies.Shared.Tests
{
    [TestClass]
    public class SerializeWorld
    {
        [TestMethod]
        public void SerializeDeserializeTest()
        {
            var world = new World();
            world.Populate(20, 20, 8);

            // The players are Bob and Joe
            world.Players = new List<string>{ "Bob", "Joe" };

            // Bob takes over a zombie
            world.Actors[0].Player = "Bob";

            // Joe joins as a new hero
            world.Actors.Add(new Hero {Id = Guid.NewGuid(), Position = new Vec(10, 10), Orientation = 1.2f, Velocity = new Vec(-1, -1), Player = "Joe"});

            var text = JsonConvert.SerializeObject(
                world,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            var world2 = JsonConvert.DeserializeObject<World>(
                text, 
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            Assert.AreEqual(world.Scenery.Count, world2.Scenery.Count);
            Assert.AreEqual(world.Actors.Count, world2.Actors.Count);
            Assert.AreEqual(world.Players.Count, world2.Players.Count);
            Assert.IsTrue(world2.Players.Contains("Bob"));
            Assert.IsTrue(world2.Players.Contains("Joe"));
            Assert.AreEqual(1, world2.Actors.Count(a => a.Player == "Bob"));
            Assert.AreEqual(1, world2.Actors.Count(a => a.Player == "Joe"));
        }
    }
}
