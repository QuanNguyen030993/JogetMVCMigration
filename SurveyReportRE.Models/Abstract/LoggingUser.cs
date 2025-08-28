namespace SurveyReportRE.Models
{
    /// <summary>
    /// This object is used for passing needed data from MVC Controller to dbContext
    /// </summary>
    public class LoggingUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        //public string AccessDeviceType { get; set; }
        //public string AccessDeviceName { get; set; }
        //public string AccessBrowserName { get; set; }

        public LoggingUser()
        {
            UserId = -1;
            UserName = "System";
        }

        public LoggingUser(int userId, string userName)
        {
            UserId = UserId;
            UserName = UserName;
        }
    }
}
