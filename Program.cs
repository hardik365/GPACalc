//Hardik Shahu
///Free Code Adademy GPA Calculation Project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student name and her classes
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            //The grades she got
            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            //What each grade is worth points wise
            int gradeA = 4;
            int gradeB = 3;

            //assign grade to each course
            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            //Variable to store total credit hours
            int totalCreditHours = 0;

            //To increment the sum to represent the total number of credit hours
            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            //Adding them to one variable
            totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

            //Variable to store total grade points
            int totalGradePoints = 0;

            //To increment the sum by the grade points earned 
            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            //Variable to store GPA
            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

            //For the GPA
            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;


            //Print it out to the console the stuff we need
            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

            Console.WriteLine($"{course1Name}\t\t{course1Grade}\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t{course2Grade}\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t{course3Grade}\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t{course4Grade}\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t{course5Grade}\t{course5Credit}");
            Console.WriteLine($"\nFinal GPA:\t\t {leadingDigit}.{firstDigit}{secondDigit}");

            //So that it stays on the console and doesnt exit right away
            Console.ReadLine();



        }
    }
}
