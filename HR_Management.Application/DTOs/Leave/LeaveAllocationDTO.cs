using HR_Management.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Management.Application.DTOs.Leave
{
    public class LeaveAllocationDTO :BaseDTO
    {
        public int NumerOfDays { get; set; }

        public int Period { get; set; }

        public LeaveTypeDTO LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        
    }
}
