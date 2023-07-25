using System.Security.Principal;

namespace IcoCraft.resources
{
    internal class Statics
    {
        private readonly static DateTime _dateTimeStamp = DateTime.Now;
        private readonly static string _currentUser = WindowsIdentity.GetCurrent().Name;
        private static string? _primaryDestDirPath;
        private static string? _altDestDirPath;

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
            private set { _primaryDestDirPath = $@"C:\Users\{CurrentUser}\OneDrive\Documents\"; }
        }

        public static string AltDestDirPath
        {
            get { return _altDestDirPath!; }
            private set { _altDestDirPath = $@"C:\{CurrentUser}\Documents\"; }
        }
    }
}
