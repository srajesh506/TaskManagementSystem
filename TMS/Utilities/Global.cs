namespace TMS.UI.Utilities
{
   static class Global
    {

        private static string s_globalVar = "";

        public static string GlobalVar
        {
            get { return s_globalVar; }
            set { s_globalVar = value; }
        }

    }
}
