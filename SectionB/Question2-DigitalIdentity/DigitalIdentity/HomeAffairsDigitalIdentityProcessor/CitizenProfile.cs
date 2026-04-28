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
                // Extract date components: YYMMDD
                string yearPart = idNumber.Substring(0, 2);
                string monthPart = idNumber.Substring(2, 2);
                string dayPart = idNumber.Substring(4, 2);

                int yearShort = int.Parse(yearPart);
                int month = int.Parse(monthPart);
                int day = int.Parse(dayPart);

                // Determine the century
                // If the 2-digit year is > current year's last 2 digits → 1900s
                // If the 2-digit year is ≤ current year's last 2 digits → 2000s
                int currentYear = DateTime.Now.Year;
                int currentYearShort = currentYear % 100;

                int century;
                if (yearShort > currentYearShort)
                    century = 1900;  // e.g., 85 → 1985
                else
                    century = 2000;  // e.g., 02 → 2002

                int fullYear = century + yearShort;

                // Create birth date
                DateTime birthDate = new DateTime(fullYear, month, day);

                // Calculate age
                int age = currentYear - birthDate.Year;

                // Adjust if birthday hasn't occurred this year yet
                if (DateTime.Now < birthDate.AddYears(age))
                    age--;

                return age;
            }
            catch
            {
                return 0; // Invalid date
            }
        }

        /// <summary>
        /// Validates the ID number according to the requirements
        /// </summary>
        public string ValidatedID()
        {
            // Check 1: Must be exactly 13 digits
            if (IDNumber.Length != 13)
                return "INVALID: ID number must be exactly 13 digits.";

            // Check 2: Must be fully numeric
            if (!IDNumber.All(char.IsDigit))
                return "INVALID: ID number must contain only numeric digits.";

            // Check 3: Validate month (digits 3-4, range 01-12)
            int month = int.Parse(IDNumber.Substring(2, 2));
            if (month < 1 || month > 12)
                return "INVALID: Month in ID number is out of range (01-12).";

            // Check 4: Validate day (digits 5-6, range 01-31)
            int day = int.Parse(IDNumber.Substring(4, 2));
            if (day < 1 || day > 31)
                return "INVALID: Day in ID number is out of range (01-31).";

            // Check 5: Validate age is reasonable
            if (Age < 0 || Age > 150)
                return "INVALID: Calculated age is out of valid range.";

            return "VALID: ID number successfully validated.";
        }
    }
}