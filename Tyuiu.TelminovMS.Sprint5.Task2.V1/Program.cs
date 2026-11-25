using Tyuiu.TelminovMS.Sprint5.Task2.V1.Lib;

namespace Tyuiu.TelminovMS.Sprint5.Task2.V1
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Тельминов Максим Сергеевич | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите число строк:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число столбцов:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            int[,] k = new int[x1, x2];
            int count = 0;
            for (int i = 0; i < x1; i++)
            {
                for (int j = 0;  j < x2; j++)
                {
                    count++;
                    Console.WriteLine($"Введите элемент {count}:");
                    k[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.SaveToFileTextData(k);

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine($"Создан!");



            Console.ReadKey();
        }
    }
}
