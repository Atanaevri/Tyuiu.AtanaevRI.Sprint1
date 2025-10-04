using Tyuiu.AtanaevRI.Sprint1.Task5.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Атанаев Р.И.| РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Преобразование типов                        *");
        Console.WriteLine("* Задание #5                                                          *");
        Console.WriteLine("* Вариант #4                                                           *");
        Console.WriteLine("* Выполнил: Атанаев Р. И. | РППб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*. Написать программу, которая решает следующую задачу:\r\n\r\nИдет k-я секунда суток. Определить, сколько полных часов (h) прошло к этому моменту (например, h=3, если k=13257).  *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите количество секунд: ");
        int k = int.Parse(Console.ReadLine());






        double h = ds.SecondsToHours(k);
        Console.WriteLine("*                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
       



       

        // Вывод результата
        Console.WriteLine($"Прошло полных часов: {h}");
        Console.ReadKey();
    }
}