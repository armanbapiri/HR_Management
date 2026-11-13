using HR_Management.Application.DTOs.Common;
using HR_Management.Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Management.Application.DTOs.Leave
{
    public class LeaveTypeDTO : BaseDTO
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
