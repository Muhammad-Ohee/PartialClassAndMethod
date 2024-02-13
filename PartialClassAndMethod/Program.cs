//Console.WriteLine("Hello, OS");

namespace PartialClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialEmployee employee = new PartialEmployee
            {
                FirstName = "Tom",
                LastName = "Crusie",
                Salary = 100000,
                Gender = "Male"
            };

            employee.DisplayFullName();
            employee.DisplayEmployeeDetails();

            employee.PublicMethod();
        }
    }
}