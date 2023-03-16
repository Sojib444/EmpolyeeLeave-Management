using E.L.M.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Context
{
	public class EmployeeContext : DbContext
	{
		public EmployeeContext(DbContextOptions dbContext) : base(dbContext)
		{

		}

		DbSet<Employee> employees { get; set; }
		DbSet<LeaveRequest> leaveRequests { get; set; }
		DbSet<Approve> approves { get; set; }
	}
}
