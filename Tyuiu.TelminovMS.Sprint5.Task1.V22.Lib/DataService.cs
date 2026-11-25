using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TelminovMS.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 - x == 0)
                {
                    File.AppendAllText(path, "0" + Environment.NewLine);
                }
                else
                {
                    y = Math.Round((Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x), 2);
                    
                    if (x != stopValue)
                    {
                        File.AppendAllText(path, Convert.ToString(y) + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, Convert.ToString(y));
                    }

                }
            }

            return path;
        }
    }
}
