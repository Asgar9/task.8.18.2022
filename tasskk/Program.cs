using System;

namespace task18._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("texti daxil edin:");
            string str = Console.ReadLine();
            Console.WriteLine(ExtentionMethods.ToCapitalize(str));
            Console.WriteLine("Include the digit:");
            int digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ExtentionMethods.IsOdd(digit));
            Console.WriteLine("Include the digit:");
            int digit1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ExtentionMethods.IsEven(digit1));
            Console.WriteLine("texti daxil edin:");
            string strr = Console.ReadLine();
            Console.WriteLine(ExtentionMethods.IsContainsDigit(str));
           Console.WriteLine(ExtentionMethods.GetValueIndexes(arr,a));
            



        }

    }
}