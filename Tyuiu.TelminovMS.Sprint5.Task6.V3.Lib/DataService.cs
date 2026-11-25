using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TelminovMS.Sprint5.Task6.V3.Lib
{
    public class DataService : ISprint5Task6V3
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);

            int count = 0;
            foreach(char c in str)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    count++;
                }
            }

            return count;


        }
    }
}
