using FluentInterface.Models;

namespace FluentInterface
{
    public class FluentEmployee
    {
        private Employee employee = new Employee();

        public FluentEmployee NameOfTheEmployee(string fullName)
        {
            employee.FullName = fullName;
            return this;
        }
    
        public FluentEmployee Born(string dateOfBirth)
        {
            employee.DateOfBirth = Convert.ToDateTime(dateOfBirth); 
            return this;
        }

        public FluentEmployee WorkingOn(string Department)
        {
            employee.Department = Department;
            return this;
        }

        public FluentEmployee StaysAt(string Address)
        {
            employee.Address = Address;
            return this;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {employee.FullName}, \nDateOfBirth: {employee.DateOfBirth}, \nDepartment: {employee.Department}, \nAddress: {employee.Address}");
        }
    }
}
