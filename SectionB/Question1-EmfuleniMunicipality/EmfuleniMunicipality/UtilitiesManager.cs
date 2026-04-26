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
        }
}
