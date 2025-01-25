using System;
namespace App
{
    class Progress
    {
        public static void Main()
        {
            int marks = 85;
            if (marks >= 80)
            {
                Console.WriteLine("A+");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("A-");
            }
        }
    }
}
