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


