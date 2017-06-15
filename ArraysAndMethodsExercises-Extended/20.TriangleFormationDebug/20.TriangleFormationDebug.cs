﻿
namespace _20.TriangleFormationDebug
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool triangleValidityCondition1 = a + b > c;
            bool triangleValidityCondition2 = b + c > a;
            bool triangleValidityCondition3 = a + c > b;

            bool isValidTriangle = triangleValidityCondition1
                && triangleValidityCondition2
                && triangleValidityCondition3;

            if (isValidTriangle)
            {
                Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }

            bool rightTriangleCondition1 = a * a + b * b == c * c;
            bool rightTriangleCondition2 = b * b + c * c == a * a;
            bool rightTriangleCondition3 = a * a + c * c == b * b;

            if (rightTriangleCondition1)
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if (rightTriangleCondition2)
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (rightTriangleCondition3)
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else if (isValidTriangle)
            {
                Console.WriteLine("Triangle has no right angles");
            }
        }
    }

}
