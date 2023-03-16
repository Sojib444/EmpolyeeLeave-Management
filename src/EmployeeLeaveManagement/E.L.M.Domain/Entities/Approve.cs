namespace E.L.M.Domain.Entities
{
    public class Approve
    {
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        List<Employee>? Employees { get; set; }
    }
}
