using Systme;

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
                Console.WriteLine("" =================================== ");
                Console.WriteLine(""           SIMPLE ATM              ");
                Console.WriteLine("===================================");
                Console.WriteLine("Current Balance: R{balance:F2}");
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





