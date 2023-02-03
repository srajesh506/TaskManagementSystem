using System;

namespace TMS.BusinessEntities
{
    public class SubTask
    {
        public int SubTaskId { get; set; }
        public string SubTaskName { get; set; }
        public string SubTaskDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public Boolean IsActive { get; set; }
        public int ActivityId { get; set; }
        public int TaskId { get; set; }
    }
}
