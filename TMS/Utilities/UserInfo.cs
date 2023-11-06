//namespace TMS.UI.Utilities
namespace TMS.BusinessEntities
{
   static class UserInfo
    {

        private static string UserID = "";

        public static string userId
        {
            get { return UserID; }
            set { UserID = value; }
        }
        private static string RoleID = "";
        public static string roleID
        {
            get { return RoleID; }
            set { RoleID = value; }
        }
        private static string ProjectID = "";
        public static string projectID
        {
            get { return ProjectID; }
            set { ProjectID = value; }
        }
        private static string FormName = "";
        public static string formname
        {
            get { return FormName.Trim(); }
            set { FormName = value; }
        }
        private static int SelectedValue;
        public static int selectedvalue
        {
            get { return SelectedValue; }
            set { SelectedValue = value; }
        }

        private static string TaskManagementPageName;
        public static string Taskmanagementpagename
        {
            get { return TaskManagementPageName; }
            set { TaskManagementPageName = value; }
        }


    }
}
