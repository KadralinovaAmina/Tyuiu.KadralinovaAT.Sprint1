using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KadralinovaAT.Sprint1.Task7.V12.Lib
{
    public class DataService : ISprint1Task7V12
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Pow((x + 1) / (x - 1), x) + 18 * x * Math.Pow(y, 2);
            double res = Math.Round(z, 3);
            return res;
            
        }
    }
}
