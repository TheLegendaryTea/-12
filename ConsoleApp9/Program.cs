using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
                try
            {
                Console.WriteLine("введите целые положительные числа (a>b)");
                Console.WriteLine("введите а:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("введите b:");
                int b = int.Parse(Console.ReadLine());
                int B = a / b;
                Console.WriteLine("B:{0}",B);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            
        }
    


        }
    }
}
