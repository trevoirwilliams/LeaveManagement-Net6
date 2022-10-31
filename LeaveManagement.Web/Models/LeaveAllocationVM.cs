using System.Reflection.Metadata.Ecma335;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public int Perid { get; set; }
        public LeaveTypeVM LeaveType { get; set; }

    }
}