namespace CollegeDBEF.Migrations
{
    using CollegeDBEF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CollegeDBEF.DAL.CollegeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CollegeDBEF.DAL.CollegeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //var departmentTypes = new List<DepartmentTypes>
            //{
            //    new DepartmentTypes {Type = "Mathematics" },
            //    new DepartmentTypes{Type = "English"},
            //    new DepartmentTypes{Type = "Philospophy" },
            //    new DepartmentTypes{Type = "Astronomy" },
            //    new DepartmentTypes{Type = "Economics" }
            //};

            //departmentTypes.ForEach(s => context.DepartmentTypes.Add(s));
            //context.SaveChanges();

            //var scoreTypes = new List<ScoreTypes>
            //{
            //    new ScoreTypes{Type = "Homework" },
            //    new ScoreTypes{Type = "Essay" },
            //    new ScoreTypes{Type = "Quiz" },
            //    new ScoreTypes{Type = "Lab" },
            //    new ScoreTypes{Type = "Test" }
            //};

            //scoreTypes.ForEach(s => context.ScoreTypes.Add(s));
            //context.SaveChanges();

            //var students = new List<Students>
            //{
            //    new Students{ FName = "Andrew", LName = "DiBacco",  SSN = 123456789, Address = "101 Wisteria Lane", City = "Cleveland", State = "Ohio", ZipCode = 44094,  Phone = 5554094902 },
            //    new Students { FName = "Sam", LName = "Nasr", SSN = 111223333, Address = "305 Brook Drive", City = "Ohio City", State = "Ohio", ZipCode = 44094, Phone = 5559084567 },
            //    new Students{ FName = "Alex", LName = "Shaw", SSN = 222334444, Address = "120 Western Circle", City = "McDonald", State = "Pennsylvania", ZipCode = 32464, Phone = 4449053920 }
            //};

            //students.ForEach(s => context.Students.Add(s));
            //context.SaveChanges();

            //var classes = new List<Classes>
            //{
            //    new Classes{Title = "Algebra", Number = 101, DepartmentTypesID = 1 },
            //    new Classes{Title = "British Literature", Number = 205, DepartmentTypesID = 2 },
            //    new Classes{Title = "Advanced Philosophy", Number = 301, DepartmentTypesID = 3 }
            //};

            //classes.ForEach(s => context.Classes.Add(s));
            //context.SaveChanges();

            //var studentClasses = new List<StudentClasses>
            //{
            //   new StudentClasses {StudentsID = 1, ClassesID = 1 },
            //   new StudentClasses {StudentsID = 1, ClassesID = 2 },
            //   new StudentClasses {StudentsID = 2, ClassesID = 2 },
            //   new StudentClasses {StudentsID = 2, ClassesID = 3 },
            //   new StudentClasses {StudentsID = 3, ClassesID = 3 }
            //};

            //studentClasses.ForEach(s => context.StudentClasses.Add(s));
            //context.SaveChanges();


            //var scores = new List<Scores>
            //    {
            //    new Scores{ScoreTypesID = 1, StudentClassesID = 1, Description = "Intro to algebra", DateAssigned = DateTime.Now,DateDue = DateTime.Now, DateSubmitted = DateTime.Now, PointsEarned = 8, PointsPossible = 10 },
            //    new Scores{ScoreTypesID = 2, StudentClassesID = 4, Description = "Beowulf", DateAssigned = DateTime.Now,DateDue = DateTime.Now, DateSubmitted = DateTime.Now, PointsEarned = 70, PointsPossible = 100 },
            //    new Scores{ScoreTypesID = 3, StudentClassesID = 2, Description = "Balancing equations", DateAssigned = DateTime.Now,DateDue = DateTime.Now, DateSubmitted = DateTime.Now, PointsPossible = 11, PointsEarned = 15 }
            //    };

            //scores.ForEach(s => context.Scores.Add(s));
            //context.SaveChanges();



            //Batch 2


            //var departmentTypes = new List<DepartmentTypes>
            //{
            //    new DepartmentTypes {Type = "Physics" }
            //};

            //departmentTypes.ForEach(s => context.DepartmentTypes.Add(s));
            //context.SaveChanges();

            //var scoreTypes = new List<ScoreTypes>
            //{
            //    new ScoreTypes{Type = "Capstone" }

            //};

            //scoreTypes.ForEach(s => context.ScoreTypes.Add(s));
            //context.SaveChanges();

            //var students = new List<Students>
            //{
            //    new Students{ FName = "Laurene", LName = "DiBacco",  SSN = 174456789, Address = "101 Wisteria Lane", City = "Cleveland", State = "Ohio", ZipCode = 44094,  Phone = 5534594902 }
            //};

            //students.ForEach(s => context.Students.Add(s));
            //context.SaveChanges();

            //var classes = new List<Classes>
            //{
            //    new Classes{Title = "Intro to Physics", Number = 101, DepartmentTypesID = 6, Instructor = "Sam Nasr" }
            //};

            //classes.ForEach(s => context.Classes.Add(s));
            //context.SaveChanges();

            //var studentClasses = new List<StudentClasses>
            //{
            //   new StudentClasses {StudentsID = 4, ClassesID = 4 }
            //};

            //studentClasses.ForEach(s => context.StudentClasses.Add(s));
            //context.SaveChanges();


            //var scores2 = new List<Scores>
            //{
            //   new Scores{ScoreTypes = context.ScoreTypes.Find(4), StudentClasses = context.StudentClasses.Find(6), Description = "Intro hw", DateAssigned = DateTime.Now,DateDue = DateTime.Now, DateSubmitted = DateTime.Now, PointsEarned = 8, PointsPossible = 10 }
            //};

            //scores2.ForEach(s => context.Scores.Add(s));
            //context.SaveChanges();
        }
    }
}
