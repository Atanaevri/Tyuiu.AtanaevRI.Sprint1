using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AtanaevRI.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            int countByWidth = (int)Math.Floor(a / c);   // Сколько квадратов вмещается по ширине
            int countByHeight = (int)Math.Floor(b / c);  // Сколько квадратов вмещается по высоте

            // Полное количество квадратов
            int totalCount = countByWidth * countByHeight;

            // Возвращаем результат с тремя знаками после запятой
            return Math.Round((double)totalCount, 3);
        }
    }
}
