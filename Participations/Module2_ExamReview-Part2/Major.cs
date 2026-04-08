using System;
using System.Collections.Generic;
using System.Text;

namespace Module2_ExamReview_Part2
{
    public class Major
    {
        public string MajorName { get; set; }
        public double AverageSalary { get; set; }
        public double RequriedGPA { get; set; }
        public double GraduationRate { get; set; }
        public double AverageStudentDebt { get; set; }
        public int NumberOfStudents { get; set; }
        public int RequiredCourses { get; set; }

        public Major()
        {
            MajorName = string.Empty;
            AverageSalary = 0;
            RequriedGPA = 0;
            GraduationRate = 0;
            AverageStudentDebt = 0;
            NumberOfStudents = 0;
            RequiredCourses = 0;
        }

        public Major(double salary) : this()
        {
            AverageSalary = salary;
            //MajorName = string.Empty;
            //RequriedGPA = 0;
            //GraduationRate = 0;
            //AverageStudentDebt = 0;
            //NumberOfStudents = 0;
            //RequiredCourses = 0;
        }
        public Major(double salary, string name) : this()
        {
            AverageSalary = salary;
            MajorName = name;
            //RequriedGPA = 0;
            //GraduationRate = 0;
            //AverageStudentDebt = 0;
            //NumberOfStudents = 0;
            //RequiredCourses = 0;
        }

        public override string ToString()
        {
            return $"{MajorName} has a required gpa of {RequriedGPA.ToString("N")}";
        }

    }
}
