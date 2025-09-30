using Tyuiu.KadralinovaAT.Sprint1.Task6.V11.Lib;

namespace Tyuiu.KadralinovaAT.Sprint1.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "abca";
            DataService ds = new DataService();
            bool res = ds.CheckeFirstLetterRepetition(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
