using System;

namespace StudentSystem
{
    public class StartUp
    {
        public static void Main()
        {
            var studentSystem = new StudentSystem();


            while (true)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];

                switch (command)
                {
                    case "Create":
                        var name = input[1];
                        var age = int.Parse(input[2]);
                        var grade = double.Parse(input[3]);
                        var student = new Student(name, age, grade);

                        studentSystem.Create(student);
                        break;
                    case "Show":
                        var studentName = input[1];
                        studentSystem.Show(studentName);
                        break;
                    case "Exit":
                        return;
                }
            }
        }
    }
}
