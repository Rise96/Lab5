using System;
using System.Collections.Generic;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { -12, -3, -4, 5, 3, 4, 5, -12, -4, -5, 6, 5, 4 };
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
            Inserter inserter = new Inserter();
            List<int> resultArray = inserter.Insert(array);
            foreach(int element in resultArray)
            {
                Console.Write($"{element} ");
            }
            Console.Read();
        }
    }
}
