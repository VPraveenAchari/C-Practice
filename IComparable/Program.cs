using System;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace IComparableDemo
{
    class Student:IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }
        int IComparable<Student>.CompareTo(Student? other)
        {

            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
    }
    class CompareStudents : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if(x.Marks<y.Marks)
                return -1;
            else
                return 0;
        }
    }

    public class TestStudent
    {
        
        public void display()
        {
            Student s1 = new Student() { Sid = 101, Name = "Praveen", Class = 10, Marks = 385.45f };
            Student s2 = new Student() { Sid = 103, Name = "Harsha", Class = 10, Marks = 421.66f };
            Student s3 = new Student() { Sid = 104, Name = "Pavan", Class = 10, Marks = 380.33f };
            Student s4 = new Student() { Sid = 102, Name = "David", Class = 10, Marks = 460.63f };
            Student s5 = new Student() { Sid = 105, Name = "Ramakrishna", Class = 10, Marks = 375.44f };

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5 };
            CompareStudents obj= new CompareStudents(); ;
          
            students.Sort(obj);
            foreach(Student s in students)
            {
                Console.WriteLine(s.Sid+" "+s.Name+" "+s.Class+" "+s.Marks);
            }
        }
        public static void Main(string[] args)
        {
            TestStudent y= new TestStudent();
            y.display();
        }
        
    }
}