using Tyuiu.TelminovMS.Sprint5.Task6.V3.Lib;

namespace Tyuiu.TelminovMS.Sprint5.Task6.V3
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Тельминов Максим Сергеевич | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V3.txt в котором есть       *");
            Console.WriteLine("* набор символьных данных. Найти количество латинских букв в заданной     *");
            Console.WriteLine("* строке.                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V3.txt";
            var res = ds.LoadFromDataFile(path);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine($"Файл: {path}");
            Console.WriteLine($"Найдет!");

            Console.WriteLine($"Результат: {res}");



            Console.ReadKey();
        }
    }
}
