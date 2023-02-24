namespace SwordLMS.Web.Models
{
    public class CourseTopics
    {
        public int Id { get; set; }
        public int CourseId { get; set; }

        public int topicsId { get; set; }
        public string TopicName { get; set; }

    }
}
