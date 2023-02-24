namespace SwordLMS.Web.Models
{
    public class CourseContent
    {
        public int Id { get; set; }

        public int Course_id { get; set; }
        public int topic_id { get; set; }
            
        public string name { get; set; }

        public int content_type_id  { get; set; }
        public int duration { get; set; }

    }
}
