using Tyuiu.AtanaevRI.Sprint1.Task4.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Атанаев Р.И.| РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Операторы составного присваивания в C#                            *");
        Console.WriteLine("* Задание #4                                                           *");
        Console.WriteLine("* Вариант #8                                                           *");
        Console.WriteLine("* Выполнил: Атанаев Р. И. | РППб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой.\r\n\r\n   *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение Х");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение У");
        double y = Convert.ToDouble(Console.ReadLine());


      




        double result = ds.Calculate(x, y);
        Console.WriteLine("*                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(result);



      
        Console.ReadKey();
    }
}