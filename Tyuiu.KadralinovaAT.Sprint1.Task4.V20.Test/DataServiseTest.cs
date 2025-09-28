using Tyuiu.KadralinovaAT.Sprint1.Task4.V20.Lib;

namespace Tyuiu.KadralinovaAT.Sprint1.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 1.16;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
