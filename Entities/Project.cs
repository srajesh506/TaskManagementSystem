using System;


namespace TMS.BusinessEntities
{
    public class Project
    {
        public int ProjectId { get; set; }
       
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public Boolean IsActive { get; set; }
    }
}
