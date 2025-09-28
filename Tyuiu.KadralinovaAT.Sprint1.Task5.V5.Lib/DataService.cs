using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KadralinovaAT.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double a = Math.Truncate(x);
            double b = x - a;
            double c = b * 10;
            int d = (int)Math.Truncate(c);

            return d;
        }
    }
}
