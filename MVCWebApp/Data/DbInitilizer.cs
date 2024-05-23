using MVCWebApp.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace MVCWebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StudentRecord context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.StudentModel.Any())
            {
                return;   // DB has been seeded
            }

            var students = new StudentModel[]
            {
            new StudentModel{Name="Carson",Email="Alexander",Contact="4567891234"},
            new StudentModel{Name="Meredith",Email="Alonso",Contact="4563461234"},
            new StudentModel{Name="Arturo",Email="Anand",Contact="4568247234"},
            new StudentModel{Name="Gytis",Email="Barzdukas",Contact="9764891234"},
            new StudentModel{Name="Yan",Email="Li",Contact="4567893578"},
            new StudentModel{Name="Peggy",Email="Justice",Contact="5149891234"},
            new StudentModel{Name="Laura",Email="Norman",Contact="4567865481"},
            new StudentModel{Name="Nino",Email="Olivetto",Contact="4375942234"}
            };
            foreach (StudentModel s in students)
            {
                context.StudentModel.Add(s);
            }
            context.SaveChanges();
        }
    }
}