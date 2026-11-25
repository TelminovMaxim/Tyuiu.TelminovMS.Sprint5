using System.Text.Unicode;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TelminovMS.Sprint5.Task3.V15.Lib
{
    public class DataService : ISprint5Task3V15
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            

            double F = -1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x;
            F = Math.Round(F, 3);
            
            using(BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), encoding:System.Text.Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(F));
            }

            return path;
        }
    }
}
