Reflection Questions (after completing the exercise)
1.	Why must totalStudents be static instead of a regular instance field?
2.	Why must methods like FindTopStudent be static, while GetClassification() must not be?
3.	If you call student1.GetTotalStudents() (calling a static method through an object reference) — is this valid in C#? What happens, and does the compiler give any warning?
4.	What is the difference between accessing a static method via the class name (Student.GetTotalStudents()) and via an instance? Which one is considered good practice?
// ------------------//
1. Why totalStudents must be static:
•	Shared data: It counts the total number of ALL students combined.
•	Class-level: A static variable keeps one single value for the whole class, instead of creating a new copy for every student.
2. Why FindTopStudent is static, but GetClassification() is not:
•	FindTopStudent (Static): Needs to compare a whole list of many students, not just one.
•	GetClassification() (Instance): Needs the specific score of a single student to calculate their grade.
3. Calling student1.GetTotalStudents():
•	Invalid: C# does NOT allow calling static methods through an object.
•	Compiler Error: The code will fail to compile .
4. Accessing static methods & Good practice:
•	Class name (Student.GetTotalStudents()): The ONLY correct way to call it in C#.
•	Best practice: Using the class name makes it crystal clear that the method belongs to the entire class, not a single object.
