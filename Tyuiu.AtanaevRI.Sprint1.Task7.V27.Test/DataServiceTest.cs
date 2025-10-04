using Tyuiu.AtanaevRI.Sprint1.Task7.V27.Lib;
namespace Tyuiu.AtanaevRI.Sprint1.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.200, res);
        }
    }
}
