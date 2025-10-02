using Tyuiu.AtanaevRI.Sprint1.Task2.V19.Lib;
namespace Tyuiu.AtanaevRI.Sprint1.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;

            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(0.127, res);
        }
    }
}
