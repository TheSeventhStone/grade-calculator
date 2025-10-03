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
            Console.WriteLine("Welcome, " + studentName+ "\nHere are your grades: ");
            foreach(int i in grades)
            {
                Console.WriteLine(i);
                if (i>=90)
                {
                    Console.WriteLine("This grade is an A!");
                    if (i == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if (i >= 80)
                {
                    Console.WriteLine("This grade is a B.");
                }
                else if (i >= 70)
                {
                    Console.WriteLine("This grade is a C.");
                }
                else if (i >= 65)
                {
                    Console.WriteLine("This grade is a D.");
                }
                else if (i >= 0)
                {
                    Console.WriteLine("This grade is a F.");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }
            }

        }
    }
}
