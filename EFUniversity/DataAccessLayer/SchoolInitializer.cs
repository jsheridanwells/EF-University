using EFUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFUniversity.DataAccessLayer
{
    public class SchoolInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            var courses = new List<Course>
            {
                new Course { Title = "Art", Credits = 4, CourseID = 1001},
                new Course { Title = "Music", Credits = 3, CourseID = 1002},
                new Course { Title = "Philosophy", Credits = 4, CourseID = 1003},
                new Course { Title = "Poetry", Credits = 4, CourseID = 1004},
                new Course { Title = "Classics", Credits = 5, CourseID = 1005},
            };

            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1001,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=1002,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=1004,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1001,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1003,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=1005,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1001},
            new Enrollment{StudentID=4,CourseID=1001,},
            new Enrollment{StudentID=4,CourseID=1002,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=1003,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1004},
            new Enrollment{StudentID=7,CourseID=1005,Grade=Grade.A},
            };


            students.ForEach(student => context.Students.Add(student));
            context.SaveChanges();
            courses.ForEach(course => context.Courses.Add(course));
            context.SaveChanges();
            enrollments.ForEach(enrollment => context.Enrollments.Add(enrollment));
            context.SaveChanges();


        }
    }
}