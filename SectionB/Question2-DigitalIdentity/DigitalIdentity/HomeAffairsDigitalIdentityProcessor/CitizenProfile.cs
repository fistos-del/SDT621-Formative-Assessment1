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