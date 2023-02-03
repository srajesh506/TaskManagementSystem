namespace TMS.UI.Utilities
{
   static class Global
    {
        //public static string ConnectedServerName=null;
        //public static string connecteddatabasename=null;
        //public static string dbname;

        private static string _globalVar = "";

        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }

    }
}
