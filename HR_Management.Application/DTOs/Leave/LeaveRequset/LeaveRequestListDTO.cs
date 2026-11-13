using HR_Management.Application.DTOs.Common;
using HR_Management.Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Management.Application.DTOs.Leave.LeaveRequset
{
    public class LeaveRequestListDTO : BaseDTO
    {
        public LeaveTypeDTO LeaveType { get; set; }
        public DateTime RequestDateTime { get; set; }
        public bool? Approved { get; set; }


        
    }
}
