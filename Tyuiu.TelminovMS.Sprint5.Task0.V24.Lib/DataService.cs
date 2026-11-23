using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TelminovMS.Sprint5.Task0.V24.Lib
{
    public class DataService : ISprint5Task0V24
    {
        public string SaveToFileTextData(int x)
        {
            //string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double res = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2));
            res = Math.Round(res, 3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;

        }
    }
}
