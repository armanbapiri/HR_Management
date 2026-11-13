using HR_Management.Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Management.Domian.Entities
{
    internal class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
