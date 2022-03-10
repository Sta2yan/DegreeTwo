using System;
using System.Collections.Generic;

namespace DegreeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maximumNumberExceed = 1000;
            int minimumNumberExceed = 2;
            int numberExceed = random.Next(minimumNumberExceed, maximumNumberExceed);
            int number = 2;
            int degreeExceed = 2;
            int degree = 1;
            int raiseDegree = 1;

            while (number < numberExceed)
            {
                number *= degreeExceed;
                degree += raiseDegree;
            }

            Console.WriteLine($"Число - {numberExceed} | Степень - {degree} | Число в степени - {number}");
        }
    }
}