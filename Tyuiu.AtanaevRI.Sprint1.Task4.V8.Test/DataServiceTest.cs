using Tyuiu.AtanaevRI.Sprint1.Task4.V8.Lib;
namespace Tyuiu.AtanaevRI.Sprint1.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 25;
            double y = 16;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(2.786, res);
        }
    }
}
