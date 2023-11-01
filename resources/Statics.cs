namespace IcoCraft.resources
{
    internal class Statics
    {
        private static readonly DateTime _dateTimeStamp = DateTime.Now;
        private static readonly string _currentUser = Environment.UserName;

        public static DateTime DateTimeStamp
        {
            get => _dateTimeStamp;
        }

        public static string CurrentUser
        {
            get => _currentUser;
        }
    }
}
