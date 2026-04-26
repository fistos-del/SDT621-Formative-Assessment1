using System;


namespace EmfuleniMunicipality
{
    public class Resident
    {
        // Porperties
        public string Name { get; set; }
        public string Address { get; set; }
        public string AccountNumer { get; set; }
        public Double MonthlyUtilityUsage { get; set; }

        // Constructor
        public Resident(string name, string address, string accountNumber, double monthlyUtilityUsage)
        {
            Name = name;
            Address = address;
            AccountNumer = accountNumber;
            MonthlyUtilityUsage = monthlyUtilityUsage;
        }






