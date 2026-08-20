using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Entities
{
    public class Student
    {
        // Fields
        private string name;
        private double score;
        private static int totalStudents;
    
        // Constructor
        public Student(string name, double score)
        {
            this.name = name;
            this.score = score;
            totalStudents++;
        }
    
        // Instance Methods
        public string GetName()
        {
            return this.name;
        }
    
        public double GetScore()
        {
            return this.score;
        }
    
        public bool IsPassed()
        {
            if (this.score >= 5.0)
                return true;
            else
                return false;
        }
        
        public string GetClassification()
        {
            string result = "";
            if (this.score >= 8.0)
                result = "Excellent";
            else if (this.score >= 6.5)
                result = "Good";
            else if (this.score >= 5.0)
                result = "Average";
            else
                result = "Weak";
            return result;
        }
    
        // Static Methods
        public static int GetTotalStudents()
        {
            return totalStudents;
        }
        
        

        public static Student FindTopStudent(Student[] students)
        {
            Student topStudent = students[0];
            for (int i = 1; i < students.Length; i++)
            {
                if (students[i].score > topStudent.score)
                {
                    topStudent = students[i];
                }
            }
            return topStudent;
        }

        public static double CalculateAverageScore(Student[] students)
        {
            double sum = 0;
            for (int i = 0; i < students.Length; i++)
            {
                sum += students[i].score;
            }
            double average = sum / students.Length;
            return average;
        }
    }
} ////CODE INTERFACE /UI ( O PROGRAM.CS ) CUA FILE PROPERTIES

