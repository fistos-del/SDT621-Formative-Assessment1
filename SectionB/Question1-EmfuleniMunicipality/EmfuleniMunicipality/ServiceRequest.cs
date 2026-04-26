using System;


namespace EmfuleniMunicipality
{
    public class ServiceRequest
    {
        // Properites (Attributes)
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }
        public int SeverityLevel { get; set; }
        public double EstimatedResolutinHours { get; set; }
        public Resident AssociatedResident { get; set; }
        public double UrgencyScore { get; set; }
        public bool Isprocessed { get; set; }

        // Constructor
        public ServiceRequest(string requestType, int priority, int severity, double resolutionHours, Resident resident)
        {
            RequestType = requestType;
            PriorityLevel = priority;
            SeverityLevel = severity;
            EstimatedResolutinHours = resolutionHours;
            AssociatedResident = resident;
            UrgencyScore = 0;
            Isprocessed = false;
        }

        // Method to get equest details
        public string GetRequestDetails()
        {
            return $"Request Type: {RequestType}, Priority Level: {PriorityLevel}, Severity Level: {SeverityLevel}, Estimated Resolution Hours: {EstimatedResolutinHours}, Urgency Score: {UrgencyScore}, Is Processed: {Isprocessed}";
        }
}
}
