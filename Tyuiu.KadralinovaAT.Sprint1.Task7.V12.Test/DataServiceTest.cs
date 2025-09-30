using Tyuiu.KadralinovaAT.Sprint1.Task7.V12.Lib;

namespace Tyuiu.KadralinovaAT.Sprint1.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 3;
            double wait = 817.594;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
