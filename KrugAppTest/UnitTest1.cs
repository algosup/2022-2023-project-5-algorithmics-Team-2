using KrugApp;

namespace KrugAppTest
{
    [TestClass]
    public class TestTanks
    {
        [TestMethod]
        public void TankIsNotNull()
        {
            Tank tank = new Tank(100);
            Assert.IsNotNull(tank);
        }

        [TestMethod]
        public void TankHasCorrectCapacity()
        {
            Tank tank = new Tank(100);
            Assert.AreEqual(100, tank.Capacity);
        }

        [TestMethod]
        public void TankHasCorrectWine()
        {
            Tank tank = new Tank(100);
            Wine[] wine = {new Wine(50), new Wine(40), new Wine(30)};
            tank.Wine = wine;
            Assert.AreEqual(wine, tank.Wine);
        }
    }
}