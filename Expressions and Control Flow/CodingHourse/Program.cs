using System;

namespace CodingHourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            int dailyCodingHours = 6;
            int semesterWeeks = 17;


            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            int weeklyCodingHourses = 5;
            int codingHourse = (dailyCodingHours * weeklyCodingHourses) * semesterWeeks;

            Console.WriteLine(codingHourse);

            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            int weeklyHourse = 52;

            double avregeInPercent = (100 / weeklyHourse) * (dailyCodingHours * weeklyCodingHourses);


            Console.WriteLine(avregeInPercent + "%");
        }
    }
}

