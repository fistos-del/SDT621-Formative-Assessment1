using System;
using System.Collections.Generic;
using System.Linq;

namespace EmfuleniMunicipality
{
    public class UtilitiesManager
    {
        // Calculate urgency score for a request
        public double CalculateUrgencyScore(ServiceRequest request)
        {
            // Formula: (Priority × Severity) / Estimated Resolution Hours
            if (request.EstimatedResolutionHours <= 0)
                return request.PriorityLevel * request.SeverityLevel;

            return (request.PriorityLevel * request.SeverityLevel) / request.EstimatedResolutionHours;
        }

        // Display the queue of pending requests
        public void DisplayQueue(List<ServiceRequest> requests)
        {
            Console.WriteLine("\n==================================================");
            Console.WriteLine("          PENDING SERVICE REQUESTS QUEUE          ");
            Console.WriteLine("==================================================");
            Console.WriteLine("| #  | Request Type         | Urgency Score |");
            Console.WriteLine("--------------------------------------------------");

            int displayNumber = 1;
            for (int i = 0; i < requests.Count; i++)
            {
                if (!requests[i].IsProcessed)
                {
                    double urgency = CalculateUrgencyScore(requests[i]);
                    requests[i].UrgencyScore = urgency;
                    Console.WriteLine($"| {displayNumber,-2} | {requests[i].RequestType,-20} | {urgency,13:F2} |");
                    displayNumber++;
                }
            }
            Console.WriteLine("==================================================\n");
        }

        // Generate a processing report for a specific request
        public string GenerateProcessingReport(ServiceRequest request, double urgencyScore)
        {
            string report = "\n==================================================\n";
            report += "           SERVICE REQUEST PROCESSING REPORT        \n";
            report += "==================================================\n";
            report += "RESIDENT DETAILS:\n";
            report += $"  {request.AssociatedResident.GetResidentDetails()}\n";
            report += "--------------------------------------------------\n";
            report += "REQUEST DETAILS:\n";
            report += $"  {request.GetRequestDetails()}\n";
            report += $"  Urgency Score: {urgencyScore:F2}\n";
            report += $"  Status: PROCESSED\n";
            report += "==================================================\n";
            return report;
        }

        // Display final summary of all processed requests
        public void DisplaySummary(List<ServiceRequest> processedRequests)
        {
            Console.WriteLine("\n==================================================");
            Console.WriteLine("               FINAL SUMMARY REPORT                ");
            Console.WriteLine("==================================================");
            Console.WriteLine($"Total Requests Processed: {processedRequests.Count}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Resolved Requests:");

            foreach (var request in processedRequests)
            {
                Console.WriteLine($"  - {request.RequestType} (Resident: {request.AssociatedResident.Name}, Urgency: {request.UrgencyScore:F2})");
            }

            // Find the request with highest urgency score
            if (processedRequests.Count > 0)
            {
                var highestUrgency = processedRequests.OrderByDescending(r => r.UrgencyScore).First();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("HIGHEST URGENCY REQUEST:");
                Console.WriteLine($"  Type: {highestUrgency.RequestType}");
                Console.WriteLine($"  Resident: {highestUrgency.AssociatedResident.Name}");
                Console.WriteLine($"  Urgency Score: {highestUrgency.UrgencyScore:F2}");
            }
            Console.WriteLine("==================================================\n");
        }
    }
}






