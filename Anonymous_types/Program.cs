using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_types
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Student me = new();
            me.StudentId = 1;
            me.StudentName = "Tommy";
            me.age = 18;
            List<Student> StudentList = new List<Student>()
            {
                new Student() {StudentId = 1, StudentName = "John", age=18},
                new Student() {StudentId = 2, StudentName = "Steve",  age = 21 },
                new Student() {StudentId = 3, StudentName = "Bill",  age = 18 },
                new Student() {StudentId = 4, StudentName = "Ram" , age = 20  },
                new Student() {StudentId = 5, StudentName = "Ron" , age = 21 }
            };

            var student = from s in StudentList select new {id = s.StudentId, name = s.StudentName};
            foreach (var stud in student)
                Console.WriteLine(stud.id + " - " + stud.name);

            
            
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }
    }

}
