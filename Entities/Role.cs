using System;

namespace TMS.BusinessEntities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public Boolean IsAdmin { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
