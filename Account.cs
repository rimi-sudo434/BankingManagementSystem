using System;

public class Account
{
    public string AccountNumber { get; set; }
    public string Name { get; set; }
    public decimal Balance { get; private set; }

    public Account(string accountNumber, string name, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Name = name;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"✅ ₹{amount} deposited successfully.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Invalid amount.");
            Console.ResetColor();
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Invalid amount.");
            Console.ResetColor();
        }
        else if (amount > Balance)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Insufficient balance.");
            Console.ResetColor();
        }
        else
        {
            Balance -= amount;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"✅ ₹{amount} withdrawn successfully.");
            Console.ResetColor();
        }
    }

    public void ShowDetails()
    {
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine("\n========== ACCOUNT DETAILS ==========");
        Console.WriteLine($"Account Number : {AccountNumber}");
        Console.WriteLine($"Name           : {Name}");
        Console.WriteLine($"Balance        : ₹{Balance}");
        Console.WriteLine("=====================================");

        Console.ResetColor();
    }
}
