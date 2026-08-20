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
        private string name;
        private double score;
        public static int totalStudent;

        public Student(string name, double score)
        {
            this.name = name;
            this.score = score;
            totalStudent++;
        }

        public string GetName()
        {
            return name;
        }

        public double GetScore()
        {
            return score;
        }

        public bool IsPassed()
        {
            if (score >= 5.0)
                return true;
            else
                return false;
        }

        public string GetClassfication()
        {
            string result = "";
            if (score >= 8)
                result = "Excellent";
            else if (score >= 6.5)
                result = "Good";
            else if (score >= 5)
                result = "Average";
            else
                result = "Weak";

            return result;
        }

        public static int GetTotalStudent()
        {
            return totalStudent;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name} | Score: {score}");
            Console.WriteLine("Passed: " + IsPassed());
            Console.WriteLine("Classfication: " + GetClassfication());
            Console.WriteLine("The total of student: " + GetTotalStudent());
        }

        public static Student FindTopStudent(Student[] students)
        {
            Student Top = students[0];
            for (int i = 1; i < students.Length; i++)
            {
                if (students[i].score > Top.score)
                {
                    Top = students[i];
                }
            }
            return Top;
        }

        // Đã chuyển thành static để gọi trực tiếp từ Class Student
        public static double CalculateAverageScore(Student[] students)
        {
            double sum = 0;
            for (int i = 0; i < students.Length; i++)
            {
                sum += students[i].score;
            }
            double avgscore = sum / students.Length;
            return avgscore;
        }
    }
}