using System;

namespace TMS.BusinessEntities
{
    public class Employee
    {
        public string UserId { get; set; }
        public string EmpName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public Boolean IsActive { get; set; }
        public string Remark { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Pic { get; set; }

    }
}