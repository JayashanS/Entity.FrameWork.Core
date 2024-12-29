namespace EFCore.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public long EmpSalary { get; set; }

        public EmployeeDetails EmployeeDetails { get; set; }

        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
