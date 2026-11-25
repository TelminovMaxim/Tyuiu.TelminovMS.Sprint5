using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TelminovMS.Sprint5.Task4.V9.Lib
{
    public class DataService : ISprint5Task4V9
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Replace('.', ',');

            double res = 1 / Math.Sin(Convert.ToDouble(strX)) + Math.Pow(Convert.ToDouble(strX), 2);
            return Math.Round(res, 3);
        }
    }
}
