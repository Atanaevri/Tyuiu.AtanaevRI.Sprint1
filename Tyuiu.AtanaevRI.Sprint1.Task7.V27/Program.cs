using Tyuiu.AtanaevRI.Sprint1.Task7.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Атанаев Р.И.| РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Работа со строками                  *");
        Console.WriteLine("* Задание #7                                                       *");
        Console.WriteLine("* Вариант #27                                               *");
        Console.WriteLine("* Выполнил: Атанаев Р. И. | РППб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой.  *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Введите значение Х");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение У");
        double y = Convert.ToDouble(Console.ReadLine());

        double result = ds.Calculate(x, y);
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(result);


        Console.ReadKey();

    }
}