using System;
class Program
{
    static void Main()
    {
        //adding elements using the add method
        IList<int> intList = new List<int>();
        intList.Add(10);
        intList.Add(20);
        intList.Add(30);
        intList.Add(40);

        //adding elemenst using the object initialiser
        IList<string> strList = new List<string>() { "one", "two", "three", "four", null, null };

        IList<Student> students = new List<Student>()
        {
            new Student() { StudentID = 1, StudentName = "Lara" },
            new Student() { StudentID = 2, StudentName = "Teena" },
            new Student() { StudentID = 3, StudentName = "Peter" },
            new Student() { StudentID = 4, StudentName = "John" }

        };
    }
 }

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }

    //default constructor
    public Student()
    {
        StudentID = 0;
        StudentName = string.Empty;
    }

    //parameterised constructor
    public Student(int sid, string name)
    {
        this.StudentID = sid;
        this.StudentName = name;
    }
}