using System;
using System.Collections.Generic;
using System.Linq;

public class City
{
    public string Name { get; set; }
    public string Region { get; set; }
    public List<School> Schools { get; set; } = new List<School>();
}

public class School
{
    public string Name { get; set; }
    public int Space { get; set; }
    public List<Teacher> Teachers { get; set; } = new List<Teacher>();
}

public class Teacher
{
    public string Name { get; set; }
    public int TeacherId { get; set; }
}

class Program
{
    static void Main()
    {
        var city = new City
        {
            Name = "Amman",
            Region = "Jordan",
            Schools = new List<School>
            {
                new School
                {
                    Name = "School1",
                    Space = 1000,
                    Teachers = new List<Teacher>
                    {
                        new Teacher { Name = "Ali", TeacherId = 1 },
                        new Teacher { Name = "Ahmad", TeacherId = 2 }
                    }
                },
                new School
                {
                    Name = "School2",
                    Space = 800,
                    Teachers = new List<Teacher>
                    {
                        new Teacher { Name = "Mohannad", TeacherId = 3 },
                        new Teacher { Name = "Mohammad", TeacherId = 4 },
                        new Teacher { Name = "Mustafa", TeacherId = 5 }
                    }
                }
            }
        };

        Console.WriteLine($"City: {city.Name}, Region: {city.Region}");
        foreach (var school in city.Schools)
        {
            Console.WriteLine($" School: {school.Name}, Space: {school.Space}");
            foreach (var teacher in school.Teachers)
            {
                Console.WriteLine($"  Teacher: {teacher.Name}, ID: {teacher.TeacherId}");
            }
        }

        var schoolWithMostTeachers = city.Schools
            .OrderByDescending(s => s.Teachers.Count)
            .First();

        Console.WriteLine("\nSchool with the highest number of teachers:");
        Console.WriteLine($" Name: {schoolWithMostTeachers.Name}, Teachers: {schoolWithMostTeachers.Teachers.Count}");
    }
}
