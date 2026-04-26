using System;

namespace StudentMarks
{ 
 class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            Console.WriteLine("       STUDENT MARK CALCULATOR      ");
            Console.WriteLine("====================================");

            // Step 1: Gte student name
            Console.WriteLine("Enter the name of the student: ");
            string studentName = Console.ReadLine();

            // Step 2: Declare variables
            int marks1, marks2, marks3;
            string input;
            bool isvalid;

        // Step 3: Gte variables Mark 1
        do
        {
            Console.WriteLine("Enter marks for subject 1: ");
            input = Console.ReadLine();
            isvalid = int.TryParse(input, out marks1);
            if (!isvalid)
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        } while (!isvalid);

        // Step 4: Gte variables Mark 2
        do
        {
            Console.WriteLine("Enter marks for subject 2: ");
            input = Console.ReadLine();
            isvalid = int.TryParse(input, out marks2);
            if (!isvalid)
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        } while (!isvalid);
    
        // Step 5: Get variables Mark 3
        do
        {
            Console.WriteLine("Enter marks for subject 3: ");
            input = Console.ReadLine();
            isvalid = int.TryParse(input, out marks3);
            if (!isvalid)
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        } while (!isvalid) ;

        // Step 6: Calculate total marks
        int totalMarks = marks1 + marks2 + marks3;
        double averageMarks = totalMarks / 3.0;

        // Step 7: Determine PASS or FAIL
        string result = (averageMarks >= 50) ? "PASS" : "FAIL";

        // Step 8: Display results
        Console.WriteLine("====================================");
        Console.WriteLine("           STUDENT RESULT           ");
        Console.WriteLine("====================================");
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Mark 1: {marks1}");
        Console.WriteLine($"Mark 2: {marks2}");
        Console.WriteLine($"Mark 3: {marks3}");
        Console.WriteLine("====================================");
        Console.WriteLine($"Total Marks: {totalMarks}");
        Console.WriteLine($"Average Marks: {averageMarks:F2}%");
        Console.WriteLine($"Result: {result}");
        Console.WriteLine("====================================");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
      }
   }
}