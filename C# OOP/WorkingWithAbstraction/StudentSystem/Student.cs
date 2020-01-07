namespace StudentSystem
{
    public class Student
    {
        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            var comment = "";

            if (this.Grade >= 5.00)
            {
                comment = "Excellent student.";
            }
            else if (this.Grade < 5.00 && this.Grade >= 3.50)
            {
                comment = "Average student.";
            }
            else
            {
                comment = "Very nice person.";
            }

            return $"{this.Name} is {this.Age} years old. {comment}";
        }
    }
}
