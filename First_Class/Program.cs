using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f_val = 123.45f;
            decimal dec_val = Convert.ToDecimal(f_val);
            Console.WriteLine(f_val.GetType());
            Console.WriteLine(dec_val.GetType());
        }
    }
}