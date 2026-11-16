using System;
using System.Collections.Generic;
using System.Text;

namespace EFNetNoTrackingApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly BirthDate { get; set; }
    }
}
