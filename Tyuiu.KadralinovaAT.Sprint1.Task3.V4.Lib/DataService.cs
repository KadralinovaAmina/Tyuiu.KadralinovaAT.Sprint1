using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KadralinovaAT.Sprint1.Task3.V4.Lib
{
    public class DataService : ISprint1Task3V4
    {
        public double PurchaseAmount(double x, double y, int z)
        {
            return Math.Round(z * (x + y), 3);
        }
    }
}
