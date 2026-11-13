using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Management.Domian.Common
{
    public abstract class BaseDomainEntity
    {
        public int id { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
