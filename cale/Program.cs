using System;

namespace cale
{
    class Program
    {
        static void Main(string[] args)
        {
            cale cale = new cale();
            
            Console.WriteLine($"3+5={Calc.Add(3,5)}");
            Console.WriteLine($"3+5={Calc.Sub(3,5)}");
            Console.WriteLine($"3+5={Calc.Mul(3,5)}");
            Console.WriteLine($"3+5={Calc.Div(3,5)}");
            Console.ReadKey();
        }
    }
}
