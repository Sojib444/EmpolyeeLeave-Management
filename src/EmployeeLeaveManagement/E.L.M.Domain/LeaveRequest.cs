﻿namespace E.L.M.Domain
{
	public class LeaveRequest
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public LeaveType LeaveType { get; set; }
		public int LeaveTypeId { get; set; }
		public DateTime DateRequested { get; set; }
		public string? RequestComments { get; set; }
		public DateTime? DateActioned { get; set; }
		public string? RequestingEmployeeId { get; set; }
		
		public Approve? ApproveRequest { get; set; }
	}
}