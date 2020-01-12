using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chompies.Shared.Tests
{
    [TestClass]
    public class CreateWorld
    {
        [TestMethod]
        public void CreateTest()
        {
            var world = new World();
            world.Populate(20, 20, 8);
            Assert.AreEqual(40, world.Scenery.Count);
            Assert.AreEqual(8, world.Actors.Count);
        }
    }
}
