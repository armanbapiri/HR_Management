using HR_Management.Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Management.Domian.Entities.Leave
{
    public class LeaveRequest : BaseDomainEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RequestDateTime { get; set; }

        public string RequestComment { get; set; }
        public DateTime DataActioned { get; set; }

        public bool? Approved { get; set; }

        public bool? Canceled { get; set; }


        #region Rellations

        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        #endregion
    }
}
