using GradingSystem;
using System;


namespace Delegate_Exercises
{
     public class Display
    {
        public static void DisplayUserData(Student student, double average, bool isPassed)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"  🎓 Student Report: {student.Name}");
            Console.WriteLine("========================================");

            Console.WriteLine($"  📝 Grades: {string.Join(", ", student.Grades)}");

            Console.WriteLine($"  📊 Average Grade: {average:F2}");

            if (isPassed)
            {
                Console.WriteLine("  🎉 Status: (Passed Successfully 🟢)");
            }
            else
            {
                Console.WriteLine("  ⚠️ Status: (Needs Improvement 🔴)");
            }
            Console.WriteLine("========================================\n");
        }
    }
}
