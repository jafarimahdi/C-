using System;

namespace TeacherAndStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Student and Teacher classes
            // Student
            // learn()->prints: the student is actually learning
            // question(teacher)->calls the teacher's giveAnswer() method
            // Teacher
            // teach(student)->calls the student's learn() method
            // giveAnswer()->prints: the teacher is answering a question
            // Instantiate a Student and Teacher object
            // Call the student's question() method and the teacher's teach() method


            var student1 = new Student();
            var teacher1 = new Teacher();

            student1.questation(teacher1);
            Console.WriteLine("--------");
            teacher1.teach(student1);


        }
    }
}

