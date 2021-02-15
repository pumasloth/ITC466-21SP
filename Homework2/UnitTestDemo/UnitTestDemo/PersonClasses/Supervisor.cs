namespace UnitTestDemo.PersonClasses
{
    using System.Collections.Generic;

    public class Supervisor : Person
    {
        public List<Employee> Employees { get; set; }
    }
}
