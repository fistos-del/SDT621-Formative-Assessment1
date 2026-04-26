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

        
    }
}
