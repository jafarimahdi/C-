using System;
namespace TeacherAndStudent
{
    public class Student
    {
        public Student()
        {
        }

        public void learn()
        {
            Console.WriteLine("the Student is actually learning!");
        }

        public void questation(Teacher teacher)
        {
            teacher.giveAnswer();
        }

    }
}

