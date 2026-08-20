using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.Entities;

namespace Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("David", 8.0);
            Student student2 = new Student("Anna", 9.6);
            Student student3 = new Student("Lily", 7.8);
            Student student4 = new Student("John", 5.5);
    
            Student[] students = { student1, student2, student3, student4 };
    
            Console.WriteLine("Name: " + student1.GetName());
            Console.WriteLine("Score: " + student1.GetScore());
            Console.WriteLine("Passed: " + student1.IsPassed());
            Console.WriteLine("Classification: " + student1.GetClassification());
            Console.WriteLine();

            Console.WriteLine("Total students: " + Student.GetTotalStudents());
    
            Student topStudent = Student.FindTopStudent(students);
            Console.WriteLine("Top student: " + topStudent.GetName());
            Console.WriteLine("Top score: " + topStudent.GetScore());
            Console.WriteLine();
    
            double average = Student.CalculateAverageScore(students);
    
            Console.WriteLine("Average score: " + average);
            Console.ReadLine(); 
        }
    }
}
