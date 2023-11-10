using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2_array_list_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1: ArrayList Initialization and Population
                ArrayList studentGrades = new ArrayList();
                studentGrades.AddRange(new int[] { 85, 92, 78, 95, 88 });

                // Display initial student grades
                Console.WriteLine("Task 1: Initial Student Grades:");
                DisplayArrayList(studentGrades);
                Console.WriteLine();

                // Task 2: Display and Sum
                Console.WriteLine("Task 2: Display and Sum");
                DisplayArrayList(studentGrades);
                int sum = CalculateSum(studentGrades);
                Console.WriteLine($"Sum of Grades: {sum}\n");

                // Task 3: Grade Addition
                Console.WriteLine("Task 3: Grade Addition");
                studentGrades.Add(90);
                DisplayArrayList(studentGrades);
                Console.WriteLine();

                // Task 4: Grade Removal
                Console.WriteLine("Task 4: Grade Removal");
                studentGrades.Remove(78);
                DisplayArrayList(studentGrades);
                Console.WriteLine();

                // Task 5: Grade Update
                Console.WriteLine("Task 5: Grade Update");
                int index95 = studentGrades.IndexOf(95);
                if (index95 != -1)
                {
                    studentGrades[index95] = 96;
                    DisplayArrayList(studentGrades);
                }
                else
                {
                    Console.WriteLine("Grade 95 not found in the list.");
                }
            }

            // Helper method to display the contents of ArrayList
            static void DisplayArrayList(ArrayList list)
            {
                foreach (var grade in list)
                {
                    Console.WriteLine(grade);
                }
            }

            // Helper method to calculate the sum of ArrayList elements
            static int CalculateSum(ArrayList list)
            {
                int sum = 0;
                foreach (var grade in list)
                {
                    sum += (int)grade;
                }
                return sum;
            }
        }

    }







