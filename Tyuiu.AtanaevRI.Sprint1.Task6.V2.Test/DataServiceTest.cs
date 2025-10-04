using Newtonsoft.Json.Linq;
using Tyuiu.AtanaevRI.Sprint1.Task6.V2.Lib;
namespace Tyuiu.AtanaevRI.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string strTest = "Hello world";
            var res = ds.CheckHello(strTest);
           
            Assert.AreEqual(true, res);
        }
    }
}
