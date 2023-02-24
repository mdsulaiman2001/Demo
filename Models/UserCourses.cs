using System.ComponentModel.DataAnnotations;

namespace SwordLMS.Web.Models
{
    public class UserCourses
    {
        [Key]
        public int UserId { get; set; }
            
        public int courseId { get; set; }
            
        public DateTime DateOfEnroll { get; set; }
            
        public int WatchedDuration { get; set; }
    }
}
