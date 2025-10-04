using Tyuiu.AtanaevRI.Sprint1.Task6.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Атанаев Р.И.| РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Работа со строками                  *");
        Console.WriteLine("* Задание #6                                                         *");
        Console.WriteLine("* Вариант #2                                                       *");
        Console.WriteLine("* Выполнил: Атанаев Р. И. | РППб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, есть и в строке слово Hello.  *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");



        Console.Write("Введите текст: ");
        string text = Console.ReadLine(); // Получаем введённый текст

        // Проверяем, содержит ли введённая строка слово "Hello"
        bool containsHello = text.ToLower().Contains("hello"); 
        // Формирование заголовка результата
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("***************************************************************************");

        // Сообщаем результат пользователю
        if (containsHello)
        {
            Console.WriteLine("Да, строка содержит слово 'Hello'.");
        }
        else
        {
            Console.WriteLine("Нет, строка не содержит слово 'Hello'.");
        }

       
        Console.ReadKey();




    }
}