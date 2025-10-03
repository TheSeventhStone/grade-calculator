using System.Diagnostics;

namespace grade_calculator
{
    internal class Program
    {
        /*Name: Samuel LaMere
         Class: IGME 201
        Due Date: 10/12/2025*/
        static void Main(string[] args)
        {
            String studentName;
            studentName = "Samuel LaMere";
            int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            Console.WriteLine("Welcome, " + studentName + "\nHere are your grades: ");
            /*iterates through grade array. If grade in range, print letter counterpart.
             Otherwise, mark as out of bounds.*/
            foreach(int i in grades)
            {
                Console.WriteLine(i);
                if ((i>=90) && (i<101))
                {
                    Console.WriteLine("This grade is an A!");
                    //checks if grade is an 100 (max range). If so, mark as perfect score.
                    if (i == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if ((i >= 80) && (i < 90))
                {
                    Console.WriteLine("This grade is a B.");
                }
                else if ((i >= 70) && (i < 80))
                {
                    Console.WriteLine("This grade is a C.");
                }
                else if ((i >= 65) && (i < 70))
                {
                    Console.WriteLine("This grade is a D.");
                }
                else if ((i >= 0) && (i < 65))
                {
                    Console.WriteLine("This grade is a F.");
                }
                //Catch-all for grades out of bounds.
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }
            }
            //iterate through grades and add them to average container, then divide by grade array size.
            int average = 0;
            foreach(int j in  grades)
            {
                average += j;
            }
            average /= grades.Length;
            Console.WriteLine("Your final calculated average is: " + average + "\nWe have displayed all grades for " + studentName);
        }
    }
}
