using Tyuiu.TelminovMS.Sprint5.Task7.V12.Lib;

namespace Tyuiu.TelminovMS.Sprint5.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Тельминов М. С. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File                                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Тельминов Максим Сергеевич | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V12.txt в котором есть      *");
            Console.WriteLine("* набор символьных данных.Заменить все строчные русские буквы на заглавные*");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V12.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V12.txt";
            var res = ds.LoadDataAndSave(path);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine($"Файл: {path}");
            Console.WriteLine($"Найдет!");

            Console.WriteLine($"Результат: {File.ReadAllText(Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V12.txt"))}");



            Console.ReadKey();
        }
    }
}
