using System;
namespace TeacherAndStudent
{
    public class Teacher
    {
        public Teacher()
        {
        }

        public void giveAnswer()
        {
            Console.WriteLine("the teacher is answering questation!");
        }

        public void teach(Student student)
        {
            student.learn();
        }
    }
}

