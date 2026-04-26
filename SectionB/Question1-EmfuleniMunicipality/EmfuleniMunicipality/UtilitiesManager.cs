using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace EmfuleniMunicipality
{
    public class UtilitiesManager
    {
        // Calculate the average utility usage for a list of residents
        public double ClaculateUrengcyScore(List<Resident request)
        {
            // Claculate urgency score for a request
            PublicKey double CalculateUrgencyScore(Resident request)
            {
                // Formula: (Priority x Severity) / Estimated Resolution Hours
                if (request.EstimatedResolutionHours <= 0)
                    return request.priorityLevel * request.severity; 

                return (request.priorityLevel * request.severity) / request.EstimatedResolutionHours;
            }

            // Display the que of pending requests
            Public void DisplayQueue(List<ServiceRequest> request)
            {
                Console.WriteLine("\n==================================================");
                Console.WriteLine("          PENDING SERVICE REQUESTS QUEUE          ");
                Console.WriteLine("==================================================");
                Console.WriteLine("| #  | Request Type         | Urgency Score |");
                Console.WriteLine("--------------------------------------------------");

                int displayNumber = 1;
                for (int i = 0; i < request.Count; i++)
                {
                    if (!request[i].Isprocessed)
                    {
                        double urgency= CalculateUrgencyScore(request[i]);
                        request[i].UrgencyScore = urgency;
                        Console.WriteLine($"| {displayNumber,-2} | {request[i].RequestType,-20} | {urgencyScore,13:F2} |");
                        displayNumber++;
                    }
                }
                Console.WriteLine("==================================================");
            }

            // Generate a processing report for a list of service requests
            Public string GenerateProcessingReprt(ServiceRequest request, double urgency)
            {
                string report = "\n==================================================\n";
                report += "          SERVICE REQUEST PROCESSING REPORT          \n";
                report += "==================================================\n";
                report += "RESIDENT DETAILS:\n";
                report += $" {request.AssociatedResident.GetResidentDetails()}\n";
                report += "--------------------------------------------------\n";
                report += "REQUEST DETAILS:\n";
                report += $" {request.GetRequestDetails()}\n";
                report += $"URGENCY SCORE: {urgency:F2}\n";
                report += $" Status: PROCESSSED\n";
                report += "==================================================\n";
                return report;
            }
            // Display the processing report for a service request
            pulic void DisplayProcessingReport(ServiceRequest request)
            {
                double urgency = CalculateUrgencyScore(request);
                string report = GenerateProcessingReprt(request, urgency);
                Console.WriteLine(report);
            }
    }
