using System.Reflection.Metadata.Ecma335;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        public int NumberOfDays { get; set; }
        public int Perid { get; set; }
        public LeaveTypeVM LeaveType { get; set; }

    }
}