using System;
using System.Security.Cryptography.X509Certificates;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CName A = new CName();
            CName B = new CName();
            CName c = A + B;
            Console.WriteLine(A.a + " " + A.b);
            Console.WriteLine(B.a + " " + B.b);
            Console.WriteLine(c.a + " " + c.b);


            // BankAccount obj = new BankAccount("Ashraful", 22334455, "student");
            // // obj.account_details();

            // obj.addBalance(5000);
            // // obj.checkBalance();
            // obj.withdraw(5000);
            // obj.transfer("Jubayer", 2000);


        }
    }
}
// Operator Overloading 
class CName
{
    public int a = 5;
    public int b = 4;
    public static CName operator +(CName A, CName B)
    {
        CName c = new CName();
        c.a = A.a + B.a;
        c.b = B.b + A.b;
        return c;
    }
}
class BankAccount
{

    public string? user__name;
    public int account_number;
    public decimal balance;
    public string? account_type;


    public BankAccount(string name, int account_number, string account_type)
    {
        this.user__name = name;
        this.account_number = account_number;
        this.account_type = account_type;
    }
    public void addBalance(decimal bal)
    {
        balance += bal;
        Console.WriteLine("Add Balance Successfully");
    }
    public void withdraw(decimal bal)
    {
        decimal tmp = balance - bal;
        if (tmp < 500)
        {
            Console.WriteLine("You must have to minimum 500 taka into your account");
        }
        else if (bal > balance)
        {
            Console.WriteLine($"Insufficient  Balance");
        }
        else
        {
            balance -= bal;
            Console.WriteLine($"Withdraw = {bal}");

        }

    }
    public void account_details()
    {
        Console.WriteLine($"User Name = {user__name}");
        Console.WriteLine($"Account Number = {account_number}");
        Console.WriteLine($"Account Type = {account_type}");
        Console.WriteLine($"Current Balance = {balance}");
        Console.WriteLine("");
    }
    public void checkBalance()
    {
        Console.WriteLine($"Current Balance = {balance}");
    }
    public void transfer(string name, decimal bal)
    {
        if (balance >= 500)
        {
            balance -= bal;
            Console.WriteLine($"Transfer Successfully to {name}, balance {bal}");
        }
        else
        {

            Console.WriteLine($"Insufficient  Balance");
        }
    }
}
