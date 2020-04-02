using System;

namespace OOP
{
    public class Inheritance
    {
        public class Employee : Person
        {
            public DateTime HiringDate { get; set; }
            public string Identification { get; set; }
        }

        public class Process
        {
            public void Execution()
            {
                var employee = new Employee()
                {
                    Name = "Denis Silva",
                    DateOfBirth = Convert.ToDateTime("1989/03/11"),
                    HiringDate = DateTime.Now,
                    Identification = "0123456",
                };

                employee.CalculateAge();
            }
        }
    }
}
