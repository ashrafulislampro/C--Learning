using System;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample obj1 = new Sample(10), obj2 = new Sample(10.234), obj3 = new Sample("abc"), obj4 = new Sample(20, 10.234), obj5 = new Sample(10, "abc"), obj6 = new Sample(10, 20.55, "abc");

            Console.WriteLine($"Obj 1 = {obj1.a}");
            Console.WriteLine($"Obj 2 = {obj2.b}");
            Console.WriteLine($"Obj 3 = {obj3.c}");
            Console.WriteLine($"Obj 4 = {obj4.a} {obj4.b}");
            Console.WriteLine($"Obj 5 = {obj5.a} {obj5.c}");
            Console.WriteLine($"Obj 6 = {obj6.a} {obj6.b} {obj6.c}");
        }
    }
}

class Sample
{
    public int a;
    public double b;
    public string? c;
    public Sample(int a)
    {
        this.a = a;
    }
    public Sample(double b)
    {
        this.b = b;
    }
    public Sample(string? c)
    {
        this.c = c;
    }
    public Sample(int a, double b)
    {
        this.a = a;
        this.b = b;
    }
    public Sample(int a, string? c)
    {
        this.a = a;
        this.c = c;
    }
    public Sample(int a, double b, string? c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
}
