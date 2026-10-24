  using Delegate_Exercises;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingSystem
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Student> students = new List<Student>();


            while (true)
            {
                Console.Clear(); 
                Console.WriteLine("==================================================");
                Console.WriteLine("         🌟 WELCOME TO THE GRADING SYSTEM 🌟      ");
                Console.WriteLine("==================================================");
                Console.WriteLine("  [Tip] Type 'done' in the name field to finish.  ");
                Console.WriteLine("--------------------------------------------------\n");

                Console.Write("👉 Please enter student's name: ");
                string studentName = Console.ReadLine().Trim();

                if (studentName == "done")
                {
                    break;
                }

                List<int> studentGrades = new List<int>();
                Console.WriteLine($"\n📝 Enter grades for {studentName} (5 subjects):");

                for (int i = 1; i <= 5; i++)
                {
                    int gradeValue;
                    while (true)
                    {
                        Console.Write($"   - Subject {i}: ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out gradeValue) && gradeValue >= 0 && gradeValue <= 100)
                        {
                            break;
                        }
                        Console.WriteLine("   ❌ Invalid input! Please enter a number between 0 and 100.");
                    }
                    studentGrades.Add(gradeValue);
                }

                Student student = new Student
                {
                    Name = studentName,
                    Grades = studentGrades
                };

                students.Add(student);

                Console.WriteLine($"\n✨ Student '{student.Name}' added successfully!\n");
                Console.WriteLine("Press any key to continue to the next student...");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("             📊 FINAL STUDENTS REPORTS            ");
            Console.WriteLine("==================================\n");

            clsLogicLayer.DisplayGradingInfo(students, x => x.Average(), x => x >= 30,Display.DisplayUserData);
        }
       

    }
}
