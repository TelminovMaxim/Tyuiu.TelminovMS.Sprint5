using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TelminovMS.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);
            string res = "";

            foreach(char c in str)
            {
                if ((c >= 'а' &&  c <= 'я') || (c == 'ё'))
                {
                    res += char.ToUpper(c);
                }
                else
                {
                    res += c;
                }
            }

            string ResPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V12.txt");

            File.WriteAllText(ResPath, res);

            return ResPath;
        }
    }
}
