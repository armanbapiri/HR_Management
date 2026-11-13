using HR_Management.Application.DTOs.Common;
using HR_Management.Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Management.Application.DTOs.Leave.LeaveRequset
{
    public class LeaveRequestDTO : BaseDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RequestDateTime { get; set; }

        public string RequestComment { get; set; }
        public DateTime DataActioned { get; set; }

        public bool? Approved { get; set; }

        public bool? Canceled { get; set; }



        public LeaveTypeDTO LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        
    }
}
