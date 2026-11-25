using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TelminovMS.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            double[] numbers = Array.ConvertAll(str.Replace('.', ',').Split(' '), double.Parse);

            double min = Math.Round(numbers.Min(), 3);

            return min;
        }
    }
}
