using Tyuiu.AtanaevRI.Sprint1.Task1.V1.Lib;


namespace Tyuiu.AtanaevRI.Sprint1.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 12.0;
            double y = 2.0;
            double a = 4.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(26, res);
        }
    }
}
