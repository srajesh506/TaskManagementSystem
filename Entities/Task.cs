using System;

namespace TMS.BusinessEntities
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public Boolean IsActive { get; set; }
        public int ActivityId { get; set; }
        public int ProjectId { get; set; }
    }
}
