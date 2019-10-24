using System;

namespace cale
{
    class Program
    {
        static void Main(string[] args)
        {
            cale cale = new cale();
            int s1 = cale.Add(3, 5);
            int s2 = cale.sub(7, 2);
            Console.WriteLine("3+5=" + s1);
            Console.WriteLine("7-2=" + s2);
            Console.ReadKey();
        }
    }
}
