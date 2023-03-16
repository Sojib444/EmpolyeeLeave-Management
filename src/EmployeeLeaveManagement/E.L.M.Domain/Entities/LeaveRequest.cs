using E.L.M.Domain.Enum;

namespace E.L.M.Domain.Entities
{
    public class LeaveRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType? LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public Approve? ApproveRequest { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}