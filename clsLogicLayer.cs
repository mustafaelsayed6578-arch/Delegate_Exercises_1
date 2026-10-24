using GradingSystem;
using System;
using System.Collections.Generic;

namespace Delegate_Exercises
{
    public class clsLogicLayer
    {
        public static void DisplayGradingInfo(List<Student> students, Func<List<int>, double> calcualteAverage, 
            Predicate<double> CheckIfPassed, Action<Student, double, bool> DisplayUserData)
        {
            foreach(var student in students)
            {
                double avg = calcualteAverage(student.Grades);
                bool IsPassed = CheckIfPassed(avg);
                DisplayUserData(student, avg, IsPassed);
            }

        }
    }
}
