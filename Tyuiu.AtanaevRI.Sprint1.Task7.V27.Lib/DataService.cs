using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AtanaevRI.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double numerator1 = Math.Cos(x * x) + Math.Sin(y * y);
            double denominator1 = Math.Sin(y) + 1;

            double numerator2 = (x * y) - 12;
            double denominator2 = 15 + Math.Cos(x);

            double z = (numerator1 / denominator1) - (numerator2 / denominator2);

           
            return (Math.Round(z, 3));
        }
    }
}
