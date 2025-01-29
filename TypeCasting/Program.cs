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

            // int first = 2;
            // string second = "4";
            // string result = first + second;
            // Console.WriteLine(result);

            // int myInt = 3;
            // Console.WriteLine($"int: {myInt}");

            // decimal myDecimal = myInt;
            // Console.WriteLine($"decimal: {myDecimal}");
            // decimal myDecimals = 3.14m;
            // Console.WriteLine($"decimal : {myDecimals}");
            // int myInts = (int)myDecimals;
            // Console.WriteLine($"int : {myInts}");

            // int firsts = 5;
            // int seconds = 9;
            // string message = firsts.ToString() + seconds.ToString();
            // Console.WriteLine(message);
            // string first = "5";
            // string second = "7";
            // int result = int.Parse(first) + int.Parse(second);
            // Console.WriteLine(result);

            // string value1 = "5";
            // string value2 = "7";
            // int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            // int num = 0, num2 = 0;
            // int.TryParse(value1, out num);
            // int.TryParse(value2, out num2);
            // int result = num + num2;
            // Console.WriteLine(result);

            // int value = (int)1.5m;
            // Console.WriteLine(value);
            // int value2 = Convert.ToInt32(1.5m);
            // Console.WriteLine(value2);

            // string name = "Bob";
            // Console.WriteLine(int.Parse(name));
            // string value = "102";
            // int result = 0;
            // if (int.TryParse(value, out result))
            // {
            //     Console.WriteLine($"MeasureMent : {result}");
            // }
            // else
            // {
            //     Console.WriteLine("Unable to report the measurement.");
            // }

            // string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            // string message = "";
            // decimal sum = 0;
            // decimal num = 0;
            // foreach (string value in values)
            // {
            //     if (decimal.TryParse(value, out num))
            //     {
            //         sum += num;
            //     }
            //     else
            //     {
            //         message += value;
            //     }
            // }
            // Console.WriteLine(message);
            // Console.WriteLine(sum);


            // int value1 = 11;
            // decimal value2 = 6.2m;
            // float value3 = 4.3f;
            // int result1 = Convert.ToInt32(value1 / value2);
            // // Hint: You need to round the result to nearest integer (don't just truncate)

            // Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // decimal result2 = value2 / (decimal)value3;
            // Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // float result3 = value3 / value1;
            // // Your code here to set result3
            // Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


            // string value = "4.123456789";
            // decimal result = (decimal)value;
            // Console.WriteLine(result);

            // string[] pallets = ["B14", "A11", "B12", "A13"];
            // Console.WriteLine("Sorted...");
            // Array.Sort(pallets);
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Console.WriteLine("Reverse...");
            // Array.Reverse(pallets);
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Console.WriteLine($"Before : {pallets[0].ToLower()}");
            // Array.Clear(pallets, 0, 2);
            // if (pallets[0] != null)
            // {
            //     Console.WriteLine($"After : {pallets[0].ToLower()}");
            // }
            // Console.WriteLine($"Clearing 2 ... Count : {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Array.Resize(ref pallets, 6);
            // Console.WriteLine($"Resizing 6 ... Count: {pallets.Length}");
            // pallets[4] = "C01";
            // pallets[5] = "C02";

            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Array.Resize(ref pallets, 3);
            // Console.WriteLine($"Resizing 3 ... count : {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // string value = "abcd1234";
            // char[] valueArray = value.ToCharArray();
            // Array.Reverse(valueArray);
            // // string result = new string(valueArray);
            // string result = String.Join(",", valueArray);
            // string[] items = result.Split(',');
            // foreach(string item in items){
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine(result);


            // string pangram = "The quick brown fox jumps over the lazy dog";
            // string[] items = pangram.Split(" ");

            // string result = "";
            // foreach (string item in items)
            // {
            //     char[] valueArray = item.ToCharArray();
            //     Array.Reverse(valueArray);
            //     result += String.Join("", valueArray);
            //     result += " ";
            // }
            // Console.WriteLine(result);

            // string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            // string[] items = orderStream.Split(',');
            // Array.Sort(items);
            // foreach (string item in items)
            // {
            //     if (item.Length != 4)
            //     {
            //         Console.WriteLine(item + " - Error");
            //     }
            //     else
            //     {
            //         Console.WriteLine(item);
            //     }
            // }

            // string first = "Hello";
            // string second = "World";
            // String Formatting
            // string result = String.Format("{0} {1}!", first, second);
            // string result = String.Format("{0} {0} {0} {0}!", first, second);
            // string result = String.Format("{1} {1} {0} {0}!", first, second);
            // string Interpolation
            // Console.WriteLine($"{first} {second}!");
            // Console.WriteLine($"{second}! {first}");
            // Console.WriteLine(result);

            // decimal price = 123.45m;
            // int discount = 50;
            // Console.WriteLine($"Price : {price:C} (Save {discount:C})");

            // decimal measurement = 3123456.78912m;
            // Console.WriteLine($"Measurement: {measurement:N4} units");
            // decimal tax = .36785m;
            // Console.WriteLine($"Tax rate: {tax:P2}");
            // decimal price = 67.55m;
            // decimal salePrice = 59.99m;
            // string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);
            // yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";
            // Console.WriteLine(yourDiscount);

            // int invoiceNumber = 1201;
            // decimal productShares = 25.4568m;
            // decimal subtotal = 2750.00m;
            // decimal taxPercentage = .15825m;
            // decimal total = 3185.19m;

            // Console.WriteLine($"Invoice Number: {invoiceNumber}");
            // Console.WriteLine($" Shares : {productShares:N3} Product");
            // Console.WriteLine($"  Sub Total: {subtotal:C}");
            // Console.WriteLine($"    Tax: {taxPercentage:P2}");
            // Console.WriteLine($"   Total Billed: {total:C}");

            // string input = "Pad this";
            // Console.WriteLine(input.PadLeft(12, '-'));
            // Console.WriteLine(input.PadRight(12, '-'));

            // string paymentId = "769C";
            // string payeename = "Mr. Stephen Ortega";
            // string paymentAmount = "$5,000.00";

            // var formattedLine = paymentId.PadRight(6);
            // formattedLine += payeename.PadRight(24);
            // formattedLine += paymentAmount.PadRight(10);

            // Console.WriteLine(formattedLine);
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;


            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P2}", currentReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P2}", newReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine(comparisonMessage);
        }
    }
}