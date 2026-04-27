using System;
using.collections.Generic;
using System.Text.RegularExpressions;
using System.Diagnostics;
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


    }
}