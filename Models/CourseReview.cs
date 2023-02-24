namespace SwordLMS.Web.Models
{
    public class CourseReview
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int userId { get;set; }

        public int authorId { get; set; }   

        public int rating { get; set; }
        public string comments { get; set; }

    }
}
