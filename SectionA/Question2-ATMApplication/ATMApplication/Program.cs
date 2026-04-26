using System;
using static System.TimeZoneInfo;

namespace ATMApplication
{
    class Program
    {
        //Initail balance as a constat
        private static decimal balance = 5000.00m;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM Application!");
            while (true)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("           SIMPLE ATM              ");
                Console.WriteLine("===================================");
                Console.WriteLine($"Current Balance: R{balance:F2}");
                Console.WriteLine("===================================\n");

                // Step1: Get withdrawal amount
                Console.Write("Enter the amount to withdraw: R");
                string input = Console.ReadLine();
                decimal withdrawalAmount;

                // Step2: Validate the input
                while (!decimal.TryParse(input, out withdrawalAmount) || withdrawalAmount <= 0)
                {
                    Console.Write("Invalid input. Please enter a valid amount to withdraw: R");
                    input = Console.ReadLine();
                }

                // Step3: Check if the balance is sufficient
                if (withdrawalAmount > balance)
                {
                    Console.WriteLine("\n===================================");
                    Console.WriteLine("       INSUFFICIENT FUNDS!         ");
                    Console.WriteLine($"Your balance is only: R{balance:F2}");
                    Console.WriteLine("===================================");
                }
                else
                {
                    // Step4: Process the withdrawal
                    decimal previousBalance = balance;
                    balance -= withdrawalAmount;
                    DateTime transaction = DateTime.Now;

                    // Step5: Display the transaction details
                    Console.WriteLine("\n===================================");
                    Console.WriteLine("        TRANSACTION RECEIPT        ");
                    Console.WriteLine("===================================");
                    Console.WriteLine($"Date/Time:       {transaction:dd/MM/yyyy HH:mm:ss}");
                    Console.WriteLine($"Previous Balance: R{previousBalance:F2}");
                    Console.WriteLine($"Amount Withdrawn:  R{withdrawalAmount:F2}");
                    Console.WriteLine($"New Balance:      R{balance:F2}");
                    Console.WriteLine("===================================");
                    Console.WriteLine("Thank you for using the ATM Application!");
                    Console.WriteLine("===================================");
                }

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}



