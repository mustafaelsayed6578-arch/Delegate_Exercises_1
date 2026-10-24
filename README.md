# C# Grading System (Delegates)

A simple C# console application that collects student grades and displays a final report for each student. The project demonstrates the built-in delegates **Func**, **Predicate**, and **Action** along with **lambda expressions**.

## Overview
1. Enter a student's name and 5 grades (each between 0 and 100).
2. Repeat for as many students as you want, then type `done` to finish.
3. The program calculates each student's average, decides if they passed, and prints a formatted report.

## Concepts Used
- **Func<List<int>, double>**: calculates the average of the grades.
- **Predicate<double>**: checks whether the average meets the passing score (30 or higher).
- **Action<Student, double, bool>**: displays the student's report.
- **Lambda expressions**: `x => x.Average()` and `x => x >= 30`.
- **Input validation**: `int.TryParse` with a range check.
- **Separation of concerns**: data, logic, and display are in separate classes.

## Code Structure
| Element | Purpose |
|---------|---------|
| `Student` | Model class that holds the name and the list of grades |
| `Program` | Handles user input and starts the report |
| `clsLogicLayer` | Contains `DisplayGradingInfo`, which applies the delegates to each student |
| `Display` | Contains `DisplayUserData`, which prints the formatted report |

## How to Run
```bash
dotnet run
```

## Example
```
Please enter student's name: Ahmed
   - Subject 1: 80
   - Subject 2: 70
   - Subject 3: 90
   - Subject 4: 60
   - Subject 5: 75

Please enter student's name: done
```

Report output:
```
========================================
  Student Report: Ahmed
========================================
  Grades: 80, 70, 90, 60, 75
  Average Grade: 75.00
  Status: (Passed Successfully)
========================================
```

## Extending
Because the logic is passed in as delegates, you can change the behavior without modifying `DisplayGradingInfo`. For example:
- Change the passing score: `x => x >= 50`
- Use a different calculation: `x => x.Max()`
- Use a different output: write a new display method and pass it in.
