using System;


namespace EmfuleniMunicipality
{
    public class Resident
    {
        // Porperties
        public string Name { get; set; }
        public string Address { get; set; }
        public string AccountNumber { get; set; }
        public Double MonthlyUtilityUsage { get; set; }

        // Constructor
        public Resident(string name, string address, string accountNumber, double monthlyUtilityUsage)
        {
            Name = name;
            Address = address;
            AccountNumber = accountNumber;
            MonthlyUtilityUsage = monthlyUtilityUsage;
        }

        // Method to get resident details as a formatted string
        public string GetResidentDetails()
        {
            return $"Name: {Name}, Address: {Address}, Account Number: {AccountNumber}, Monthly Utility Usage: {MonthlyUtilityUsage} kWh";
        }
    }
}




