using System;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Count_Digit obj = new Count_Digit(2241081055);

            obj.PrintDigit();


            Console.WriteLine("");


            
            // Creating customer objects
            Customer customer1 = new Customer("Alice", "C001", "0123456789", true, "1234-5678-9012-3456", 5000);
            Customer customer2 = new Customer("Bob", "C002", "0987654321", false, "9876-5432-1098-7654", 3000);

            // Displaying details
            customer1.PrintCustomerDetails();
            customer2.PrintCustomerDetails();
        }
    }
}

class Count_Digit
{
    public long id;
    public int count;
    public Count_Digit(long id)
    {
        this.id = id;
    }
    public void PrintDigit()
    {
        while (id != 0)
        {
            id /= 10;
            count++;
        }
        Console.WriteLine($"ID Total Digit = {count}");
    }

}

class Customer
{
    // Private fields for Encapsulation
    private string? name;
    private string? customerID;
    private string? contactNumber;
    private bool isMember;
    private string? creditCardInfo;
    private double totalExpense;

    // Constructor
    public Customer(string name, string customerID, string contactNumber, bool isMember, string creditCardInfo, double totalExpense)
    {
        this.name = name;
        this.customerID = customerID;
        this.contactNumber = contactNumber;
        this.isMember = isMember;
        this.creditCardInfo = creditCardInfo;
        this.totalExpense = totalExpense;
    }

    // Method to calculate discount
    public double GetDiscount()
    {
        return isMember ? 0.20 * totalExpense : 0.10 * totalExpense;
    }


    public void PrintCustomerDetails()
    {
        Console.WriteLine("Customer Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Customer ID: " + customerID);
        Console.WriteLine("Contact Number: " + contactNumber);
        Console.WriteLine("Membership Status: " + (isMember ? "Member" : "Non-Member"));
        Console.WriteLine("Total Expense: " + totalExpense);
        Console.WriteLine("Discount Received: " + GetDiscount());
        Console.WriteLine("Final Amount to Pay: " + (totalExpense - GetDiscount()));
        Console.WriteLine("----------------------------------");
    }
}
