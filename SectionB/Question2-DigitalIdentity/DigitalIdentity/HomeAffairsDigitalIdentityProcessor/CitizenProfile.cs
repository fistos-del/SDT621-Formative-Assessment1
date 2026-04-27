using System;
using.linq;

namespace HomeAffairsDigitalIdentityProcessor
{
    public class CitizenProfile
    {
        //Properties with private setters (encapsulation)
        public string FullName { get; private set; }
        public string IDNumber { get; private set; }
        public int Age { get; private set; }
        public string citizenshipStatus { get; private set; }

        //Constructor to initialize properties
        public CitizenProfile(string fullName, string idNumber, int age, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = Calculated(idNumber);
            
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

                int year = int.Parse(yearPart);
                int month = int.Parse(monthPart);
                int day = int.Parse(dayPart);

                // Determine the century
                // if the 2-digit year is greater than the current year's last two digits, it's likely from the 1900s
                // if the 2-digit year is less than or equal to the current year's last two digits, it's likely from the 2000s
                int currentYear = DateTime.Now.Year;
                int currentYearShort = currentYear % 100;

                int century;
                if (yearShort > currentYearShort)
                    century = 1900;
                else
                    century = 2000;

                int fullYear = century + year;

                // Creae birth date
                DateTime birthDate = new DateTime(fullYear, month, day);

                // Calculate age
                int age = currentYear - birthDate.Year;

                // Adjust age if the birthday hasn't occurred yet this year
                if (DateTime.Now < birthDate.AddYears(age))
                    age--;

                return age;
            }
            catch
            {
                return 0: //invalid date
            }
        }


        /// <summary>
        /// Validates the ID number according to the requirements
        /// </summary>
        public string ValidationID()
        {
            // Check 1: Must be exactly 13 digits
            if (IDNumber.Length != 13)
                return "Invalid ID: Must be exactly 13 digits.";

            // Check 2: Must contain only digits
            if (!IDNumber.All(char.IsDigit))
                return "Invalid ID: Must contain only digits.";

            // Check 3: Vali

        }
    }

    }
