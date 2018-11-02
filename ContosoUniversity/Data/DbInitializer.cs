using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any())
            {
                return;
            }
            var students = new Student[]
            {
                new Student{FirstName="Shuhratjan",LastName="Nizamov",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstName="Nurtileu",LastName="Aliyas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Moldir",LastName="Kaliyas",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Nazym",LastName="Soltumuratova",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Asanali",LastName="Kereshov",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Muhamed",LastName="Tolemis",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstName="Saken",LastName="Baymukhamed",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Asylzhan",LastName="Erzhanov",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            foreach (Student student in students)
            {
                context.Students.Add(student);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
                new Course{CourseID=1045,Title="Calculus",Credits=4},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4},
                new Course{CourseID=2021,Title="Composition",Credits=3},
                new Course{CourseID=2042,Title="Literature",Credits=4}
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
