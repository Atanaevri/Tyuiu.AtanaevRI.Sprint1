using Tyuiu.AtanaevRI.Sprint1.Task3.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Атанаев Р.И.| РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Операторы составного присваивания в C#                            *");
        Console.WriteLine("* Задание #3                                                            *");
        Console.WriteLine("* Вариант #18                                                           *");
        Console.WriteLine("* Выполнил: Атанаев Р. И. | РППб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной C можно разместить внутри прямоугольника с размерами A x B без наложений. Ответ округлите до 3 знаков после запятой.\r\n\r\n    *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        
        Console.WriteLine("Введите Сторону А прямоугольника=");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите Сторону B прямоугольника=" );
        double b = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Введите Сторону C квадрата=");
        double c = Convert.ToDouble(Console.ReadLine());




        double result = ds.HowManySquares(a,b,c);
            Console.WriteLine("*                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество квадратов со стороной C можно разместить внутри прямоугольника с размерами A x B без наложений: {result}");
                
        

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}