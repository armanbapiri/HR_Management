using HR_Management.Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Management.Domian.Entities
{
    public class LeaveAllocation : BaseDomainEntity
    {
        public int NumerOfDays { get; set; }

        public int Period { get; set; }

        #region Rellations

        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        #endregion
    }
}
