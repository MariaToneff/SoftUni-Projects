using System;
using System.Collections.Generic;
namespace StudentSystem
{
    public class StudentSystem
    {
        public StudentSystem()
        {
            this.Data = new List<Student>();
        }
        public List<Student> Data { get; set; }

        public void Create(Student student)
        {
            this.Data.Add(student);
        }

        public void Show(string name)
        {
            if (this.Data.Count == 0)
            {
                return;
            }

            foreach (var student in this.Data)
            {
                if (student.Name == name)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}