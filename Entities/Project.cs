using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.BusinessEntities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectManagerId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
      
    }
}
