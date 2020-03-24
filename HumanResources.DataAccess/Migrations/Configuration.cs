namespace HumanResources.DataAccess.Migrations
{
    using HumanResources.DataAccess.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Employees.AddOrUpdate(
                i => i.Id,
                new Employee
                {
                    Id = 1,
                    Name = "Aleksey G",
                    Position = "Software Developer",
                    DateOfBirth = new DateTime(1993, 3, 2),
                    Email = "aleksey.g@gmail.com",
                    Phone = "+375295543452",
                    StartDate = new DateTime(2014, 11, 24)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Olga R",
                    Position = "Sales Manager",
                    DateOfBirth = new DateTime(1989, 10, 4),
                    Email = "olga.r@gmail.com",
                    Phone = "+375298543332",
                    StartDate = new DateTime(2016, 1, 20)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Michael L",
                    Position = "QA engineer",
                    DateOfBirth = new DateTime(1990, 5, 21),
                    Email = "michael.l@gmail.com",
                    Phone = "+375447983451",
                    StartDate = new DateTime(2017, 9, 14)
                }, 
                new Employee
                {
                    Id = 2,
                    Name = "Tom H",
                    Position = "Team Lead",
                    DateOfBirth = new DateTime(1984, 2, 15),
                    Email = "tom.h@gmail.com",
                    Phone = "+375447543332",
                    StartDate = new DateTime(2012, 5, 4)
                });

            context.Candidates.AddOrUpdate(
                i => i.Id,
                new Candidate
                {
                    Id = 1,
                    Name = "Alex A",
                    Position = "Project Manager",
                    DateOfBirth = new DateTime(1990, 10, 30),
                    Email = "alex.a@gmail.com",
                    Phone = "+375296688328"
                },
                new Candidate
                {
                    Id = 1,
                    Name = "Nicole A",
                    Position = "Software Developer",
                    DateOfBirth = new DateTime(1990, 10, 30),
                    Email = "nikole.a@gmail.com",
                    Phone = "+375297135020"
                },
                new Candidate
                {
                    Id = 1,
                    Name = "Kate L",
                    Position = "QA engineer",
                    DateOfBirth = new DateTime(1995, 10, 30),
                    Email = "kate.l@gmail.com",
                    Phone = "+375447832135"
                },
                new Candidate
                {
                    Id = 1,
                    Name = "Anton S",
                    Position = "Project Manager",
                    DateOfBirth = new DateTime(1978, 4, 10),
                    Email = "anton.s@gmail.com",
                    Phone = "+375295559342"
                },
                new Candidate
                {
                    Id = 1,
                    Name = "Robert P",
                    Position = "Sales Manager",
                    DateOfBirth = new DateTime(1980, 10, 11),
                    Email = "robert.p@gmail.com",
                    Phone = "+375293736343"
                });
        }
    }
}
