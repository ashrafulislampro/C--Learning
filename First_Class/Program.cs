using System;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Animal obj = new Animal();
            // obj.age = 20;
            // obj.name = "Ashraful";
            // obj.color = "brown";

            // Console.WriteLine($"{obj.name} {obj.age} {obj.color}");
            obj.printDetails();

        }


    }


}

class Animal
{
    private string? name = "Cat";
    private int age = 10;
    private string? color = "Black";
    public Animal()
    {
        Console.WriteLine("This is a Constructor");
    }
    public void printDetails()
    {
        Console.WriteLine($"{name} {age} {color}");
    }
}
