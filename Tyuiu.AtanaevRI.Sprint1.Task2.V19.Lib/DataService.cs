﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AtanaevRI.Sprint1.Task2.V19.Lib
{
    public class DataService : ISprint1Task2V19
    {
        public double ConvertInchToKm(int x)
        {
            double meters = x * 0.0254;
            return Math.Round(meters, 3);

            
        }
    }
}



