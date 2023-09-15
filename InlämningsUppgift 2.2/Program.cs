using System;

namespace uppgift_2._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin?");
            double längd1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma");
            double längd2 = double.Parse(Console.ReadLine());

            double diff = längd1 - längd2;
            Console.WriteLine("Elin hoppade "+diff+" meter längre än Alma");
            Console.Read();
        }
    }
}