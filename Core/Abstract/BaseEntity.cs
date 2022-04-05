using System;

namespace Core.Abstract
{
    public abstract class BaseEntity  
    {
        public string CreatedBy { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }
        public string UpdateBy { get; set; }

    }
}
