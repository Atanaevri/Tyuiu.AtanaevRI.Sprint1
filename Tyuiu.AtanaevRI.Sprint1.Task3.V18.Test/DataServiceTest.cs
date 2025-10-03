using Tyuiu.AtanaevRI.Sprint1.Task3.V18.Lib;
namespace Tyuiu.AtanaevRI.Sprint1.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 10;
            double b = 8;
            double c = 3;
            double wait = 6 ;
            var res = ds.HowManySquares(a,b,c);
            Assert.AreEqual(wait, res);

        }
    }
}
