using System;
namespace MyApp
{
    internal class Program
    {
        static void Main()
        {
            // Console.WriteLine("Signed integral types: ");
            // Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
            // Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
            // Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
            // Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

            // Console.WriteLine("");
            // Console.WriteLine("Unsigned integral types: ");
            // Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
            // Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            // Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
            // Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");

            // Console.WriteLine("");
            // Console.WriteLine("Floating point types");
            // Console.WriteLine($"Float : {float.MinValue} to {float.MaxValue}(with ~6-9 digits of precision)");
            // Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            // Console.WriteLine($"decimal : {double.MinValue} to {double.MaxValue} (with ~28-29 digits of precision)");

            // reference of data types;
            // int[] data = new int[3];
            // foreach (int dl in data)
            // {
            //     Console.WriteLine(dl);
            // }

            // integer value types
            // int val_a = 2;
            // int val_b = val_a;
            // val_b = 5;
            // Console.WriteLine($"--value types--");
            // Console.WriteLine($"Val_A : {val_a}");
            // Console.WriteLine($"Val_B : {val_b}");

            // referece type
            // int[] ref_a = new int[1];
            // ref_a[0] = 2;
            // int[] ref_b = ref_a;
            // ref_b[0] = 5;

            // Console.WriteLine("--Reference Types--");
            // Console.WriteLine($"ref_A[0] : {ref_a[0]}");
            // Console.WriteLine($"ref_b[0] : {ref_b[0]}");

            int first = 2;
            string second = "4";
            int result = first + second;
            Console.WriteLine(result);
        }
    }
}