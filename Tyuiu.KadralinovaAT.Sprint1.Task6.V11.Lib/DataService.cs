using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KadralinovaAT.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            char firstChar = value[0];
            return value.Substring(1).Contains(firstChar.ToString());
        }
    }
}
