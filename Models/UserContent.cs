namespace SwordLMS.Web.Models
{
    public class UserContent
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsCompleted { get; set; }
        public int WatchedDuration { get; set; }
    }
}
