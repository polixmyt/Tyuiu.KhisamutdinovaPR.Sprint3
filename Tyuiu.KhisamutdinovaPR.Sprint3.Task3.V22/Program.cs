using Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V22.Lib;
namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила Хисамутдинова П.Р. | Вариант 22";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл foreach                                                      *");
            Console.WriteLine("* Задание: найти максимальное количество подряд идущих 'b'                *");
            Console.WriteLine("* Вариант 22                                                              *");
            Console.WriteLine("* Выполнила: Хисамутдинова Полина Руслановна, ПКТб-25-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            DataService ds = new DataService();
            string text = "thbbbb dsfbg bbg";

            int result = ds.GetMaxConsecutiveB(text);

            Console.WriteLine("Исходная строка: " + text);
            Console.WriteLine("Максимальное количество подряд идущих 'b': " + result);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена. Нажмите любую клавишу...                           *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}