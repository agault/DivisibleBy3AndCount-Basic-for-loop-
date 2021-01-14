using System;

namespace DivisibleBy3AndCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0) // this solution implies 3/0.
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} numbers % by 3 between 1-100.....assumption being % by 0 counts as one",count);
        }
    }
}
