using EmployeePortal.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeePortal.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }


        protected override Task OnInitializedAsync()
        {
            LoadEmployeeData();
            return base.OnInitializedAsync();
        }
        private void LoadEmployeeData()
        {
            Employees = new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 1,
                    FirstName = "Precious",
                    LastName = "Wonkulah",
                    Email = "wonkulahp@yahoo.com",
                    Gender = Gender.Female,
                    Department = new(100, "Accounting"),
                    Dob = new(1976, 3, 28),
                    PhotoPath = "images/test.jpg"
                },

                new Employee()
                {
                    EmployeeId = 2,
                    FirstName = "Dacious",
                    LastName = "Wonkulah",
                    Email = "dacious@gmail.com",
                    Gender = Gender.Female,
                    Department = new(101, "Finance"),
                    Dob = new(2000, 3, 20),
                    PhotoPath = "images/quote2.jpg"
                },

                new Employee()
                {
                    EmployeeId = 3,
                    FirstName = "Darius",
                    LastName = "Wonkulah",
                    Email = "darious@gmail.com",
                    Gender = Gender.Male,
                    Department = new(200, "Engineering"),
                    Dob = new(2001, 10, 18),
                    PhotoPath = "images/jjc.jpg"
                },

                new Employee()
                {
                    EmployeeId = 4,
                    FirstName = "Dad",
                    LastName = "Wonkulah Sr",
                    Email = "sumo@gmail.com",
                    Gender = Gender.Male,
                    Department = new(300, "Economics"),
                    Dob = new(1980, 8, 20),
                    PhotoPath = "images/quote4.jpg"
                },
            };
        }
    }
}
