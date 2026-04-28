using System;
using System.Linq;

namespace HomeAffairsDigitalIdentityProcessor
{
    public class CitizenProfile
    {
        // Properties with private setters (encapsulation)
        public string FullName { get; private set; }
        public string IDNumber { get; private set; }
        public int Age { get; private set; }
        public string CitizenshipStatus { get; private set; }

        // Constructor
        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge(idNumber);
        }

        /// <summary>
        /// Calculates age from the first 6 digits of the ID number (YYMMDD)
        /// </summary>
        private int CalculateAge(string idNumber)
        {
            // Check if we can extract a valid date
            if (idNumber.Length != 13 || !idNumber.All(char.IsDigit))
                return 0;

            try
            {