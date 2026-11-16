using EFNetNoTrackingApp;
using Microsoft.EntityFrameworkCore;

using (EmployeeDbContext context = new())
{
    //context.Database.EnsureDeleted();
    //context.Database.EnsureCreated();

    //List<Employee> employees = new()
    //{
    //    new()
    //    {
    //        Name = "Bobby",
    //        BirthDate = new(1997, 10, 21)
    //    },
    //    new()
    //    {
    //        Name = "Garry",
    //        BirthDate = new(2001, 6, 18)
    //    },
    //    new()
    //    {
    //        Name = "Mikky",
    //        BirthDate = new(1993, 2, 5)
    //    },
    //    new()
    //    {
    //        Name = "Kitty",
    //        BirthDate = new(2002, 11, 18)
    //    }
    //};

    //context.Employees.AddRange(employees);
    //context.SaveChanges();

    var employees = context.Employees.AsNoTracking().ToList();

    //var first = context.Employees.FirstOrDefault();
    //if (first is not null)
    //{
    //    first.BirthDate = first.BirthDate.AddYears(-10);
    //    context.Update(first);
    //    context.SaveChanges();
    //}

    foreach (var employee in employees)
    {
        var age = DateTime.Now.Year - employee.BirthDate.Year;
        Console.WriteLine($"{employee.Name} {age}");
    }
        
}
