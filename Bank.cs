using System;
using System.Collections.Generic;

public class Bank
{
    private Account? account;
    private List<Transaction> transactions = new List<Transaction>();

    public void CreateAccount()
    {
        Console.Write("Enter Account Number: ");
        string accountNumber = Console.ReadLine()!;

        Console.Write("Enter Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter Initial Balance: ");
        decimal balance = Convert.ToDecimal(Console.ReadLine());

        account = new Account(accountNumber, name, balance);
        Console.WriteLine("\nAccount created successfully!");
    }

    public void Deposit()
    {
        if (account == null)
        {
            Console.WriteLine("No account found.");
            return;
        }

        Console.Write("Enter amount to deposit: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        account.Deposit(amount);
        transactions.Add(new Transaction("Deposit", amount));
    }

    public void Withdraw()
    {
        if (account == null)
        {
            Console.WriteLine("No account found.");
            return;
        }

        Console.Write("Enter amount to withdraw: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        account.Withdraw(amount);
        transactions.Add(new Transaction("Withdraw", amount));
    }

    public void ShowAccount()
    {
        if (account == null)
        {
            Console.WriteLine("No account found.");
            return;
        }

        account.ShowDetails();
    }

    public void ShowTransactions()
    {
        if (transactions.Count == 0)
        {
            Console.WriteLine("No transactions available.");
            return;
        }

        Console.WriteLine("\n----- Transaction History -----");
        foreach (var t in transactions)
        {
            t.ShowTransaction();
        }
    }
}
