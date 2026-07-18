using System;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();
        int choice;

        do
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================================");
            Console.WriteLine("   BANKING MANAGEMENT SYSTEM");
            Console.WriteLine("=================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. View Account");
            Console.WriteLine("5. Transaction History");
            Console.WriteLine("6. Exit");
            Console.ResetColor();

            Console.Write("\nEnter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n❌ Invalid input!");
                Console.ResetColor();

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                continue;
            }

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    bank.CreateAccount();
                    break;

                case 2:
                    bank.Deposit();
                    break;

                case 3:
                    bank.Withdraw();
                    break;

                case 4:
                    bank.ShowAccount();
                    break;

                case 5:
                    bank.ShowTransactions();
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thank you for using the Banking Management System!");
                    Console.ResetColor();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ Invalid choice!");
                    Console.ResetColor();
                    break;
            }

            if (choice != 6)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

        } while (choice != 6);
    }
}
