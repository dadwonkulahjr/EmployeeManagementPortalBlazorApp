namespace EmployeePortal.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string? DepartmentName { get; set; }

        public Department(int departmentId, string departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }
        public Department()
        {
            DepartmentId = 17019;
            DepartmentName = "Information Technology";
        }
    }
}
