using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Cale cale = new Cale();
            
            Console.WriteLine($"3+5={cale.Add(3,5)}");
            Console.WriteLine($"3-5={cale.Sub(3,5)}");
            Console.WriteLine($"3*5={cale.Mul(3,5)}");
            Console.WriteLine($"3/5={cale.Div(3,5)}");
            Console.ReadKey();
        }
    }
}
