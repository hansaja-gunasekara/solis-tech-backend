namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public DateTime CreatedAt { get; set; }
        public int DepartmentId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
