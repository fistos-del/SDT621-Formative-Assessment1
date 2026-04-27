using.collections.Generic;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Xml.Linq;
System.Linq;

namespace EmfuleniManicpality
{
    class program
    {
        // Collection to store data
        static List<Residents> residents = new List<string>();
        static List<ServiceRequest> serviceRequests = new List<string>();
        static List<ServiceRequest> processedRequests = new List<string>();
        static UtilitiesManager utilitiesManager = new UtilitiesManager();

        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("     EMFULENI MUNICIPALITY SERVICE MANAGER        ");
            Console.WriteLine("==================================================\n");

            // Step 1: Capture residents
            CaptureResidents();

            // Step 2: Capture service requests
            CaptureServiceRequests();

            // Step 3: Process requests and display queue
            manager.DisplayQueue(serviceRequests);

            // Step 4&5: Interactive Processing
            ProcessRequests();

            // Step 6: Display final summary
            manager.DisplaySummary(processedRequests);

            Console.WriteLine("Press any key to exit...");
            Console.WriteLine();
        }

        static void CaptureResidents()
        {
            Console.WriteLine("Enter the number of residents to register: ");
            int residentsCount;
            while (!int.TryParse(Console.ReadLine(), out residentsCount) || residentsCount <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the number of residents: ");
            }

            for (int i = 0; i < residentsCount; i++)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine($"     RESIDENT {i + 1} REGISTRATION     ");
                Console.WriteLine("==================================================\n");
                Console.WriteLine("Enter resident's full name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Address: ");
                string address = Console.ReadLine();

                Console.Write("Enter Account Number: ");
                string accountNumber = Console.ReadLine();
                Console.WriteLine(EnterpriseServicesInteropOption Monthly Utilyty Usage(kWh): ");
                double usage;
                while (!double.TryParse(Console.ReadLine(), out usage) || usage < 0)
                {
                    Console.Write("Invalid input! Enter a valid usage amount: ");
                }

                residents.Add(new Residents(name, address, account, usage));
                Console.WriteLine($"\nResident '{name}' registered successfully!\n");
            }
        }

        static void CaptoureServiceRequests()
        {
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("     SERVICE REQUEST REGISTRATION    ");
            Console.WriteLine("==================================================\n");

            Console.Write("Enter the number of service requests to register: ");
            int requestsCount;
            while (!int.TryParse(Console.ReadLine(), out requestsCount) || requestsCount <= 0)
            {
                Console.Write("Invalid input. Please enter a positive integer for the number of service requests: ");
            }

            for (int i = 0; i < requestsCount; i++)
            {
                Console.Clear();
                Console.WriteLine("==================================================")
                Console.WriteLine($"         SERVICE REQUEST {i + 1} OF {requestCount}        ");
                Console.WriteLine(("==================================================");

                // Select associated resident
                Console.WriteLine("Select the associated resident:");
                for (int j = 0; j < residents.Count; j++)
                {
                    Console.WriteLine($"  {j + 1}. {residents[j].Name} (Acc: {residents[j].AccountNumber})");
                }

                Console.WriteLine("Enter resident number: ");
                int residentIndex;
                while (!int.TryParse(Console.ReadLine(), out residentIndex) || residentIndex < 1 || residentIndex > residents.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a valid resident number: ");
                }

                Console.Write("Enter request type (e.g., 'Water Leak', 'Power Outage', 'Billing Issue'): ");
                string requestType = Console.ReadLine();

                // Validate priority (1-5)
                Console.WriteLine("Enter priority level (1-5, where 1 is lowest and 5 is highest): ");
                int priority;
                while (!int.TryParse(Console.ReadLine(), out priority) || priority < 1 || priority > 5)
                {
                    Console.Write("Invalid! Enter priority between 1 and 5: ");
                }
            }
        }