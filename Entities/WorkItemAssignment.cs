using System;

namespace TMS.BusinessEntities
{
    public class WorkItemAssignment
    {
        public int WorkItemAssignmentId { get; set; }
        public int WorkItemId { get; set; }
        public string UserIdAssigned { get; set; }
        public string UserIdHandedOver { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime HandOverOrClosedDate { get; set; }
        public int Status { get; set; }
        public string Remarks { get; set; }

    }
}
