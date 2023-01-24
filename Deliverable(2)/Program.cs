/*
 Author: Elisha Doan
 Date: 1/23/23
 Description: C# Console Application for calculating letter grades 
*/

using System;
using System.Linq.Expressions;

namespace Deliverable_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerical grade: ");

            try
            {

                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is A");
                }

                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                }

                if (grade >= 80)
                {
                    letter = "B";
                    Console.WriteLine("Your Expected letter grade for ISM 4300 is B");
                }

                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your Expected letter grade for ISM 4300 is C");
                }

                else if (grade >= 60 && grade <70)
                {
                    letter = "D";
                    Console.WriteLine("Your Expected letter grade for ISM 4300 is D");
                }

                else if (grade >= 0 && grade <60)
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is F");
                }
            }
            catch
            {
                Console.WriteLine("Enter a numeric value");
            }

        }
    }
}