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
            Student s1 = new Student("David", 9);
            Student s2 = new Student("Anna", 8);
            Student s3 = new Student("Lily", 7);

            s1.DisplayInfo();
            s2.DisplayInfo();
            s3.DisplayInfo();

            // Tạo mảng danh sách học sinh
            Student[] students = { s1, s2, s3 };

            // Tìm học sinh giỏi nhất
            Student Top = Student.FindTopStudent(students);
            Console.WriteLine("\nTop student: " + Top.GetName());
            Console.WriteLine("Top score: " + Top.GetScore());
            Console.WriteLine();

            // Gọi hàm tính điểm trung bình qua static
            double avg = Student.CalculateAverageScore(students);
            Console.WriteLine("Average score: " + avg);

            Console.ReadLine(); // Giữ màn hình Console
        }
    }
}