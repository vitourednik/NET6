using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playground.Model;
using Playground.Data;

namespace Tests
{
    [TestClass]
    public class RandomPointGeneratorKvadrant
    {
        [TestMethod]
        public void TestKvadrant1()
        {
            Dimension dim = new Dimension(-1,1);
            var kvadrant = dim.Kvadrant();
            Assert.AreEqual(Kvadrant.Kvadrant1, kvadrant);
            
        }
        [TestMethod]
        public void TestKvadrant2()
        {
            Dimension dim = new Dimension(1, 1);
            var kvadrant = dim.Kvadrant();
            Assert.AreEqual(Kvadrant.Kvadrant2, kvadrant);
            dim = new Dimension(0, 1);
            kvadrant = dim.Kvadrant();
            Assert.AreEqual(Kvadrant.Kvadrant2, kvadrant);
            dim = new Dimension(1, 0);
            kvadrant = dim.Kvadrant();
            Assert.AreEqual(Kvadrant.Kvadrant2, kvadrant);
        }
        [TestMethod]
        public void TestKvadrant3()
        {
            Dimension dim = new Dimension(-1, -1);
            var kvadrant = dim.Kvadrant();
            Assert.AreEqual(Kvadrant.Kvadrant3, kvadrant);
        }
        [TestMethod]
        public void TestKvadrant4()
        {
            Dimension dim = new Dimension(1, -1);
            var kvadrant = dim.Kvadrant();
            Assert.AreEqual(Kvadrant.Kvadrant4, kvadrant);
        }
    }
}