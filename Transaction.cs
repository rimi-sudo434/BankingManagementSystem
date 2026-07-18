using System;

public class Transaction
{
    public DateTime Date { get; set; }
    public string Type { get; set; }
    public decimal Amount { get; set; }

    public Transaction(string type, decimal amount)
    {
        Date = DateTime.Now;
        Type = type;
        Amount = amount;
    }

    public void ShowTransaction()
    {
        Console.WriteLine($"{Date:G} | {Type} | ₹{Amount}");
    }
}
