using System;
using System.Collections.Generic;
using System.Linq;

namespace EmfuleniMunicipality
{
    class Program
    {
        // Collections to store data
        static List<Resident> residents = new List<Resident>();
        static List<ServiceRequest> serviceRequests = new List<ServiceRequest>();
        static List<ServiceRequest> processedRequests = new List<ServiceRequest>();
        static UtilitiesManager manager = new UtilitiesManager();

        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("     EMFULENI MUNICIPALITY SERVICE MANAGER        ");
            Console.WriteLine("==================================================\n");

            // STEP 1: Capture Residents
            CaptureResidents();

            // STEP 2: Capture Service Requests
            CaptureServiceRequests();

            // STEP 3: Display Queue with Urgency Scores
            manager.DisplayQueue(serviceRequests);

            // STEP 4 & 5: Interactive Processing
            ProcessRequests();

            // STEP 6: Final Summary
            manager.DisplaySummary(processedRequests);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void CaptureResidents()
        {
            Console.Write("Enter the number of residents to register: ");
            int residentCount;
            while (!int.TryParse(Console.ReadLine(), out residentCount) || residentCount <= 0)
            {
                Console.Write("Invalid input! Enter a positive number: ");
            }

            for (int i = 0; i < residentCount; i++)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine($"           RESIDENT {i + 1} REGISTRATION           ");
                Console.WriteLine("==================================================");

                Console.Write("Enter Full Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Address: ");
                string address = Console.ReadLine();

                Console.Write("Enter Account Number: ");
                string account = Console.ReadLine();

                Console.Write("Enter Monthly Utility Usage (kWh): ");
                double usage;
                while (!double.TryParse(Console.ReadLine(), out usage) || usage < 0)
                {
                    Console.Write("Invalid input! Enter a valid usage amount: ");
                }

                residents.Add(new Resident(name, address, account, usage));
                Console.WriteLine($"\nResident '{name}' registered successfully!\n");
            }
        }

        static void CaptureServiceRequests()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("          SERVICE REQUEST REGISTRATION            ");
            Console.WriteLine("==================================================");

            Console.Write("Enter the number of service requests: ");
            int requestCount;
            while (!int.TryParse(Console.ReadLine(), out requestCount) || requestCount <= 0)
            {
                Console.Write("Invalid input! Enter a positive number: ");
            }

            for (int i = 0; i < requestCount; i++)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine($"         SERVICE REQUEST {i + 1} OF {requestCount}        ");
                Console.WriteLine("==================================================");

                // Select associated resident
                Console.WriteLine("Select Associated Resident:");
                for (int j = 0; j < residents.Count; j++)
                {
                    Console.WriteLine($"  {j + 1}. {residents[j].Name} (Acc: {residents[j].AccountNumber})");
                }

                Console.Write("Enter resident number: ");
                int residentIndex;
                while (!int.TryParse(Console.ReadLine(), out residentIndex) || residentIndex < 1 || residentIndex > residents.Count)
                {
                    Console.Write($"Invalid! Enter a number between 1 and {residents.Count}: ");
                }

                Console.Write("Enter Request Type (e.g., Water Leak, Power Outage): ");
                string requestType = Console.ReadLine();

                // Validate priority (1-5)
                Console.Write("Enter Priority Level (1 = Lowest, 5 = Highest): ");
                int priority;
                while (!int.TryParse(Console.ReadLine(), out priority) || priority < 1 || priority > 5)
                {
                    Console.Write("Invalid! Enter priority between 1 and 5: ");
                }

                // Validate severity (1-10)
                Console.Write("Enter Severity Level (1 = Minor, 10 = Critical): ");
                int severity;
                while (!int.TryParse(Console.ReadLine(), out severity) || severity < 1 || severity > 10)
                {
                    Console.Write("Invalid! Enter severity between 1 and 10: ");
                }

                Console.Write("Enter Estimated Resolution Hours: ");
                double hours;
                while (!double.TryParse(Console.ReadLine(), out hours) || hours < 0)
                {
                    Console.Write("Invalid! Enter valid hours: ");
                }

                serviceRequests.Add(new ServiceRequest(requestType, priority, severity, hours, residents[residentIndex - 1]));
                Console.WriteLine($"\nService request '{requestType}' registered!\n");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void ProcessRequests()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("           INTERACTIVE REQUEST PROCESSING          ");
            Console.WriteLine("==================================================");

            while (serviceRequests.Any(r => !r.Isprocessed))
            {
                manager.DisplayQueue(serviceRequests);

                Console.Write("Enter request number to process (or 0 to finish): ");
                int selection;

                if (!int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Invalid input! Try again.");
                    continue;
                }

                if (selection == 0)
                    break;

                // Find the unprocessed request at the selected position
                int unprocessedIndex = -1;
                int count = 0;
                for (int i = 0; i < serviceRequests.Count; i++)
                {
                    if (!serviceRequests[i].Isprocessed)
                    {
                        count++;
                        if (count == selection)
                        {
                            unprocessedIndex = i;
                            break;
                        }
                    }
                }

                if (unprocessedIndex == -1)
                {
                    Console.WriteLine("Invalid selection! Please try again.");
                    continue;
                }

                // Process the request
                var request = serviceRequests[unprocessedIndex];
                double urgency = manager.CalculateUrgencyScore(request);
                request.UrgencyScore = urgency;
                request.Isprocessed = true;
                processedRequests.Add(request);

                // Generate and display report
                Console.Clear();
                Console.WriteLine(manager.GenerateProcessingReport(request, urgency));

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}



