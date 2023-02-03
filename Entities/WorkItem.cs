using System;

namespace TMS.BusinessEntities
{
    public class WorkItem
    {
        public int WorkItemId { get; set; }
        public string WorkItemDescription { get; set; }
        public int ActivityId { get; set; }
        public int TaskId { get; set; }
        public int SubTaskId { get; set; }
    }
}
