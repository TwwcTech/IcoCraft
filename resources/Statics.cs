namespace IcoCraft.resources
{
    internal class Statics
    {
        private static DateTime _dateTimeStamp = DateTime.Now.Date;
        private static string _currentUser = Environment.UserName;
        private static string? _primaryDestDirPath = $@"C:\Users\{CurrentUser}\OneDrive\Documents\";
        private static string? _altDestDirPath = $@"C:\{CurrentUser}\Documents\";

        public static DateTime DateTimeStamp
        {
            get { return _dateTimeStamp; }
        }

        public static string CurrentUser
        {
            get { return _currentUser; }
        }

        public static string PrimaryDestDirPath
        {
            get { return _primaryDestDirPath!; }
        }

        public static string AltDestDirPath
        {
            get { return _altDestDirPath!; }
        }
    }
}
