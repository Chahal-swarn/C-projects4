using System;
using System.Linq;

namespace CodeFirstExample
{
    class program
    {
        static void main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                context.Database.EnsureCreated();

                if (! context.Students.Any())
                {
                    var student = new Student
                    {
                        Name = "John",
                        Age =20
                    };
                    context.Students.Add(student);
                    context.SaveChanges();
                }
                var addedStudent= context.Students.First();
                console.WriteLine($"Student ID: { addedStudent.Id}, Name: {addedStudent.Name}, Age: { addedStudent.Age}");
            }
        }
    }
}